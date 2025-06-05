using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Database;
using app.Model;
using app.Service;
using app.Utils;

namespace app.Presentation
{
    public enum OrderStatusType
    {
        All,
        Pending,
        InProgress,
        Completed,
        PickedUp,
        Canceled
    }
    public partial class OrderUC : UserControl
    {
        public MainForm _mainForm;
        private AppDbContext _dbContext;
        private OrderService _orderService;
        private DailySequenceService _dailySequenceService;
        private User _user;
        private FilterOrder _filter = new FilterOrder(1, 10);
        private Debouncer searchDebouncer;

        public OrderUC(User user, MainForm mainForm)
        {
            InitializeComponent();
            this._dbContext = new AppDbContext();
            this._orderService = new OrderService(this._dbContext);
            this._dailySequenceService = new DailySequenceService(this._dbContext);
            this._user = user;

            searchDebouncer = new Debouncer(300, async () => await LoadOrders());
            _mainForm = mainForm;
        }

        private async void OrderUC_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            await LoadOrders();

            // Add "All" option to the status ComboBox
            // Replace the status ComboBox setup in OrderUC_Load with display name support
            var statusList = Enum.GetValues(typeof(OrderStatus))
                .Cast<OrderStatus>()
                .Select(s => new
                {
                    Value = s,
                    Display = EnumUtils.GetEnumDisplayName(s)
                })
                .ToList();

            // Optionally add an "All" option at the top
            statusList.Insert(0, new { Value = (OrderStatus)(-1), Display = "ທັງໝົດ" });

            status_cbb.DataSource = statusList;
            status_cbb.DisplayMember = "Display";
            status_cbb.ValueMember = "Value";
            status_cbb.SelectedIndex = 0;
        }

        private void InitializeDataGridView()
        {
            order_dgv.AutoGenerateColumns = false;
            order_dgv.Columns.Clear();

            order_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 20),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderNumber", headerText: "ເລກທີສັ່ງຕັດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 38),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Garment", headerText: "ປະເພດເສື້ອຜ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Customer", headerText: "ຊື່ລູກຄ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "User", headerText: "ຊື່ຜູ້ໃຊ້ລະບົບ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Status", headerText: "ສະຖານະ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 30),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CreatedAt", headerText: "ວັນທີສ້າງ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "UpdatedAt", headerText: "ວັນທີແກ້ໄຂ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50)
            );

            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "View",
                HeaderText = "",
                Text = "ຊຳລະເງິນ",
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

            order_dgv.Columns.Add(actionColumn);
            order_dgv.CellFormatting += OrderDgv_CellFormatting;
            order_dgv.CellContentClick += order_dgv_CellContentClick;
        }

        private void OrderDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "Customer")
            {
                var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
                if (order != null && order.Customer != null)
                {
                    e.Value = order.Customer.Name;
                    e.FormattingApplied = true;
                }
            }

            if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "User")
            {
                var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
                if (order != null && order.User != null)
                {
                    e.Value = order.User.Username;
                    e.FormattingApplied = true;
                }
            }

            if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "Garment")
            {
                var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
                if (order != null && order.Garment != null)
                {
                    e.Value = order.Garment.Name;
                    e.FormattingApplied = true;
                }
            }
            // Helper method to get display name from enum value


            // In OrderDgv_CellFormatting, replace the Status mapping:
            if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
                if (order != null)
                {
                    e.Value = EnumUtils.GetEnumDisplayName(order.Status);
                    e.FormattingApplied = true;
                }
            }
        }

        private async void order_dgv_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (order_dgv.Columns[e.ColumnIndex].Name == "View")
                {
                    if (order_dgv.Rows[e.RowIndex].DataBoundItem is Order selectedOrder)
                    {
                        var order = new OrderDetailUC(this, selectedOrder.OrderNumber);
                        _mainForm.LoadFormIntoPanel(order);
                        if (order.IsChanged)
                        {
                            order.IsChanged = false; // Reset the flag after handling
                            await LoadOrders();
                        }
                    }
                }
            }
        }

        public async Task LoadOrders()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var orderService = new OrderService(dbContext);
                var result = await orderService.GetAll(_filter);
                order_dgv.DataSource = null;
                order_dgv.DataSource = result.Data.ToList();
                order_dgv.ClearSelection();

                total_order_lbl.Text = result.Total.ToString();
            }
        }

        private async void new_order_btn_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(this._user, this._orderService, this._dailySequenceService);
            form.ShowDialog();
            if (form.IsUpdate)
            {
                form.IsUpdate = false; // Reset the flag after handling
                await LoadOrders();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            _filter.Search = search_txt.Text;
            searchDebouncer.Trigger();
        }

        private void status_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // status_cbb.SelectedItem is an anonymous type with Value property, not OrderStatus directly
            if (status_cbb.SelectedItem != null)
            {
                var valueProperty = status_cbb.SelectedItem.GetType().GetProperty("Value");
                if (valueProperty != null)
                {
                    var value = valueProperty.GetValue(status_cbb.SelectedItem);
                    if (value is OrderStatus status && (int)status >= 0)
                    {
                        _filter.Status = status;
                    }
                    else
                    {
                        _filter.Status = null; // "All" or invalid selection
                    }
                }
                else
                {
                    _filter.Status = null;
                }
            }
            else
            {
                _filter.Status = null;
            }

            searchDebouncer.Trigger();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            status_cbb.SelectedIndex = -1;
            search_txt.Text = string.Empty;
            _filter = new FilterOrder(1, 10);
            searchDebouncer.Trigger();
        }

    }
}
