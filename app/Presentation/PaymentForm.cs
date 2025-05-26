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

namespace app.Presentation
{
    public partial class PaymentForm : Form
    {
        private OrderDetailUC _orderDetailUC;
        private PaymentService _paymentService;
        private AppDbContext _context;
        private Order _order;
        public bool IsChanged { get; set; } = false;


        public PaymentForm(OrderDetailUC orderDetailUC)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _paymentService = new PaymentService(_context);
            _orderDetailUC = orderDetailUC;

            if (_orderDetailUC._order != null)
            {
                _order = _orderDetailUC._order;
            }
            else
            {
                MessageBox.Show("Order not found");
                this.Close();
            }
        }

        private void LoadItemsIntoListView()
        {
            items_lsv.Items.Clear();
            items_lsv.Columns.Clear();

            // Add columns: Name, Quantity, Price
            items_lsv.Columns.Add("ຊື່", 240, HorizontalAlignment.Left);
            items_lsv.Columns.Add("ຈຳນວນ", 80, HorizontalAlignment.Center);
            items_lsv.Columns.Add("ລາຄາ", 140, HorizontalAlignment.Right);

            // Add the order's garment as a single row
            var garment = new ListViewItem(_order.Garment.Name);
            garment.SubItems.Add(_order.Quantity.ToString());
            garment.SubItems.Add((_order.Garment.BasePrice * _order.Quantity)?.ToString("N2") ?? "0.00");

            var fabric = new ListViewItem(_order.Fabric.MaterialType + " " + _order.Fabric.ColorName);
            fabric.SubItems.Add(_order.FabricUsedQty.ToString());
            fabric.SubItems.Add((_order.Fabric.UnitPrice * _order.FabricUsedQty).ToString("N2") ?? "0.00");

            items_lsv.Items.AddRange([garment, fabric]);

            // Optional: set view to Details if not already set
            items_lsv.View = View.Details;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadItemsIntoListView();

            if (_order != null)
            {
                subtotal_val_lb.Text = _order.Subtotal.ToString("N2") ?? "0.00";
                discount_val_lb.Text = _order?.Discount.ToString("N2") ?? "0.00";
                deposit_amount_val_lb.Text = _order?.DepositAmount.ToString("N2") ?? "0.00";
                total_amount_lb.Text = _order?.TotalAmount.ToString("N2") ?? "0.00";
                amount_to_be_paid_lbl.Text = (_order?.TotalAmount - _order?.DepositAmount)?.ToString("N2") ?? "0.00";
            }
        }

        private async void cash_btn_Click(object sender, EventArgs e)
        {
            await CreateTransaction(TransactionType.Cash);
        }

        private async void bank_btn_Click(object sender, EventArgs e)
        {
            await CreateTransaction(TransactionType.Bank);
        }

        private async Task CreateTransaction(TransactionType transactionType)
        {
            if (_order == null)
            {
                MessageBox.Show("Order not found");
                return;
            }

            if (total_paying_num.Value != _order.TotalAmount - _order.DepositAmount)
            {
                MessageBox.Show("Invalid payment amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newPayment = new Payment()
                {
                    OrderId = _order.Id,
                    TotalPrice = _order.TotalAmount,
                    PaidAmount = total_paying_num.Value,
                    TransactionType = transactionType,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                await _paymentService.Create(newPayment);

                _order.Status = OrderStatus.Completed;
                _order.UpdatedAt = DateTime.Now;

                await _orderDetailUC._orderService.Update(_order);
                MessageBox.Show("Payment successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsChanged = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
