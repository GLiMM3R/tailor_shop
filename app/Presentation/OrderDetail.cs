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
    public partial class OrderDetail : Form
    {
        private AppDbContext _context;
        private OrderService _orderService;
        private string _orderNumber;
        private Order _order;
        private List<Measurement> _measurements;
        public bool IsChanged { get; set; } = false;

        public OrderDetail(string orderNumber)
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeServices();

            _orderNumber = orderNumber;
        }

        private void InitializeServices()
        {
            _context = new AppDbContext();
            _orderService = new OrderService(_context);
        }

        private async void OrderDetail_Load(object sender, EventArgs e)
        {
            await LoadOrder();

            if (_order != null)
            {
                LoadMeasurements();

                order_number_val_lb.Text = _order.OrderNumber;
                customer_name_val_lb.Text = _order.Customer.Name;
                customer_phone_val_lb.Text = _order.Customer.Phone;
                garment_val_lb.Text = _order.Garment.Name;
                fabric_val_lb.Text = $"{_order.Fabric.MaterialType} {_order.Fabric.ColorName}";
                fabric_used_qty_val_lb.Text = _order.FabricUsedQty.ToString();
                order_date_val_lb.Text = _order.CreatedAt.ToString("dd/MM/yyyy");
                due_date_val_lb.Text = _order.DueDate?.ToString("dd/MM/yyyy") ?? "-";
                pick_up_date_val_lb.Text = _order.PickUpDate?.ToString("dd/MM/yyyy") ?? "-";
                subtotal_val_lb.Text = _order.Subtotal.ToString("N2");
                discount_val_lb.Text = (-_order.Discount).ToString("N2");
                deposit_amount_val_lb.Text = _order.DepositAmount.ToString("N2");
                total_amount_lb.Text = _order.TotalAmount.ToString("N2");
                notes_txt.Text = _order.Notes;

                if (_order.Status == OrderStatus.Completed)
                {
                    pay_btn.Enabled = false;
                    pay_btn.BackColor = Color.FromArgb(200, 200, 200);
                    pay_btn.Text = "Paid";
                }
                else
                {
                    pay_btn.Enabled = true;
                    pay_btn.BackColor = Color.FromArgb(33, 52, 72);
                    pay_btn.Text = "Pay";
                }
            }
        }

        private void InitializeDataGridView()
        {
            measurement_dgv.AutoGenerateColumns = false;
            measurement_dgv.Columns.Clear();

            measurement_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 20),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "BodyPart", headerText: "BodyPart", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Value", headerText: "Value", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Unit", headerText: "Unit", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50)
            );
        }

        public async Task LoadOrder()
        {
            var order = await _orderService.GetByOrderNumber(_orderNumber);

            if (order != null)
            {
                _order = order;
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

        private async void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            var form = new PaymentModal(this, _order);
            form.ShowDialog();
        }
    }
}
