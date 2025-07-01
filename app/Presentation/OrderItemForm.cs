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
using static Azure.Core.HttpHeader;

namespace app.Presentation
{
    public partial class OrderItemForm : Form
    {
        private List<Fabric> _fabrics;
        private List<Garment> _garments;

        public OrderItem? existItem = null;
        public Fabric? selectedFabric = null;
        public Garment? selectedGarment = null;
        private OrderFormUC _orderForm;

        private readonly string _MeasurementUnit = "cm";
        public bool IsUpdate { get; set; } = false; // Flag to indicate if this is an update operation

        public OrderItemForm(OrderFormUC orderForm, OrderItem? item)
        {
            _orderForm = orderForm;
            InitializeComponent();

            if (item != null)
            {
                existItem = item;
            }
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                await Task.WhenAll(LoadFabrics(), LoadGarments());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading initial data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fillData();
        }

        private void fillData()
        {
            // Pre-select fabric
            if (existItem != null && _fabrics != null)
            {
                int fabricIdx = _fabrics.FindIndex(x => x.Id == existItem.FabricId);
                fabric_cb.SelectedIndex = fabricIdx >= 0 ? fabricIdx : -1;
                selectedFabric = fabricIdx >= 0 ? _fabrics[fabricIdx] : null;
            }

            // Pre-select garment
            if (existItem != null && _garments != null)
            {
                int garmentIdx = _garments.FindIndex(x => x.Id == existItem.GarmentId);
                garment_cb.SelectedIndex = garmentIdx >= 0 ? garmentIdx : -1;
                selectedGarment = garmentIdx >= 0 ? _garments[garmentIdx] : null;
            }

            if (existItem != null)
            {
                quantity_num.Value = (existItem.Quantity > quantity_num.Minimum && existItem.Quantity < quantity_num.Maximum)
                    ? existItem.Quantity
                    : quantity_num.Minimum;

                notes_txt.Text = existItem.Notes ?? string.Empty;

                // Fill measurements
                if (existItem.Measurements != null && existItem.Measurements.Count > 0)
                {
                    FillUpperBodyMeasurements(existItem.Measurements);
                    FillLowerBodyMeasurements(existItem.Measurements);
                }
                else
                {
                    upper_body_cb.Checked = false;
                    lower_body_cb.Checked = false;
                }
            }
        }

        private void FillUpperBodyMeasurements(IEnumerable<Measurement> measurements)
        {
            var upperParts = new HashSet<string> { "ຄໍ", "ບ່າໄຫຼ່", "ເອິກ", "ແອວ", "ສະໂພກ", "ຄວາມຍາວແຂນ", "ຄວາມຍາວປາຍແຂນ", "ຄວາມຍາວເສື້ອ" };
            var upperMeasurements = measurements
                .Where(m => upperParts.Contains(m.BodyPart) && m.Unit == _MeasurementUnit)
                .ToList();

            if (upperMeasurements.Count > 0)
            {
                upper_body_cb.Checked = true;
                foreach (var m in upperMeasurements)
                {
                    switch (m.BodyPart)
                    {
                        case "ຄໍ": neck_num.Value = m.Value; break;
                        case "ບ່າໄຫຼ່": shoulder_num.Value = m.Value; break;
                        case "ເອິກ": chest_num.Value = m.Value; break;
                        case "ແອວ": upper_waist_num.Value = m.Value; break;
                        case "ສະໂພກ": upper_hip_num.Value = m.Value; break;
                        case "ຄວາມຍາວແຂນ": sleeve_length_num.Value = m.Value; break;
                        case "ຄວາມຍາວປາຍແຂນ": sleeve_opening_num.Value = m.Value; break;
                        case "ຄວາມຍາວເສື້ອ": shirt_length_num.Value = m.Value; break;
                    }
                }
            }
            else
            {
                upper_body_cb.Checked = false;
            }
        }

        private void FillLowerBodyMeasurements(IEnumerable<Measurement> measurements)
        {
            var lowerParts = new HashSet<string> { "ແອວ", "ສະໂພກ", "ອ້ອງ", "ກົກຂາ", "ເຂົ່າ", "ປາຍຂາ", "ຄວາມຍາວ" };
            var lowerMeasurements = measurements
                .Where(m => lowerParts.Contains(m.BodyPart) && m.Unit == _MeasurementUnit)
                .ToList();

            if (lowerMeasurements.Count > 0)
            {
                lower_body_cb.Checked = true;
                foreach (var m in lowerMeasurements)
                {
                    switch (m.BodyPart)
                    {
                        case "ແອວ": lower_waist_num.Value = m.Value; break;
                        case "ສະໂພກ": lower_hip_num.Value = m.Value; break;
                        case "ອ້ອງ": top_thigh_num.Value = m.Value; break;
                        case "ກົກຂາ": thigh_num.Value = m.Value; break;
                        case "ເຂົ່າ": knee_num.Value = m.Value; break;
                        case "ປາຍຂາ": ankle_num.Value = m.Value; break;
                        case "ຄວາມຍາວ": length_num.Value = m.Value; break;
                    }
                }
            }
            else
            {
                lower_body_cb.Checked = false;
            }
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
            fabric_image_pb.Image = null; // Clear image initially

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

            CalculateTotal();


            //if (_garments.Count > 0)
            //{
            //    this._garment = _garments[0]; ;
            //}
        }

        private void fabric_cb_Format(object? sender, ListControlConvertEventArgs e)
        {
            // e.ListItem is the current Fabric object
            if (e.ListItem is Fabric fabric)
            {
                e.Value = $"{fabric.MaterialType} #{fabric.ColorCode}"; // Or any formatting
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_order_btn_Click(object sender, EventArgs e)
        {
            if (garment_cb.SelectedValue == null || selectedGarment == null)
            {
                MessageBox.Show("Please select a garment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(garment_cb.SelectedValue.ToString(), out int garmentId))
            {
                MessageBox.Show("Invalid garment selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fabric_cb.SelectedValue == null || selectedFabric == null)
            {
                MessageBox.Show("Please select a fabric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(fabric_cb.SelectedValue.ToString(), out int fabricId))
            {
                MessageBox.Show("Invalid fabric selection.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (upper_body_cb.Checked == false && lower_body_cb.Checked == false)
            {
                MessageBox.Show("Please select at least one measurement type (Upper Body or Lower Body).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(unitprice_lbl.Text, out decimal unitprice))
            {
                MessageBox.Show("Invalid Unitprice.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity_num.Value <= 0)
            {
                MessageBox.Show("Quantity must greater than 1", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (existItem != null)
            {
                // Update existing item
                existItem.GarmentId = garmentId;
                existItem.FabricId = fabricId;
                existItem.Quantity = (int)quantity_num.Value;
                existItem.UnitPrice = unitprice;
                existItem.Notes = notes_txt.Text;
                existItem.Garment = selectedGarment;
                existItem.Fabric = selectedFabric;
                existItem.Measurements.Clear();
                if (upper_body_cb.Checked)
                {
                    foreach (var measurement in getUpperBodyMeasurements())
                    {
                        existItem.Measurements.Add(measurement);
                    }
                }
                if (lower_body_cb.Checked)
                {
                    foreach (var measurement in getLowerBodyMeasurements())
                    {
                        existItem.Measurements.Add(measurement);
                    }
                }
            }
            else
            {
                // Add new item
                var newItem = new OrderItem
                {
                    GarmentId = garmentId,
                    FabricId = fabricId,
                    Quantity = (int)quantity_num.Value,
                    UnitPrice = unitprice,
                    Notes = notes_txt.Text,
                    Garment = selectedGarment,
                    Fabric = selectedFabric,
                    Measurements = new List<Measurement>()
                };

                if (upper_body_cb.Checked)
                {
                    foreach (var measurement in getUpperBodyMeasurements())
                    {
                        newItem.Measurements.Add(measurement);
                    }
                }

                if (lower_body_cb.Checked)
                {
                    foreach (var measurement in getLowerBodyMeasurements())
                    {
                        newItem.Measurements.Add(measurement);
                    }
                }

                _orderForm.items.Add(newItem);
            }

            _orderForm.LoadOrderItemsToList();
            this.Close();
        }

        private void fabric_qty_num_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateTotal();
        }

        private void CalculateTotal()
        {

            if (garment_cb.SelectedItem is Garment selectedGarment)
            {
                var garmentBasePrice = selectedGarment.BasePrice ?? 0m;

                var subtotal = (garmentBasePrice) * quantity_num.Value;

                quantity_lbl.Text = quantity_num.Value.ToString();
                unitprice_lbl.Text = $"{garmentBasePrice:N0}"; // "N2" for number with 2 decimal places
                total_lbl.Text = $"{subtotal:N0}";
            }
            else
            {
                quantity_lbl.Text = quantity_num.Value.ToString();
                unitprice_lbl.Text = "0"; // "N2" for number with 2 decimal places
                total_lbl.Text = "0";
            }
        }

        private void garment_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (garment_cb.SelectedItem is Garment selectedGarment)
            {
                this.selectedGarment = selectedGarment;
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
                this.selectedFabric = selectedFabric;
                if (selectedFabric.Image != null)
                {
                    using (var ms = new MemoryStream(selectedFabric.Image))
                    {
                        fabric_image_pb.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    fabric_image_pb.Image = null; // Clear image if no image is available
                }
            }
            else
            {
                //_fabric = null;
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
    }
}
