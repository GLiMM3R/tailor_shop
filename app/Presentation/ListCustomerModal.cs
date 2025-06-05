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
    public partial class ListCustomerModal : Form
    {
        private AppDbContext _context;
        private CustomerService _customerService;
        private FilterCustomer _filter = new FilterCustomer(1, 10);
        private Debouncer searchDebouncer;

        public Customer? selectedCustomer = null;

        public ListCustomerModal()
        {
            InitializeComponent();
            this._context = new AppDbContext();
            this._customerService = new CustomerService(this._context);
            searchDebouncer = new Debouncer(300, async () => await LoadCustomers());

        }

        private async void ListCustomerModal_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            await LoadCustomers();

            gender_cb.Items.Clear();
            gender_cb.Items.AddRange(new object[] { "ທັງໝົດ", "ຊາຍ", "ຍິງ" });
            gender_cb.SelectedIndex = 0; // Set default selection to "ທັງໝົດ"

            pagesize_cbb.SelectedIndex = 0; // Set default page size to first item
            _filter.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
        }

        private void InitializeDataGridView()
        {
            customer_dgv.AutoGenerateColumns = false;
            customer_dgv.Columns.Clear();

            customer_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Name", headerText: "ຊື່", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Gender", headerText: "ເພດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 60),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Phone", headerText: "ເບີໂທ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 60),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Address", headerText: "ທີ່ຢູ່", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 80)
                );

            customer_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Gets the currently selected Customer from the DataGridView.
        /// Returns null if no row is selected.
        /// </summary>
        /// <returns>The selected Customer or null.</returns>
        private Customer? GetSelectedCustomer()
        {
            if (customer_dgv.SelectedRows.Count > 0)
            {
                var row = customer_dgv.SelectedRows[0];
                return row.DataBoundItem as Customer;
            }
            return null;
        }

        public async Task LoadCustomers()
        {
            var result = await _customerService.GetAll(this._filter);
            customer_dgv.DataSource = result.Data;
            _filter.TotalItems = result.Total;
            UpdatePageNumber();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            _filter.Name = search_txt.Text.Trim();
            searchDebouncer.Trigger();
        }

        private async void gender_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gender_cb.SelectedIndex == 0)
            {
                _filter.Gender = null;
                await LoadCustomers();
            }
            else if (gender_cb.SelectedIndex == 1)
            {
                _filter.Gender = Gender.Male;
                await LoadCustomers();
            }
            else if (gender_cb.SelectedIndex == 2)
            {
                _filter.Gender = Gender.Female;
                await LoadCustomers();
            }
        }

        private void UpdatePageNumber()
        {
            if (_filter.TotalItems > 0)
            {
                page_lbl.Text = $"{_filter.Page}/{_filter.TotalPages}";
            }
            else
            {
                page_lbl.Text = "0/0";
            }
        }

        private async void next_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.HasNextPage)
            {
                _filter.Page++;
                await LoadCustomers();
            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.TotalPages > 0)
            {
                _filter.Page = _filter.TotalPages;
                await LoadCustomers();
            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filter.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadCustomers();
        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.HasPreviousPage)
            {
                _filter.Page--;
                await LoadCustomers();
            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.Page > 1)
            {
                _filter.Page = 1;
                await LoadCustomers();
            }
        }

        private void select_customer_btn_Click(object sender, EventArgs e)
        {
            var _selectedCustomer = GetSelectedCustomer();

            if (_selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedCustomer = _selectedCustomer;
            this.Close();
        }

        private async void add_new_customer_btn_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(_customerService, null);
            form.ShowDialog();
            if(form.IsUpdate)
            {
                form.IsUpdate = false; // Reset the flag after use
                await LoadCustomers();
            }
        }
    }
}
