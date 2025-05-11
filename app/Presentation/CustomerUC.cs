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
    public partial class CustomerUC : UserControl
    {
        private AppDbContext _context;
        private CustomerService _customerService;

        private FilterCustomer _filter;
        private int _count = 0 ;

        public CustomerUC()
        {
            InitializeComponent();
            InitializeService();

            _filter = new FilterCustomer();
            total_customer_lb.Text = this._count.ToString();
        }

        private void InitializeService()
        {
            this._context = new AppDbContext();
            this._customerService = new CustomerService(_context);
            this._count = _customerService.Count();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        public async void LoadCustomers()
        {
            var customers = await _customerService.GetAll(this._filter);

            customer_dgv.AutoGenerateColumns = false;
            customer_dgv.Columns.Clear();


            customer_dgv.Columns.AddRange(
                CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                CreateTextBoxColumn(dataPropertyName: "Name", headerText: "Name", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                CreateTextBoxColumn(dataPropertyName: "Gender", headerText: "Gender"),
                CreateTextBoxColumn(dataPropertyName: "Phone", headerText: "Phone"),
                CreateTextBoxColumn(dataPropertyName: "Address", headerText: "Address")
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
            var customer_form = new CustomerForm(this, _customerService, null);
            customer_form.ShowDialog();
        }

        private void gender_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gender_cb.SelectedIndex == 0)
            {
                _filter.Gender = null;
                LoadCustomers();
            }
            else if (gender_cb.SelectedIndex == 1)
            {
                _filter.Gender = Gender.Male;
                LoadCustomers();
            }
            else if (gender_cb.SelectedIndex == 2)
            {
                _filter.Gender = Gender.Female;
                LoadCustomers();
            }
            else if (gender_cb.SelectedIndex == 3)
            {
                _filter.Gender = Gender.Other;
                LoadCustomers();
            }
            else if (gender_cb.SelectedIndex == 4)
            {
                _filter.Gender = Gender.PreferNotToSay;
                LoadCustomers();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            _filter.Name = search_txt.Text.Trim();
            LoadCustomers();
        }
    }
}
