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
using Microsoft.EntityFrameworkCore;

namespace app.Presentation
{
    public partial class CustomerUC : UserControl
    {
        private AppDbContext _context;
        private CustomerService _customerService;

        private FilterCustomer _filter = new FilterCustomer(1, 10);
        private int _count = 0;

        private Debouncer searchDebouncer;
        public CustomerUC()
        {
            InitializeComponent();
            InitializeService();
            InitializeDataGridView();

            total_customer_lb.Text = this._count.ToString();

            searchDebouncer = new Debouncer(300, async () => await LoadCustomers());
        }

        private void InitializeService()
        {
            this._context = new AppDbContext();
            this._customerService = new CustomerService(this._context);
        }

        private async void Customer_Load(object sender, EventArgs e)
        {
            await LoadCustomers();

            using (var db = new AppDbContext())
            {
                _count = await db.Customers.CountAsync();
            }

            // Populate gender_cb with gender options  
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

            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
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

            customer_dgv.Columns.Add(actionColumn);
            customer_dgv.CellFormatting += customer_dvg_CellFormatting;
        }

        private void customer_dvg_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (customer_dgv.Columns[e.ColumnIndex].DataPropertyName == "Gender")
            {
                var customer = customer_dgv.Rows[e.RowIndex].DataBoundItem as Customer;
                if (customer != null)
                {
                    e.Value = GetEnumDisplayName(customer.Gender);
                    e.FormattingApplied = true;
                }
            }
        }

        public async Task LoadCustomers()
        {
            using (var context = new AppDbContext())
            {
                var service = new CustomerService(context);
                var result = await service.GetAll(this._filter);
                customer_dgv.DataSource = result.Data;
                _filter.TotalItems = result.Total;
                UpdatePageNumber();
            }
        }

        private async void new_customer_btn_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(_customerService, null);
            form.ShowDialog();
            if (form.IsUpdate)
            {
                form.IsUpdate = false;
                await LoadCustomers();
            }
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            _filter.Name = search_txt.Text.Trim();
            searchDebouncer.Trigger();
        }

        private async void customer_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (customer_dgv.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (customer_dgv.Rows[e.RowIndex].DataBoundItem is Customer selectedCustomer)
                    {
                        var form = new CustomerForm(this._customerService, selectedCustomer);
                        form.ShowDialog();
                        if (form.IsUpdate)
                        {
                            form.IsUpdate = false;
                            await LoadCustomers();
                        }
                    }
                }
            }
        }

        private string GetEnumDisplayName(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var displayAttribute = field?.GetCustomAttribute<DisplayAttribute>();
            return displayAttribute?.Name ?? value.ToString();
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
    }
}
