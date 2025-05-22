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

namespace app.Presentation
{
    public partial class OrderForm : Form
    {
        private User _user;
        private OrderUC _orderUC;
        private OrderService _orderService;
        private DailySequenceService _dailySequenceService;

        private List<Customer> _customers;
        private List<Fabric> _fabrics;
        private List<Garment> _garments;
        private Fabric _fabric;
        private Garment _garment;

        private readonly string _MeasurementUnit = "cm";

        public OrderForm(OrderUC orderUC, User user, OrderService orderService, DailySequenceService dailySequenceService)
        {
            InitializeComponent();
            this._user = user;
            this._orderUC = orderUC;
            this._orderService = orderService;
            this._dailySequenceService = dailySequenceService;

            //garment_cb_SelectedIndexChanged(garment_cb, EventArgs.Empty);
            //this.Activated += OrderForm_Activated;
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            upper_body_rb.Checked = true; // Set default to upper body
            try
            {
                var task1 = LoadCustomers();
                var task2 = LoadFabrics();
                var task3 = LoadGarments();
                var taskOrderNumber = LoadOrderNumber();

                await Task.WhenAll(task1, task2, task3, taskOrderNumber);
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., using a logging framework)
                MessageBox.Show($"Error loading initial data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider closing the form or disabling functionality if critical data fails to load
            }
        }

        private async void OrderForm_Activated(object sender, EventArgs e)
        {
            try
            {
                var task1 = LoadCustomers();
                var task2 = LoadFabrics();
                var task3 = LoadGarments();
                var taskOrderNumber = LoadOrderNumber();

                await Task.WhenAll(task1, task2, task3, taskOrderNumber);
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

        private async Task LoadCustomers()
        {
            // Load fabrics from the database
            using (var context = new AppDbContext())
            {
                _customers = await context.Customers.ToListAsync();
            }

            customer_cb.DataSource = _customers;
            customer_cb.DisplayMember = "Name";
            customer_cb.ValueMember = "Id";
            customer_cb.SelectedIndex = -1;
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
            //fabric_cb.SelectedIndex = -1;

            if (_fabrics.Count > 0)
            {
                this._fabric = _fabrics[0];
                fabric_qty_num.Value = 1; // Set default quantity to 1
            }
            else
            {
                fabric_qty_num.Enabled = false; // Disable the quantity control if no fabrics are available
                fabric_qty_pn.BackColor = ColorTranslator.FromHtml("#f0f0f0");
            }

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
            //garment_cb.SelectedIndex = -1;

            if (_garments.Count > 0)
            {
                this._garment = _garments[0]; ;
            }
        }

        private void fabric_cb_Format(object sender, ListControlConvertEventArgs e)
        {
            // e.ListItem is the current Fabric object
            if (e.ListItem is Fabric fabric)
            {
                e.Value = fabric.MaterialType + " " + fabric.ColorName; // Or any formatting
            }
        }

        private async void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void create_order_btn_Click(object sender, EventArgs e)
        {
            if (customer_cb.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(customer_cb.SelectedValue.ToString(), out int customerId))
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

            if (!decimal.TryParse(subtotal_lb.Text, out decimal subtotal))
            {
                MessageBox.Show("Invalid subtotal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(discount_num.Text, out decimal discount))
            {
                MessageBox.Show("Invalid discount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(deposit_amount_num.Text, out decimal deposit_amount))
            {
                MessageBox.Show("Invalid deposit amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deposit_amount < (subtotal - discount) / 2)
            {
                MessageBox.Show("Deposit amount must be at least half of the subtotal after discount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deposit_amount > subtotal - discount)
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
                CustomerId = customerId,
                GarmentId = garmentId,
                FabricId = fabricId,
                FabricUsedQty = (int)fabric_qty_num.Value,
                DueDate = due_date_dpk.Value,
                Subtotal = subtotal,
                Discount = discount,
                DepositAmount = deposit_amount_num.Value,
                TotalAmount = totalAmount,
                Status = 0,
                Quantity = (int)quantity_num.Value,
                Notes = notes_txt.Text,
                UserId = this._user.Id,
            };

            if (upper_body_rb.Checked)
            {
                newOrder.Measurements = getUpperBodyMeasurements();
            }
            else if (lower_body_rb.Checked)
            {
                newOrder.Measurements = getLowerBodyMeasurements();
            }

            if (deposit_amount > 0)
            {
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
                await this._orderUC.LoadOrders();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void fabric_qty_num_ValueChanged(object sender, EventArgs e)
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

            var fabricUsedQty = (int)fabric_qty_num.Value;
            var fabricUnitPrice = _fabric?.UnitPrice ?? 0m; // Use 'm' for decimal literals
            var garmentBasePrice = _garment?.BasePrice ?? 0m;

            var subtotal = ((fabricUsedQty * fabricUnitPrice) + garmentBasePrice) * quantity_num.Value;
            var totalAmount = subtotal - discount_num.Value; // discount_num.Value is already decimal

            subtotal_lb.Text = $"{subtotal:N2}"; // "N2" for number with 2 decimal places
            total_amount_lb.Text = $"{totalAmount:N2}";
        }

        private async void garment_cb_SelectedValueChanged(object sender, EventArgs e)
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

        private async void fabric_cb_SelectedValueChanged(object sender, EventArgs e)
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
                    BodyPart = "neck",
                    Value = neck_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "shoulder",
                    Value = shoulder_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "chest",
                    Value = chest_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "upper waist",
                    Value = upper_waist_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "upper hip",
                    Value = upper_hip_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "sleeve length",
                    Value = sleeve_length_num.Value,
                    Unit = _MeasurementUnit,
                },
                 new Measurement
                {
                    BodyPart = "sleeve opening",
                    Value = sleeve_opening_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "shirt length",
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
                    BodyPart = "lower waist",
                    Value = lower_waist_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "lower hip",
                    Value = lower_hip_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "top thigh",
                    Value = top_thigh_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "thigh",
                    Value = thigh_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "knee",
                    Value = knee_num.Value,
                    Unit = _MeasurementUnit,
                },
                new Measurement
                {
                    BodyPart = "ankle",
                    Value = ankle_num.Value,
                    Unit = _MeasurementUnit,
                },
                 new Measurement
                {
                    BodyPart = "length",
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
    }
}
