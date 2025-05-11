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
using app.Service;

namespace app.Presentation
{
    public partial class CustomerUC : UserControl
    {
        private AppDbContext _context;
        private CustomerService _customerService;
        private List<CustomerUC> _customerList;

        public CustomerUC()
        {
            InitializeComponent();
            InitializeService();
        }

        private void InitializeService()
        {
            this._context = new AppDbContext();
            this._customerService = new CustomerService(_context);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private async void LoadCustomers()
        {
            FilterCustomer filter = new FilterCustomer();
            var customers = await _customerService.GetAll(filter);

            customer_dgv.AutoGenerateColumns = false;
            customer_dgv.Columns.Clear();


            customer_dgv.Columns.AddRange(
                CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                CreateTextBoxColumn(dataPropertyName: "Name", headerText: "Name", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                CreateTextBoxColumn(dataPropertyName: "Gender", headerText: "Gender"),
                CreateTextBoxColumn(dataPropertyName: "Phone", headerText: "Phone"),
                CreateTextBoxColumn(dataPropertyName: "Address", headerText: "Address"),
                CreateTextBoxColumn(dataPropertyName: "Status", headerText: "Status")
                );

            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Action",
                HeaderText = "Action",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };
            customer_dgv.Columns.Add(actionColumn);

            customer_dgv.DataSource = customers;
        }

        private DataGridViewTextBoxColumn CreateTextBoxColumn(
        string dataPropertyName,
        string headerText = null,
        string name = null,
        DataGridViewAutoSizeColumnMode autoSizeMode = DataGridViewAutoSizeColumnMode.NotSet,
        float fillWeight = 100,
        bool readOnly = true)
        {
            string actualHeaderText = headerText ?? dataPropertyName;
            string actualName = name ?? dataPropertyName;

            var column = new DataGridViewTextBoxColumn
            {
                Name = actualName,
                HeaderText = actualHeaderText,
                DataPropertyName = dataPropertyName,
                AutoSizeMode = autoSizeMode,
                ReadOnly = readOnly,
            };

            if (autoSizeMode == DataGridViewAutoSizeColumnMode.Fill)
            {
                column.FillWeight = fillWeight;
            }

            return column;
        }

        private void new_customer_btn_Click(object sender, EventArgs e)
        {
            var customer_form = new CustomerForm();
            customer_form.ShowDialog();
        }
    }
}
