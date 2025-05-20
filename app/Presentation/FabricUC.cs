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
    public partial class FabricUC : UserControl
    {
        private AppDbContext _dbContext;
        private FabricService _fabricService;
        private FilterFabric _filter;
        private System.Windows.Forms.Timer _debounceTimer;
        private const int DebounceInterval = 400; // milliseconds

        public FabricUC()
        {
            InitializeComponent();
            InitializeService();
            InitializeDataGridView();

            LoadFabrics();

            // Debounce timer setup
            _debounceTimer = new System.Windows.Forms.Timer();
            _debounceTimer.Interval = DebounceInterval;
            _debounceTimer.Tick += DebounceTimer_Tick;
        }

        private void InitializeService()
        {
            this._dbContext = new AppDbContext();
            this._fabricService = new FabricService(this._dbContext);
            this._filter = new FilterFabric();
        }

        private void InitializeDataGridView()
        {
            fabric_dgv.AutoGenerateColumns = false;
            fabric_dgv.Columns.Clear();

            fabric_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "MaterialType", headerText: "MaterialType", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "ColorName", headerText: "ColorName", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 60),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Color", headerText: "Color"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "ValueToColor", headerText: "ValueToColor"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "UnitPrice", headerText: "UnitPrice")
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

            fabric_dgv.Columns.Add(actionColumn);

            //fabric_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fabric_dgv.CellFormatting += this.fabric_dgv_CellFormatting;
            fabric_dgv.CellContentClick += this.fabric_dgv_CellContentClick;
        }

        public async void LoadFabrics()
        {
            var fabrics = await _fabricService.GetAll(this._filter);
            fabric_dgv.DataSource = fabrics;
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            _debounceTimer.Stop();
            LoadFabrics();
        }

        private void new_fabric_btn_Click(object sender, EventArgs e)
        {
            var frm = new FabricForm(this, this._fabricService, null);
            frm.ShowDialog();
        }

        private void fabric_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (fabric_dgv.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (fabric_dgv.Rows[e.RowIndex].DataBoundItem is Fabric selectedFabric)
                    {
                        var form = new FabricForm(this, this._fabricService, selectedFabric);
                        form.ShowDialog();
                    }
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
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }
    }
}
