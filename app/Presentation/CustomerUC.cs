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
    public partial class CustomerUC : UserControl
    {
        private AppDbContext _context;
        private CustomerService _customerService;

        private FilterCustomer _filter;
        private int _count = 0;

        public CustomerUC()
        {
            InitializeComponent();
            InitializeService();
            InitializeDataGridView();

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

        private void InitializeDataGridView()
        {
            customer_dgv.AutoGenerateColumns = false;
            customer_dgv.Columns.Clear();

            customer_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Name", headerText: "Name", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Gender", headerText: "Gender", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 60),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Phone", headerText: "Phone", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 60),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Address", headerText: "Address", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 80)
                );

            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "Edit",
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

            customer_dgv.Columns.Add(actionColumn);
        }

        public async void LoadCustomers()
        {
            var customers = await _customerService.GetAll(this._filter);
            customer_dgv.DataSource = customers;
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

        private void customer_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (customer_dgv.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (customer_dgv.Rows[e.RowIndex].DataBoundItem is Customer selectedCustomer)
                    {
                        var form = new CustomerForm(this, this._customerService, selectedCustomer);
                        form.ShowDialog();
                    }
                }
            }
        }
    }
}
