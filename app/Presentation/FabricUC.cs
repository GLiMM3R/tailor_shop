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
using app.Utils;

namespace app.Presentation
{
    public partial class FabricUC : UserControl
    {
        private AppDbContext _dbContext;
        private FabricService _fabricService;
        private FilterFabric _filter;

        public FabricUC()
        {
            InitializeComponent();
            InitializeService();

            LoadFabrics();
        }

        private void InitializeService()
        {
            this._dbContext = new AppDbContext();
            this._fabricService = new FabricService(this._dbContext);
            this._filter = new FilterFabric();
        }

        public async void LoadFabrics()
        {
            var fabrics = await _fabricService.GetAll(this._filter);

            fabric_dgv.AutoGenerateColumns = false;
            fabric_dgv.Columns.Clear();

            fabric_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Type", headerText: "Type", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Color", headerText: "Color")
                );

            DataGridViewTextBoxColumn colorDisplay = new DataGridViewTextBoxColumn
            {
                Name = "ValueToColor",
                HeaderText = "ValueToColor"
            };

            fabric_dgv.Columns.Add(colorDisplay);

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

            // Subscribe to the CellFormatting event
            //this.fabric_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.fabric_dgv_CellFormatting);
            fabric_dgv.DataSource = fabrics;
        }

        private void new_fabric_btn_Click(object sender, EventArgs e)
        {
            var frm = new FabricForm(this, this._fabricService, null);
            frm.ShowDialog();
        }

        private void fabric_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Ensure we are not on a header row or a new row
            if (e.RowIndex < 0 || e.RowIndex == this.fabric_dgv.NewRowIndex)
                return;

            // Scenario 1: Color a specific cell ('ValueToColor' column) based on 'ColorName' column
            // Let's say "ValueToColor" is at columnIndex 4
            int valueToColorColumnIndex = fabric_dgv.Columns["ValueToColor"]?.Index ?? -1; // Get column index by name
            int colorNameColumnIndex = fabric_dgv.Columns["Color"]?.Index ?? -1;

            if (valueToColorColumnIndex != -1 && e.ColumnIndex == valueToColorColumnIndex && colorNameColumnIndex != -1)
            {
                // Get the color name or HEX string from the 'ColorName' column for the current row
                string colorStr = fabric_dgv.Rows[e.RowIndex].Cells[colorNameColumnIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(colorStr))
                {
                    try
                    {
                        Color cellColor;
                        if (colorStr.StartsWith("#"))
                        {
                            cellColor = ColorTranslator.FromHtml(colorStr); // For HEX codes
                        }
                        else
                        {
                            cellColor = Color.FromName(colorStr); // For named colors
                        }

                        // If the color is known (not Transparent, which is default for invalid names)
                        if (cellColor != Color.Transparent || colorStr.Equals("Transparent", StringComparison.OrdinalIgnoreCase))
                        {
                            // Check if the color is actually known, Color.FromName returns 0 for unknown names
                            if (cellColor.A == 0 && cellColor.R == 0 && cellColor.G == 0 && cellColor.B == 0 && !colorStr.Equals("Black", StringComparison.OrdinalIgnoreCase) && !colorStr.Equals("Transparent", StringComparison.OrdinalIgnoreCase))
                            {
                                // It's an unknown color name if it resolved to ARGB(0,0,0,0) unless it was "Black" or "Transparent"
                                // (Color.FromName for "Black" returns a non-zero A value, so this check is slightly complex for fully robust unknown name detection)
                                // For simplicity, we'll assume valid names or hex for now.
                                // A more robust way for FromName is to check cellColor.IsKnownColor
                            }
                            else
                            {
                                e.CellStyle.BackColor = cellColor;
                                e.CellStyle.SelectionBackColor = cellColor; // Optional: keep color on selection
                                e.FormattingApplied = true; // Important!
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle invalid color string format if necessary
                        Console.WriteLine($"Error parsing color string '{colorStr}': {ex.Message}");
                    }
                }
            }

            // Scenario 2: Color the 'Status' cell based on its own content
            // Let's say "Status" is at columnIndex 2
            //int statusColumnIndex = fabric_dgv.Columns["Status"]?.Index ?? -1; // Get column index by name

            //if (statusColumnIndex != -1 && e.ColumnIndex == statusColumnIndex)
            //{
            //    string statusValue = e.Value?.ToString(); // e.Value is the formatted value of the current cell

            //    if (!string.IsNullOrEmpty(statusValue))
            //    {
            //        switch (statusValue.ToLower())
            //        {
            //            case "ok":
            //                e.CellStyle.BackColor = Color.LightGreen;
            //                e.CellStyle.ForeColor = Color.DarkGreen; // Optional: Change text color too
            //                break;
            //            case "warning":
            //                e.CellStyle.BackColor = Color.LightYellow;
            //                e.CellStyle.ForeColor = Color.DarkGoldenrod;
            //                break;
            //            case "error":
            //            case "critical":
            //                e.CellStyle.BackColor = Color.LightCoral;
            //                e.CellStyle.ForeColor = Color.DarkRed;
            //                break;
            //            default:
            //                // Use default cell style (or set a specific default)
            //                // e.CellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
            //                // e.CellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            //                break;
            //        }
            //        e.FormattingApplied = true; // Important!
            //    }
        }

    }
}
