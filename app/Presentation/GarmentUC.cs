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
using Microsoft.EntityFrameworkCore;

namespace app.Presentation
{
    public partial class GarmentUC : UserControl
    {
        private AppDbContext _dbContext;
        private GarmentService _garmentService;
        private FilterGarment _filter = new FilterGarment(1, 10);
        private Debouncer searchDebouncer;

        public GarmentUC()
        {
            InitializeComponent();
            InitializeDataGridView();

            this._dbContext = new AppDbContext();
            this._garmentService = new GarmentService(this._dbContext);

            searchDebouncer = new Debouncer(300, async () => await LoadGarments());
        }

        private async void GarmentUC_Load(object sender, EventArgs e)
        {
            await LoadGarments();

            using (var db = new AppDbContext())
            {
                int count = await db.Garments.CountAsync();
                total_garment_lb.Text = count.ToString();
            }

            pagesize_cbb.SelectedIndex = 0; // Set default page size to first item
            _filter.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
        }

        private void new_garment_btn_Click(object sender, EventArgs e)
        {
            var form = new GarmentForm(this, this._garmentService, null);
            form.ShowDialog();
        }


        private void InitializeDataGridView()
        {
            garment_dvg.AutoGenerateColumns = false;
            garment_dvg.Columns.Clear();

            garment_dvg.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Name", headerText: "ຊື່", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 80),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "BasePrice", headerText: "ລາຄາ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 40),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Description", headerText: "ລາຍລະອຽດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill)
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

            garment_dvg.Columns.Add(actionColumn);

            //fabric_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            garment_dvg.CellFormatting += this.garment_number_format_CellFormatting;
            garment_dvg.CellContentClick += this.garment_dgv_CellContentClick;
        }

        private void garment_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (garment_dvg.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (garment_dvg.Rows[e.RowIndex].DataBoundItem is Garment selectedGarment)
                    {
                        var form = new GarmentForm(this, this._garmentService, selectedGarment);
                        form.ShowDialog();
                    }
                }
            }
        }

        private void garment_number_format_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = garment_dvg.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "BasePrice" || columnName == "UnitPrice")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N2"); // Use "N2" for 2 decimal places  
                    e.FormattingApplied = true;
                }
            }
        }

        public async Task LoadGarments()
        {
            var result = await _garmentService.GetAll(_filter);
            garment_dvg.DataSource = result.Data;
            _filter.TotalItems = result.Total;
            UpdatePageNumber();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            _filter.Search = search_txt.Text;
            searchDebouncer.Trigger();
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
                await LoadGarments();
            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.TotalPages > 0)
            {
                _filter.Page = _filter.TotalPages;
                await LoadGarments();
            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filter.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadGarments();
        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.HasPreviousPage)
            {
                _filter.Page--;
                await LoadGarments();
            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.Page > 1)
            {
                _filter.Page = 1;
                await LoadGarments();
            }
        }
    }
}
