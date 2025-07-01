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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace app.Presentation
{
    public partial class OrderFormUC : UserControl
    {
        public List<OrderItem> items = new List<OrderItem>();
        private OrderUC _orderUC;
        private User _user;
        private Customer? _selectedCustomer = null;

        public OrderFormUC(OrderUC orderUC, User user)
        {
            _orderUC = orderUC;
            _user = user;
            InitializeComponent();
            InitializeDataGridView();
        }

        private async Task LoadOrderNumber()
        {
            using var context = new AppDbContext();
            var _dailySequenceService = new DailySequenceService(context);
            var orderNumber = await _dailySequenceService.GetNextSequence(DateTime.Now);
            order_number_lb.Text = orderNumber.ToString();
        }

        private async void OrderFormUC_Load(object sender, EventArgs e)
        {
            await LoadOrderNumber();
        }

        private void InitializeDataGridView()
        {
            order_items_dgv.AutoGenerateColumns = false;
            order_items_dgv.Columns.Clear();

            order_items_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Index", headerText: "ລຳດັບ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 30),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Garment", headerText: "ປະເພດເສື້ອຜ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Fabric", headerText: "ປະເພດຜ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Quantity", headerText: "ຈຳນວນ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "UnitPrice", headerText: "ລາຄາຕໍ່ໜ່ວຍ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, fillWeight: 80),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Total", headerText: "ລວມ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, fillWeight: 100)
            );

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "ແກ້ໄຂ",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(2),
                    BackColor = Color.FromArgb(78, 184, 206),
                    ForeColor = Color.White,
                    Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    SelectionBackColor = Color.FromArgb(60, 140, 160),
                    SelectionForeColor = Color.White
                }
            };
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "ລຶບ",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(2),
                    BackColor = Color.Red, // Button background color set to red
                    ForeColor = Color.White,
                    Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    SelectionBackColor = Color.Red, // Selection background color also set to red
                    SelectionForeColor = Color.White
                }
            };

            order_items_dgv.Columns.Add(editColumn);
            order_items_dgv.Columns.Add(deleteColumn);
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
                if (order_items_dgv.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (order_items_dgv.Rows[e.RowIndex].DataBoundItem is OrderItem selectedItem)
                    {
                        var frm = new OrderItemForm(this, selectedItem);
                        frm.ShowDialog();
                    }
                }

                if (order_items_dgv.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (order_items_dgv.Rows[e.RowIndex].DataBoundItem is OrderItem selectedItem)
                    {
                        items.Remove(selectedItem);
                        LoadOrderItemsToList();
                    }
                }
            }
        }

        public void LoadOrderItemsToList()
        {
            order_items_dgv.DataSource = null;
            order_items_dgv.DataSource = items;

            var subtotal = items.Sum(x => (x.Garment.BasePrice * x.Quantity)) ?? 0;

            subtotal_lb.Text = subtotal.ToString("N0");
            total_amount_lb.Text = subtotal.ToString("N0");
            deposit_amount_num.Value = subtotal / 2;
        }

        private async void create_order_btn_Click(object sender, EventArgs e)
        {
            // Validate order items
            if (items.Count == 0)
            {
                MessageBox.Show("Items is empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate customer selection
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Please select customer!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate subtotal
            if (!decimal.TryParse(subtotal_lb.Text, out decimal subtotal))
            {
                MessageBox.Show("Invalid subtotal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate deposit amount
            if (!decimal.TryParse(deposit_amount_num.Text, out decimal depositAmount))
            {
                MessageBox.Show("Invalid deposit amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (depositAmount <= 0)
            {
                MessageBox.Show("Deposit amount cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (depositAmount < subtotal / 2)
            {
                MessageBox.Show("Deposit amount must be at least half of the subtotal after discount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (depositAmount > subtotal)
            {
                MessageBox.Show("Deposit amount cannot exceed the total amount after discount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new order
            var newOrder = new Order
            {
                OrderNumber = order_number_lb.Text,
                UserId = _user.Id,
                CustomerId = _selectedCustomer.Id,
                DueDate = due_date_dpk.Value,
                DepositAmount = depositAmount,
                Subtotal = subtotal,
                TotalAmount = subtotal,
                Notes = notes_txt.Text,
                Status = OrderStatus.InProgress,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Payments = new List<Payment>
                {
                    new Payment
                    {
                        TotalPrice = subtotal,
                        PaidAmount = depositAmount,
                        TransactionType = TransactionType.Deposit,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                },
                OrderItems = new List<OrderItem>()
            };

            foreach (var item in items)
            {
                var newItem = new OrderItem
                {
                    GarmentId = item.GarmentId,
                    FabricId = item.FabricId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Notes = item.Notes,
                    Measurements = item.Measurements
                };
                newOrder.OrderItems.Add(newItem);
            }

            try
            {
                using var context = new AppDbContext();
                var orderService = new OrderService(context);
                await orderService.Create(newOrder);

                MessageBox.Show("Order created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var frm = new OrderDetailUC(_orderUC, order_number_lb.Text);
                _orderUC._mainForm.LoadFormIntoPanel(frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void open_order_item_form_btn_Click(object sender, EventArgs e)
        {
            var frm = new OrderItemForm(this, null);
            frm.ShowDialog();
        }
    }
}

