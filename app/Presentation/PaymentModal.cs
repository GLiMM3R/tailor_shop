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
    public partial class PaymentModal : Form
    {
        private AppDbContext _context;
        private OrderService _orderService;
        private OrderDetail _orderDetail;
        private PaymentService _paymentService;
        private Order _order;

        public PaymentModal(OrderDetail orderDetail, Order order)
        {
            InitializeComponent();
            InitializeServices();

            _orderDetail = orderDetail;
            _order = order;
        }

        private void InitializeServices()
        {
            _context = new AppDbContext();
            _orderService = new OrderService(_context);
            _paymentService = new PaymentService(_context);
        }

        private void PaymentModal_Load(object sender, EventArgs e)
        {
            if (_order != null)
            {
                subtotal_val_lb.Text = _order.Subtotal.ToString("N2");
                discount_val_lb.Text = (-_order.Discount).ToString("N2");
                deposit_amount_val_lb.Text = _order.DepositAmount.ToString("N2");
                total_amount_val_lb.Text = _order.TotalAmount.ToString("N2");
                total_paying_val_lb.Text = (_order.TotalAmount - _order.DepositAmount).ToString("N2");
            }
        }

        private async void confirm_btn_Click(object sender, EventArgs e)
        {
            if(_order == null)
            {
                MessageBox.Show("Order not found");
                return;
            }

            try
            {
                var newPayment = new Payment()
                {
                    OrderId = _order.Id,
                    TotalPrice = _order.TotalAmount,
                    PaidAmount = decimal.Parse(total_paying_val_lb.Text),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                await _paymentService.Create(newPayment);

                _order.Status = 2;
                _order.UpdatedAt = DateTime.Now;

                await _orderService.Update(_order);
                MessageBox.Show("Payment successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _orderDetail.IsChanged = true;
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
