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
    public partial class OrderUC : UserControl
    {
        public MainForm _mainForm;
        private AppDbContext _dbContext;
        private OrderService _orderService;
        private FabricService _fabricService;
        private CustomerService _customerService;
        private GarmentService _garmentService;
        private DailySequenceService _dailySequenceService;
        private User _user;
        private FilterOrder _filter = new FilterOrder();
        private Debouncer searchDebouncer;

        public OrderUC(User user, MainForm mainForm )
        {
            InitializeComponent();
            this._dbContext = new AppDbContext();
            this._orderService = new OrderService(this._dbContext);
            this._fabricService = new FabricService(this._dbContext);
            this._customerService = new CustomerService(this._dbContext);
            this._garmentService = new GarmentService(this._dbContext);
            this._dailySequenceService = new DailySequenceService(this._dbContext);
            this._user = user;

            searchDebouncer = new Debouncer(300, async () => await LoadOrders());
            _mainForm = mainForm;
        }

        private async void OrderUC_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            await LoadOrders();
        }

        private void InitializeDataGridView()
        {
            order_dgv.AutoGenerateColumns = false;
            order_dgv.Columns.Clear();

            order_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 20),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderNumber", headerText: "OrderNumber", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 38),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Garment", headerText: "Garment", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Customer", headerText: "Customer", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "User", headerText: "User", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "SubTotal", headerText: "SubTotal", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 40),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Discount", headerText: "Discount", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 40),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalAmount", headerText: "TotalAmount", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 40),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "DepositAmount", headerText: "DepositAmount", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Status", headerText: "Status", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 30),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CreatedAt", headerText: "CreatedAt", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50)
            );

            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "View",
                HeaderText = "",
                Text = "View",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(2),
                    BackColor = Color.FromArgb(78, 184, 206),
                    ForeColor = Color.White,
                    Font = new Font("Arial", 9F, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    SelectionBackColor = Color.FromArgb(60, 140, 160),
                    SelectionForeColor = Color.White
                }
            };

            order_dgv.Columns.Add(actionColumn);
            order_dgv.CellFormatting += OrderDgv_CellFormatting;
            order_dgv.CellContentClick += order_dgv_CellContentClick;
        }

        private void OrderDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

            //if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "Status")
            //{
            //    var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
            //    if (order != null && order.Status != null)
            //    {
            //        e.Value = order.Status;
            //        e.FormattingApplied = true;
            //    }
            //}
        }

        private async void order_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (order_dgv.Columns[e.ColumnIndex].Name == "View")
                {
                    if (order_dgv.Rows[e.RowIndex].DataBoundItem is Order selectedOrder)
                    {
                        var form = new OrderDetail(selectedOrder.OrderNumber);
                        //form.ShowDialog();
                        if (form.IsChanged)
                        {
                            await LoadOrders();
                        }
                        var order = new OrderDetailUC(this, selectedOrder.OrderNumber);
                        _mainForm.LoadFormIntoPanel(order);
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
                var orders = await orderService.GetAll(_filter);
                order_dgv.DataSource = null;
                order_dgv.DataSource = orders.ToList();
                order_dgv.ClearSelection();
            }
        }

        private async void new_order_btn_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(this, this._user, this._orderService, this._dailySequenceService);
            form.ShowDialog();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            _filter.Search = search_txt.Text;
            searchDebouncer.Trigger();
        }
    }
}
