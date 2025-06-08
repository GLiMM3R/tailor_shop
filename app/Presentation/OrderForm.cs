using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Database;
using app.Model;
using app.Service;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app.Presentation
{
    public partial class OrderForm : Form
    {
        private User _user;
        private OrderService _orderService;
        private DailySequenceService _dailySequenceService;

        private List<Fabric> _fabrics;
        private List<Garment> _garments;
        private Fabric _fabric;
        private Garment _garment;

        private readonly string _MeasurementUnit = "cm";
        private Customer? _selectedCustomer = null;
        public bool IsUpdate { get; set; } = false; // Flag to indicate if this is an update operation

        public OrderForm(User user, OrderService orderService, DailySequenceService dailySequenceService)
        {
            InitializeComponent();
            this._user = user;
            this._orderService = orderService;
            this._dailySequenceService = dailySequenceService;

            //garment_cb_SelectedIndexChanged(garment_cb, EventArgs.Empty);
            //this.Activated += OrderForm_Activated;
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                var task2 = LoadFabrics();
                var task3 = LoadGarments();
                var taskOrderNumber = LoadOrderNumber();

                await Task.WhenAll(task2, task3, taskOrderNumber);
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., using a logging framework)
                MessageBox.Show($"Error loading initial data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider closing the form or disabling functionality if critical data fails to load
            }
        }

        private async Task LoadOrderNumber()
        {
            var orderNumber = await _dailySequenceService.GetNextSequence(DateTime.Now);
            order_number_lb.Text = orderNumber.ToString();
        }

        private async Task LoadFabrics()
        {
            using (var context = new AppDbContext())
            {
                _fabrics = await context.Fabrics.ToListAsync();
            }

            fabric_cb.DataSource = _fabrics;
            fabric_cb.ValueMember = "Id";
            fabric_cb.Format += fabric_cb_Format;
            fabric_cb.SelectedIndex = -1;

        }

        private async Task LoadGarments()
        {
            using (var context = new AppDbContext())
            {
                _garments = await context.Garments.ToListAsync();
            }

            garment_cb.DataSource = _garments;
            garment_cb.DisplayMember = "Name";
            garment_cb.ValueMember = "Id";
            garment_cb.SelectedIndex = -1;

            if (_garments.Count > 0)
            {
                this._garment = _garments[0]; ;
            }
        }

        private void fabric_cb_Format(object? sender, ListControlConvertEventArgs e)
        {
            // e.ListItem is the current Fabric object
            if (e.ListItem is Fabric fabric)
            {
                e.Value = $"#{fabric.ColorCode} " + fabric.MaterialType + " " + fabric.ColorName; // Or any formatting
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void create_order_btn_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Invalid customer selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (garment_cb.SelectedValue == null)
            {
                MessageBox.Show("Please select a garment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(garment_cb.SelectedValue.ToString(), out int garmentId))
            {
                MessageBox.Show("Invalid garment selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fabric_cb.SelectedValue == null)
            {
                MessageBox.Show("Please select a fabric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(fabric_cb.SelectedValue.ToString(), out int fabricId))
            {
                MessageBox.Show("Invalid fabric selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(upper_body_cb.Checked == false && lower_body_cb.Checked == false)
            {
                MessageBox.Show("Please select at least one measurement type (Upper Body or Lower Body).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(subtotal_lb.Text, out decimal subtotal))
            {
                MessageBox.Show("Invalid subtotal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(deposit_amount_num.Text, out decimal deposit_amount))
            {
                MessageBox.Show("Invalid deposit amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (deposit_amount < (subtotal) / 2)
            //{
            //    MessageBox.Show("Deposit amount must be at least half of the subtotal after discount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if(deposit_amount <= 0)
            {
                MessageBox.Show("Deposit amount cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deposit_amount > subtotal)
            {
                MessageBox.Show("Deposit amount cannot exceed the total amount after discount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(total_amount_lb.Text, out decimal totalAmount))
            {
                MessageBox.Show("Invalid total amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newOrder = new Order
            {
                OrderNumber = order_number_lb.Text,
                CustomerId = _selectedCustomer.Id,
                GarmentId = garmentId,
                FabricId = fabricId,
                DueDate = due_date_dpk.Value,
                Subtotal = subtotal,
                DepositAmount = deposit_amount_num.Value,
                TotalAmount = totalAmount,
                Quantity = (int)quantity_num.Value,
                Notes = notes_txt.Text,
                UserId = this._user.Id,
            };

            if (upper_body_cb.Checked)
            {
                foreach (var measurement in getUpperBodyMeasurements())
                {
                    newOrder.Measurements.Add(measurement);
                }
            }

            if (lower_body_cb.Checked)
            {
                foreach (var measurement in getLowerBodyMeasurements())
                {
                    newOrder.Measurements.Add(measurement);
                }
            }

            if (deposit_amount > 0)
            {
                newOrder.Status = OrderStatus.InProgress;
                newOrder.Payments = [
                    new Payment
                    {
                        TotalPrice = totalAmount,
                        PaidAmount = deposit_amount,
                        TransactionType = TransactionType.Deposit,
                    }
                ];
            }

            try
            {
                await _orderService.Create(newOrder);
                MessageBox.Show("Order created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsUpdate = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fabric_qty_num_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (fabric_cb.SelectedIndex == -1 && garment_cb.SelectedIndex == -1)
            {
                // Avoid calculation if called too early before selections are definitely made by Form_Activated
                return;
            }

            var garmentBasePrice = _garment?.BasePrice ?? 0m;

            var subtotal = (garmentBasePrice) * quantity_num.Value;
            var totalAmount = subtotal;

            subtotal_lb.Text = $"{subtotal:N2}"; // "N2" for number with 2 decimal places
            total_amount_lb.Text = $"{totalAmount:N2}";
        }

        private void garment_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (garment_cb.SelectedItem is Garment selectedGarment)
            {
                _garment = selectedGarment;
            }
            else
            {
                _garment = null;
            }

            CalculateTotal();
        }

        private void discount_num_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void fabric_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (fabric_cb.SelectedItem is Fabric selectedFabric)
            {
                _fabric = selectedFabric;
            }
            else
            {
                _fabric = null;
            }

            CalculateTotal();
        }

        private List<Measurement> getUpperBodyMeasurements()
        {
            var measurements = new List<Measurement>
            {
                new Measurement
                {
                    BodyPart = "ຄໍ",
                    Value = neck_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ບ່າໄຫຼ່",
                    Value = shoulder_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ເອິກ",
                    Value = chest_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ແອວ",
                    Value = upper_waist_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ສະໂພກ",
                    Value = upper_hip_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ຄວາມຍາວແຂນ",
                    Value = sleeve_length_num.Value,
                    Unit = _MeasurementUnit,
                },
                 new Measurement
                {
                    BodyPart = "ຄວາມຍາວປາຍແຂນ",
                    Value = sleeve_opening_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ຄວາມຍາວເສື້ອ",
                    Value = shirt_length_num.Value,
                    Unit = _MeasurementUnit,
                },
            };

            return measurements;
        }

        private List<Measurement> getLowerBodyMeasurements()
        {
            var measurements = new List<Measurement>
            {
                new Measurement
                {
                    BodyPart = "ແອວ",
                    Value = lower_waist_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ສະໂພກ",
                    Value = lower_hip_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ອ້ອງ",
                    Value = top_thigh_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ກົກຂາ",
                    Value = thigh_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ເຂົ່າ",
                    Value = knee_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ປາຍຂາ",
                    Value = ankle_num.Value,
                    Unit = _MeasurementUnit,
                },
                 new Measurement
                {
                    BodyPart = "ຄວາມຍາວ",
                    Value = length_num.Value,
                    Unit = _MeasurementUnit,
                }
            };

            return measurements;
        }

        private void quantity_num_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateTotal();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void choose_customer_btn_Click(object sender, EventArgs e)
        {
            var modal = new ListCustomerModal();
            modal.ShowDialog();

            if (modal.selectedCustomer != null)
            {
                _selectedCustomer = modal.selectedCustomer;
                customer_lbl.Text = modal.selectedCustomer.Name;
            }
        }

        private void upper_body_cb_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
