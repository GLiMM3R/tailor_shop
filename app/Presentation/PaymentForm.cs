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
using app.Entity;
using app.Model;
using app.Service;
using app.Utils;
using QuestPDF.Fluent;

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
            garment.SubItems.Add((_order.Garment.BasePrice * _order.Quantity)?.ToString("N0") ?? "0");

            var fabric = new ListViewItem(_order.Fabric.MaterialType + " " + _order.Fabric.ColorName);
            fabric.SubItems.Add((1).ToString());
            fabric.SubItems.Add((0).ToString("N0") ?? "0");

            items_lsv.Items.AddRange([garment, fabric]);

            // Optional: set view to Details if not already set
            items_lsv.View = View.Details;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadItemsIntoListView();

            if (_order != null)
            {
                total_paying_num.Value = (_order?.TotalAmount - _order?.DepositAmount) ?? 0;
                subtotal_val_lb.Text = _order.Subtotal.ToString("N0") ?? "0";
                //discount_val_lb.Text = _order?.Discount.ToString("N0") ?? "0.00";
                deposit_amount_val_lb.Text = _order?.DepositAmount.ToString("N0") ?? "0";
                total_amount_lb.Text = _order?.TotalAmount.ToString("N0") ?? "0";
                amount_to_be_paid_lbl.Text = (_order?.TotalAmount - _order?.DepositAmount)?.ToString("N0") ?? "0";
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
                await _orderDetailUC._orderService.Update(_order);
                MessageBox.Show("Payment successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrintInvoice();
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

        private void PrintInvoice()
        {
            try
            {
                // Sample invoice data
                var invoiceModel = new InvoiceModel
                {
                    InvoiceNumber = _order.OrderNumber,
                    IssueDate = _order.CreatedAt,
                    DueDate = _order.DueDate,
                    SellerName = _order.User.Username,
                    CustomerName = _order.Customer.Name,
                    CustomerPhone = _order.Customer.Phone,
                    DepositAmount = _order.DepositAmount,
                    Subtotal = _order.Subtotal,
                    TotalAmount = _order.TotalAmount,
                    Items = new List<InvoiceItem>
                        {
                            new InvoiceItem { Description = _order.Garment.Name, Quantity = _order.Quantity, UnitPrice = _order.Garment.BasePrice ?? 0 },
                            new InvoiceItem { Description = _order.Fabric.MaterialType + " " + _order.Fabric.ColorName, Quantity = 1, UnitPrice = 0 }
                        }
                };

                // Create the document
                var document = new InvoiceDocument(invoiceModel, DocumentType.Receipt);

                // Configure QuestPDF to use the community license
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

                // Generate PDF
                string filePath = "invoice.pdf";
                document.GeneratePdf(filePath);

                // Open the PDF (optional)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });

                //MessageBox.Show("Invoice PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
