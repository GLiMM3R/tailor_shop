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
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;

namespace app.Presentation
{
    public partial class OrderDetailUC : UserControl
    {
        private OrderUC _orderUC;
        private AppDbContext _context;
        public OrderService _orderService;
        public Order _order;
        private string _orderNumber;
        public List<OrderItem> _orderItems;

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
            order_items_dgv.AutoGenerateColumns = false;
            order_items_dgv.Columns.Clear();
            order_items_dgv.DefaultCellStyle.SelectionBackColor = order_items_dgv.DefaultCellStyle.BackColor;
            order_items_dgv.DefaultCellStyle.SelectionForeColor = order_items_dgv.DefaultCellStyle.ForeColor;



            order_items_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ລະຫັດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 30),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Garment", headerText: "ປະເພດເສື້ອຜ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Fabric", headerText: "ປະເພດຜ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Quantity", headerText: "ຈຳນວນ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "UnitPrice", headerText: "ລາຄາຕໍ່ໜ່ວຍ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, fillWeight: 80),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Total", headerText: "ລວມ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, fillWeight: 100)
            );

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
            {
                Name = "View",
                HeaderText = "",
                Text = "ລາຍການວັດແທກ",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(8, 4, 8, 4),
                    BackColor = Color.FromArgb(78, 184, 206),
                    ForeColor = Color.White,
                    Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    SelectionBackColor = Color.FromArgb(60, 140, 160),
                    SelectionForeColor = Color.White
                },
            };
            //DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            //{
            //    Name = "Delete",
            //    HeaderText = "",
            //    Text = "ລຶບ",
            //    UseColumnTextForButtonValue = true,
            //    FlatStyle = FlatStyle.Flat,
            //    DefaultCellStyle = new DataGridViewCellStyle
            //    {
            //        Padding = new Padding(2),
            //        BackColor = Color.Red, // Button background color set to red
            //        ForeColor = Color.White,
            //        Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold),
            //        Alignment = DataGridViewContentAlignment.MiddleCenter,
            //        SelectionBackColor = Color.Red, // Selection background color also set to red
            //        SelectionForeColor = Color.White
            //    }
            //};

            order_items_dgv.Columns.Add(editColumn);

            order_items_dgv.CellFormatting += OrderItemDgv_CellFormatting;
            order_items_dgv.CellContentClick += OrderItemDvg_CellContentClick;
        }

        private void OrderItemDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (order_items_dgv.Columns[e.ColumnIndex].DataPropertyName == "Index")
            {
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            }

            if (order_items_dgv.Columns[e.ColumnIndex].DataPropertyName == "Garment")
            {
                if (order_items_dgv.Rows[e.RowIndex].DataBoundItem is OrderItem item && item.Garment != null)
                {
                    e.Value = item.Garment.Name;
                    e.FormattingApplied = true;
                }
            }

            if (order_items_dgv.Columns[e.ColumnIndex].DataPropertyName == "Fabric")
            {
                if (order_items_dgv.Rows[e.RowIndex].DataBoundItem is OrderItem item && item.Fabric != null)
                {
                    e.Value = item.Fabric.MaterialType;
                    e.FormattingApplied = true;
                }
            }

            if (order_items_dgv.Columns[e.ColumnIndex].DataPropertyName == "UnitPrice" || order_items_dgv.Columns[e.ColumnIndex].DataPropertyName == "Total")
            {
                if (order_items_dgv.Rows[e.RowIndex].DataBoundItem is OrderItem item && item.Garment != null)
                {
                    e.Value = (item.Garment.BasePrice * item.Quantity)?.ToString("N0") ?? "0";
                    e.FormattingApplied = true;
                }
            }
        }

        private async void OrderItemDvg_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (order_items_dgv.Columns[e.ColumnIndex].Name == "View")
                {
                    if (order_items_dgv.Rows[e.RowIndex].DataBoundItem is OrderItem selectedItem)
                    {
                        var frm = new MeasurementsForm(selectedItem.Id);
                        frm.ShowDialog();
                    }
                }

                //if (order_items_dgv.Columns[e.ColumnIndex].Name == "Delete")
                //{
                //    if (order_items_dgv.Rows[e.RowIndex].DataBoundItem is OrderItem selectedItem)
                //    {
                //        using (var context = new AppDbContext())
                //        {
                //            var orderService = new OrderService(context);
                //            await orderService.DeleteOrderItem(selectedItem); // Corrected: DeleteOrderItem returns void

                //            await LoadOrderItems();
                //        }
                //    }
                //}
            }
        }

        public async Task LoadOrder()
        {
            var order = await _orderService.GetByOrderNumber(_orderNumber);

            if (order != null)
            {
                _order = order;
                var paid_amount = order.Payments.Sum(p => p.PaidAmount);

                order_number_lbl.Text = _order.OrderNumber;
                customer_name_lbl.Text = _order.Customer.Name;
                customer_phone_lbl.Text = _order.Customer.Phone;
                //garment_lbl.Text = _order.Garment.Name;
                //fabric_lbl.Text = $"#{_order.Fabric.ColorCode} {_order.Fabric.MaterialType}";
                //quantity_lbl.Text = _order.Quantity.ToString();
                order_date_lbl.Text = _order.CreatedAt.ToString("dd/MM/yyyy");
                due_date_lbl.Text = _order.DueDate?.ToString("dd/MM/yyyy") ?? "-";
                pick_up_date_lbl.Text = _order.PickUpDate?.ToString("dd/MM/yyyy") ?? "-";
                subtotal_val_lb.Text = _order.Subtotal.ToString("N0");
                amount_to_be_paid_lbl.Text = (_order.TotalAmount - paid_amount).ToString("N0");
                deposit_amount_val_lb.Text = _order.DepositAmount.ToString("N0");
                total_amount_lb.Text = _order.TotalAmount.ToString("N0");
                notes_txt.Text = _order.Notes;

                //if (_order.Status == OrderStatus.Completed)
                //{
                //    pay_btn.Enabled = false;
                //    pay_btn.BackColor = Color.FromArgb(200, 200, 200);
                //    pay_btn.Text = "ຈ່າຍແລ້ວ";
                //}
                //else if (_order.Status == OrderStatus.Pending)
                //{
                //    pay_btn.Enabled = true;
                //    pay_btn.BackColor = Color.FromArgb(33, 52, 72);
                //    pay_btn.Text = "ຊຳລະເງິນ";
                //}

                if (_order.TotalAmount - paid_amount > 0)
                {
                    pay_btn.Enabled = true;
                    pay_btn.BackColor = Color.FromArgb(33, 52, 72);
                    pay_btn.Text = "ຊຳລະເງິນ";
                }
                else
                {
                    pay_btn.Enabled = false;
                    pay_btn.BackColor = Color.FromArgb(200, 200, 200);
                    pay_btn.Text = "ຈ່າຍແລ້ວ";
                    print_invoice_btn.Enabled = false;
                    print_invoice_btn.BackColor = Color.FromArgb(200, 200, 200);

                }

                await LoadOrderItems();
            }
        }


        private async Task LoadOrderItems()
        {
            using var context = new AppDbContext();
            var orderService = new OrderService(context);
            _orderItems = await orderService.GetOrderItems(_orderNumber);

            if (_orderItems != null)
            {
                order_items_dgv.DataSource = _orderItems;
            }
        }

        private async void OrderDetailUC_Load(object sender, EventArgs e)
        {
            var statusList = Enum.GetValues(typeof(OrderStatus))
             .Cast<OrderStatus>()
             .Select(s => new
             {
                 Value = s,
                 Display = EnumUtils.GetEnumDisplayName(s)
             })
             .ToList();

            status_cbb.DataSource = statusList;
            status_cbb.DisplayMember = "Display";
            status_cbb.ValueMember = "Value";
            status_cbb.SelectedIndex = 0;

            // Load the order details
            await LoadOrder();

            if (_order != null)
            {
                status_cbb.SelectedValue = _order.Status;
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
                // Safely handle the unboxing of the selected value
                if (status_cbb.SelectedValue is OrderStatus selectedStatus)
                {
                    if (selectedStatus == OrderStatus.PickedUp && _order.TotalAmount > _order.TotalPaid())
                    {
                        MessageBox.Show("ຕ້ອງຊຳລະເງິນກ່ອນ ຮັບເຄື່ອງ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        status_cbb.SelectedValue = _order.Status;
                        return;
                    }

                    _order.Status = selectedStatus;
                    if (selectedStatus == OrderStatus.PickedUp)
                    {
                        _order.PickUpDate = DateTime.Now;
                    }
                    _order.UpdatedAt = DateTime.Now;
                    await _orderService.Update(_order);

                    MessageBox.Show("Update successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadOrder();
                    await _orderUC.LoadOrders();
                }
                else
                {
                    MessageBox.Show("Invalid status selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Items = new List<InvoiceItem>()
                };

                foreach(var item in _orderItems)
                {
                    var _item = new InvoiceItem
                    {
                        Description = $"{item.Garment.Name} {item.Fabric.MaterialType} {item.Fabric.ColorCode}",
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                    };

                    invoiceModel.Items.Add(_item);
                }

                // Create the document
                var document = new InvoiceDocument(invoiceModel, DocumentType.Invoice);

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

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }
    }
}
