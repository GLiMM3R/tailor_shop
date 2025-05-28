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
using app.Utils;

namespace app.Presentation
{
    public partial class OrderDetailUC : UserControl
    {
        private OrderUC _orderUC;
        private AppDbContext _context;
        public OrderService _orderService;
        public Order _order;
        private string _orderNumber;
        private List<Measurement> _measurements;
        public bool IsChanged { get; set; } = false;

        public OrderDetailUC(OrderUC orderUC, string orderNumber)
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeServices();

            _orderUC = orderUC;
            _orderNumber = orderNumber;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            _orderUC._mainForm.LoadFormIntoPanel(_orderUC);
        }
        private void InitializeServices()
        {
            _context = new AppDbContext();
            _orderService = new OrderService(_context);
        }

        private void InitializeDataGridView()
        {
            measurement_dgv.AutoGenerateColumns = false;
            measurement_dgv.Columns.Clear();

            measurement_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ລະຫັດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 20),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "BodyPart", headerText: "ສ່ວນຮ່າງກາຍ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Value", headerText: "ຄ່າວັດແທກ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Unit", headerText: "ຫົວໜ່ວຍ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50)
            );
        }

        public async Task LoadOrder()
        {
            var order = await _orderService.GetByOrderNumber(_orderNumber);

            if (order != null)
            {
                _order = order;

                order_number_lbl.Text = _order.OrderNumber;
                customer_name_lbl.Text = _order.Customer.Name;
                customer_phone_lbl.Text = _order.Customer.Phone;
                garment_lbl.Text = _order.Garment.Name;
                fabric_lbl.Text = $"{_order.Fabric.MaterialType} {_order.Fabric.ColorName}";
                fabric_used_qty_lbl.Text = _order.FabricUsedQty.ToString();
                order_date_lbl.Text = _order.CreatedAt.ToString("dd/MM/yyyy");
                due_date_lbl.Text = _order.DueDate?.ToString("dd/MM/yyyy") ?? "-";
                pick_up_date_lbl.Text = _order.PickUpDate?.ToString("dd/MM/yyyy") ?? "-";
                subtotal_val_lb.Text = _order.Subtotal.ToString("N2");
                discount_val_lb.Text = (-_order.Discount).ToString("N2");
                deposit_amount_val_lb.Text = _order.DepositAmount.ToString("N2");
                total_amount_lb.Text = _order.TotalAmount.ToString("N2");
                notes_txt.Text = _order.Notes;
                status_lbl.Text = _order.Status.ToString();

                if (_order.Status == OrderStatus.Completed)
                {
                    pay_btn.Enabled = false;
                    pay_btn.BackColor = Color.FromArgb(200, 200, 200);
                    pay_btn.Text = "ຈ່າຍແລ້ວ";

                    status_lbl.BackColor = Color.FromArgb(0, 200, 0);
                }
                else if (_order.Status == OrderStatus.Pending)
                {
                    pay_btn.Enabled = true;
                    pay_btn.BackColor = Color.FromArgb(33, 52, 72);
                    pay_btn.Text = "ຊຳລະເງິນ";

                    status_lbl.BackColor = Color.FromArgb(255, 200, 0);
                }
            }
        }
        private void LoadMeasurements()
        {
            using (var context = new AppDbContext())
            {
                _measurements = context.Measurements
                    .Where(m => m.OrderId == _order.Id)
                    .ToList();
            }

            if (_measurements.Count > 0)
            {
                measurement_dgv.DataSource = _measurements;
            }
        }

        private async void OrderDetailUC_Load(object sender, EventArgs e)
        {
            // Load the order details
            await LoadOrder();

            if (_order != null)
            {
                LoadMeasurements();

                if (_order.Status == OrderStatus.Completed || _order.Status == OrderStatus.PickedUp || _order.Status == OrderStatus.Canceled)
                {
                    pay_btn.Visible = false;
                }

                if(_order.Status == OrderStatus.PickedUp || _order.Status == OrderStatus.InProgress || _order.Status == OrderStatus.Canceled)
                {
                    pick_up_btn.Visible = false;
                }
            }

        }

        private async void pay_btn_Click(object sender, EventArgs e)
        {
            var form = new PaymentForm(this);
            form.ShowDialog();
            if (form.IsChanged == true)
            {
                await LoadOrder();
                IsChanged = false;
            }
        }

        private async void pick_up_btn_Click(object sender, EventArgs e)
        {
            try
            {
                _order.Status = OrderStatus.PickedUp;
                await _orderService.Update(_order);

                MessageBox.Show("Pick up successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsChanged = true;
                await LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
