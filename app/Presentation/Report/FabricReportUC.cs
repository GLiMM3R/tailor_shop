using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Constant;
using app.Database;
using app.Model;
using app.Service;
using app.Utils;
using static app.Service.ReportService;

namespace app.Presentation.Report
{
    public partial class FabricReportUC : UserControl
    {
        private Pagination _pagination;
        private MainForm _mainForm;

        public FabricReportUC(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
            InitializeDataGridView();

            _pagination = new Pagination(1, 10);
        }

        private async void FabricReportUC_Load(object sender, EventArgs e)
        {
            await LoadFabricReport();
            await LoadFabricStatistic();

            // Usage:
            var reportTypes = Enum.GetValues(typeof(FabricReportType))
                .Cast<FabricReportType>()
                .Select(pt => new { Value = pt, Display = Period.GetEnumDisplayName(pt) })
                .ToList();

            report_type_cbb.DataSource = reportTypes;
            report_type_cbb.DisplayMember = "Display";
            report_type_cbb.ValueMember = "Value";
            report_type_cbb.SelectedIndex = 0;

            // Usage:
            var periodItems = Enum.GetValues(typeof(Period.PeriodType))
                .Cast<Period.PeriodType>()
                .Select(pt => new { Value = pt, Display = Period.GetEnumDisplayName(pt) })
                .ToList();

            period_cbb.DataSource = periodItems;
            period_cbb.DisplayMember = "Display";
            period_cbb.ValueMember = "Value";
            period_cbb.SelectedIndex = 0;

            pagesize_cbb.SelectedIndex = 0; // Set default page size to first item
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
        }

        private void InitializeDataGridView()
        {
            fabric_report_dgv.AutoGenerateColumns = false;
            fabric_report_dgv.Columns.Clear();
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
            fabric_report_dgv.Columns.AddRange(
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "FabricId", headerText: "ລະຫັດຜ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                    imageColumn,
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "MaterialType", headerText: "ປະເພດວັດສະດຸ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "ColorCode", headerText: "ລະຫັດສີ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    //DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Color", headerText: "ຄ່າສີ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50),
                    //DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "DisplayColor", headerText: "ສີ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalUsedQuantity", headerText: "ຈຳນວນຖືກໃຊ້", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50)
                //DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalValue", headerText: "ລວມມູນຄ່າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill)
                );

            fabric_report_dgv.RowTemplate.Height = 100; // Set row height to accommodate images
            fabric_report_dgv.CellFormatting += FabricReportDgv_CellFormatting;
            fabric_report_dgv.CellFormatting += fabric_dgv_CellFormatting;
        }

        private void FabricReportDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = fabric_report_dgv.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "TotalValue")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N2"); // Use "N2" for 2 decimal places  
                    e.FormattingApplied = true;
                }
            }
        }

        private void fabric_dgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colorColumnName = "Color"; // Column with hex codes
                int colorColumnIndex = -1;

                for (int i = 0; i < fabric_report_dgv.Columns.Count; i++)
                {
                    if (fabric_report_dgv.Columns[i].Name == colorColumnName)
                    {
                        colorColumnIndex = i;
                        break;
                    }
                }

                if (colorColumnIndex != -1)
                {
                    object hexColorValueObject = fabric_report_dgv.Rows[e.RowIndex].Cells[colorColumnIndex].Value;

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
                        string targetColumnToColorName = "DisplayColor";
                        if (fabric_report_dgv.Columns[e.ColumnIndex].Name == targetColumnToColorName)
                        {
                            e.CellStyle.BackColor = backgroundColor;
                            e.CellStyle.ForeColor = (backgroundColor.GetBrightness() < 0.5) ? Color.White : Color.Black;
                        }
                    }
                }
            }
        }

        private async Task LoadFabricReport()
        {
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);
                var reportType = report_type_cbb.SelectedValue is ReportService.FabricReportType type ? type : ReportService.FabricReportType.All;

                var result = await report.GetFabricReport(startOfDay, endOfDay, _pagination, reportType);
                _pagination.TotalItems = result.Total;
                fabric_report_dgv.DataSource = null;
                fabric_report_dgv.DataSource = result.Data.ToList();
                fabric_report_dgv.ClearSelection();
                UpdatePageNumber();

                // Update chart
                //InitializeLineChart();
                //BindLineChart(result.Data);
            }
        }

        private async Task LoadFabricStatistic()
        {
            using (var dbContext = new AppDbContext())
            {
                var report = new StatisticService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetFabricsStatistic(startOfDay, endOfDay);
                if (result != null)
                {
                    total_fabrics_lbl.Text = result.TotalFabrics.ToString("N0");
                    total_used_lbl.Text = result.TotalUsedFabrics.ToString("N0");
                }
            }
        }

        private void UpdatePageNumber()
        {
            if (_pagination.TotalItems > 0)
            {
                page_lbl.Text = $"{_pagination.Page}/{_pagination.TotalPages}";
            }
            else
            {
                page_lbl.Text = "0/0";
            }
        }

        private async void next_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.HasNextPage)
            {
                _pagination.Page++;
                await LoadFabricReport();
                await LoadFabricStatistic();

            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.TotalPages > 0)
            {
                _pagination.Page = _pagination.TotalPages;
                await LoadFabricReport();
                await LoadFabricStatistic();

            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadFabricReport();
            await LoadFabricStatistic();

        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.HasPreviousPage)
            {
                _pagination.Page--;
                await LoadFabricReport();
                await LoadFabricStatistic();

            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.Page > 1)
            {
                _pagination.Page = 1;
                await LoadFabricReport();
                await LoadFabricStatistic();

            }
        }

        private async void from_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadFabricReport();
            await LoadFabricStatistic();

        }

        private async void to_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadFabricReport();
            await LoadFabricStatistic();

        }

        private async void report_type_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the report type based on the selected value
            if (report_type_cbb.SelectedValue is FabricReportType selectedReportType)
            {
                // You can use this value to filter or change the report logic if needed
                // For now, we just reload the report with the new type
                _pagination.Page = 1; // Reset to first page when changing report type
                await LoadFabricReport();
                await LoadFabricStatistic();

            }
        }

        private void period_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var today = DateTime.Now.Date; // Declare 'today' at the beginning of the method
            switch (period_cbb.SelectedValue)
            {
                case Period.PeriodType.Today:
                    from_date_dpk.Value = today;
                    to_date_dpk.Value = today.AddDays(1).AddTicks(-1); // Set to end of today
                    break;
                case Period.PeriodType.Yesterday:
                    from_date_dpk.Value = today.AddDays(-1); // Set to yesterday
                    to_date_dpk.Value = today.AddTicks(-1); // Set to end of yesterday
                    break;
                case Period.PeriodType.ThisWeek:
                    var weekRange = DateUtils.GetWeekRange(today);
                    from_date_dpk.Value = weekRange.StartOfWeek; // 'today' is now properly declared
                    to_date_dpk.Value = weekRange.EndOfWeek; // Set to end of today
                    break;
                case Period.PeriodType.ThisMonth:
                    var monthRange = DateUtils.GetMonthRange(today);
                    from_date_dpk.Value = monthRange.StartOfMonth; // 'today' is now properly declared
                    to_date_dpk.Value = monthRange.EndOfMonth; // Set to end of today
                    break;
                case Period.PeriodType.ThisYear:
                    var yearRange = DateUtils.GetYearRange(today);
                    from_date_dpk.Value = yearRange.StartOfYear; // 'today' is now properly declared
                    to_date_dpk.Value = yearRange.EndOfYear; // Set to end of today
                    break;
                case Period.PeriodType.ThisQuarter:
                    var quarterRange = DateUtils.GetQuarterRange(today);
                    from_date_dpk.Value = quarterRange.StartOfQuarter; // 'today' is now properly declared
                    to_date_dpk.Value = quarterRange.EndOfQuarter; // Set to end of today
                    break;
                case Period.PeriodType.Last7Days:
                    var last7DaysRange = DateUtils.GetLast7DaysRange(today);
                    from_date_dpk.Value = last7DaysRange.Start; // 'today' is now properly declared
                    to_date_dpk.Value = last7DaysRange.End; // Set to end of today
                    break;
                case Period.PeriodType.Last30Days:
                    from_date_dpk.Value = today.AddDays(-30); // 'today' is now properly declared
                    to_date_dpk.Value = today; // Set to end of today
                    break;
                case Period.PeriodType.LastWeek:
                    var lastWeekRange = DateUtils.GetWeekRange(today.AddDays(-7));
                    from_date_dpk.Value = lastWeekRange.StartOfWeek; // 'today' is now properly declared
                    to_date_dpk.Value = lastWeekRange.EndOfWeek; // Set to end of today
                    break;
                case Period.PeriodType.LastMonth:
                    var lastMonthRange2 = DateUtils.GetLastMonthRange(today);
                    from_date_dpk.Value = lastMonthRange2.Start; // 'today' is now properly declared
                    to_date_dpk.Value = lastMonthRange2.End; // Set to end of today
                    break;
                case Period.PeriodType.LastYear:
                    var lastYearRange = DateUtils.GetYearRange(today.AddYears(-1));
                    from_date_dpk.Value = lastYearRange.StartOfYear; // 'today' is now properly declared
                    to_date_dpk.Value = lastYearRange.EndOfYear; // Set to end of today
                    break;
                default:
                    break;
            }
        }

        private async void export_btn_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);
                var allPagination = new Pagination(1, int.MaxValue);

                var result = await report.GetFabricReport(startOfDay, endOfDay, allPagination, FabricReportType.All);

                if (result.Data != null && result.Data.Any())
                {
                    var excelUtils = new ExcelUtils();
                    excelUtils.ExportToExcel(result.Data.ToList(), "Fabric Report", "fabric_report_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx");
                }
                else
                {
                    MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var frm = new ReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(frm);
        }
    }
}
