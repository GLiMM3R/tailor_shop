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
    public partial class FabricUC : UserControl
    {
        private AppDbContext _dbContext;
        private FabricService _fabricService;
        private FilterFabric _filter = new FilterFabric(1, 10);
        private Debouncer searchDebouncer;

        public FabricUC()
        {
            InitializeComponent();
            InitializeService();
            InitializeDataGridView();

            searchDebouncer = new Debouncer(300, async () => await LoadFabrics());
        }

        private void InitializeService()
        {
            this._dbContext = new AppDbContext();
            this._fabricService = new FabricService(this._dbContext);
        }

        private async void FabricUC_Load(object sender, EventArgs e)
        {
            await LoadFabrics();

            using (var db = new AppDbContext())
            {
                int count = await db.Fabrics.CountAsync();
                total_fabric_lb.Text = count.ToString();
            }

            pagesize_cbb.SelectedIndex = 0; // Set default page size to first item
            _filter.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
        }

        private void InitializeDataGridView()
        {
            fabric_dgv.AutoGenerateColumns = false;
            fabric_dgv.Columns.Clear();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "ຮູບພາບ",
                DataPropertyName = "Image",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100, // Set desired width
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    NullValue = null,
                },
                HeaderCell = {
                    Style = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Font = new Font("Noto Sans Lao", 10, FontStyle.Bold)
                    }
                }
            };
            // To set row height for all rows (e.g., in InitializeDataGridView)
            fabric_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                imageColumn,
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "MaterialType", headerText: "ປະເພດວັດສະດຸ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "ColorCode", headerText: "ລະຫັດສີ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 60)
                //DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "ColorName", headerText: "ຊື່ສີ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 60),
                //DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Color", headerText: "ຄ່າສີ"),
                //DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "ValueToColor", headerText: "")
                //DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "UnitPrice", headerText: "ລາຄາ")
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

            fabric_dgv.Columns.Add(actionColumn);
            fabric_dgv.RowTemplate.Height = 100; // Set desired height

            //fabric_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fabric_dgv.CellFormatting += this.fabric_dgv_CellFormatting;
            fabric_dgv.CellFormatting += this.farbic_number_format_CellFormatting;
            fabric_dgv.CellContentClick += this.fabric_dgv_CellContentClick;
        }

        public async Task LoadFabrics()
        {
            var result = await _fabricService.GetAll(this._filter);
            fabric_dgv.DataSource = result.Data;
            _filter.TotalItems = result.Total;
            UpdatePageNumber();
        }

        private async void new_fabric_btn_Click(object sender, EventArgs e)
        {
            var frm = new FabricForm(this._fabricService, null);
            frm.ShowDialog();
            if (frm.IsUpdate)
            {
                frm.IsUpdate = false; // Reset the flag after use
                await LoadFabrics();
            }
        }

        private async void fabric_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (fabric_dgv.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (fabric_dgv.Rows[e.RowIndex].DataBoundItem is Fabric selectedFabric)
                    {
                        var form = new FabricForm(this._fabricService, selectedFabric);
                        form.ShowDialog();
                        if (form.IsUpdate)
                        {
                            form.IsUpdate = false; // Reset the flag after use
                            await LoadFabrics();
                        }
                    }
                }
            }
        }

        private void farbic_number_format_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = fabric_dgv.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "BasePrice" || columnName == "UnitPrice")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N2"); // Use "N2" for 2 decimal places  
                    e.FormattingApplied = true;
                }
            }
        }

        private void fabric_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colorColumnName = "Color"; // Column with hex codes
                int colorColumnIndex = -1;

                for (int i = 0; i < fabric_dgv.Columns.Count; i++)
                {
                    if (fabric_dgv.Columns[i].Name == colorColumnName)
                    {
                        colorColumnIndex = i;
                        break;
                    }
                }

                if (colorColumnIndex != -1)
                {
                    object hexColorValueObject = fabric_dgv.Rows[e.RowIndex].Cells[colorColumnIndex].Value;

                    if (hexColorValueObject != null)
                    {
                        string hexColorString = hexColorValueObject.ToString();
                        Color backgroundColor = Color.White; // Default

                        try
                        {
                            // Ensure the hex string starts with '#' for ColorTranslator
                            if (!hexColorString.StartsWith("#"))
                            {
                                hexColorString = "#" + hexColorString;
                            }
                            backgroundColor = System.Drawing.ColorTranslator.FromHtml(hexColorString);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Warning: Could not parse hex color '{hexColorString}'. Error: {ex.Message}");
                            backgroundColor = Color.LightGray; // Fallback color
                        }

                        // Apply to a target column, e.g., "ValueColumn"
                        string targetColumnToColorName = "ValueToColor";
                        if (fabric_dgv.Columns[e.ColumnIndex].Name == targetColumnToColorName)
                        {
                            e.CellStyle.BackColor = backgroundColor;
                            e.CellStyle.ForeColor = (backgroundColor.GetBrightness() < 0.5) ? Color.White : Color.Black;
                        }
                    }
                }
            }
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
                await LoadFabrics();
            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.TotalPages > 0)
            {
                _filter.Page = _filter.TotalPages;
                await LoadFabrics();
            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filter.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadFabrics();
        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.HasPreviousPage)
            {
                _filter.Page--;
                await LoadFabrics();
            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_filter.Page > 1)
            {
                _filter.Page = 1;
                await LoadFabrics();
            }
        }
    }
}
