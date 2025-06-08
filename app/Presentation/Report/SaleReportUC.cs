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
using app.Entity;
using app.Model;
using app.Service;
using app.Utils;
using static app.Service.ReportService;

namespace app.Presentation.Report
{
    public partial class SaleReportUC : UserControl
    {
        private Pagination _pagination = new Pagination(1, 10);

        public SaleReportUC()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private async void SaleReportUC_Load(object sender, EventArgs e)
        {
            await LoadSaleReport();
            //await LoadStatistic();

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
            sale_report_dgv.AutoGenerateColumns = false;
            sale_report_dgv.Columns.Clear();

            sale_report_dgv.Columns.AddRange(
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderNumber", headerText: "ເລກທີສັ່ງຊື້", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CustomerName", headerText: "ລູກຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Username", headerText: "ພະນັກງານ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Subtotal", headerText: "ຍອດລວມ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalAMount", headerText: "ຍອດລວມສຸດທິ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Status", headerText: "ສະຖານະ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                    DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "PickUpDate", headerText: "ວັນທີຮັບເຄື່ອງ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill)
                );

            sale_report_dgv.CellFormatting += SaleReportDgv_CellFormatting;
        }

        private void SaleReportDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = sale_report_dgv.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "Subtotal" | columnName == "TotalAMount")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N0"); // Use "N2" for 2 decimal places  
                    e.FormattingApplied = true;
                }
            }

            if (columnName == "Status")
            {
                var order = sale_report_dgv.Rows[e.RowIndex].DataBoundItem as SaleReport;
                if (order != null && Enum.TryParse(typeof(OrderStatus), order.Status, out var statusEnum))
                {
                    e.Value = EnumUtils.GetEnumDisplayName((Enum)statusEnum);
                    e.FormattingApplied = true;
                }
            }
        }

        public async Task LoadSaleReport()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetSaleReport(startOfDay, endOfDay, _pagination);
                _pagination.TotalItems = result.Total;
                sale_report_dgv.DataSource = null;
                sale_report_dgv.DataSource = result.Data.ToList();
                sale_report_dgv.ClearSelection();
                UpdatePageNumber();


                // Update chart
                //InitializeLineChart();
                //BindLineChart(result.Data);
            }
            await LoadStatistic();
        }

        public async Task LoadStatistic()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new StatisticService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetOrderStatistic(startOfDay, endOfDay);

                if (result != null)
                {
                    total_orders_lbl.Text = result.TotalOrders.ToString("N0");
                    in_progress_lbl.Text = result.InProgressOrders.ToString("N0");
                    complete_lbl.Text = result.CompletedOrders.ToString("N0");
                    pick_up_lbl.Text = result.PickedUpOrders.ToString("N0");
                    canceled_lbl.Text = result.CanceledOrders.ToString("N0");
                }

                // Update chart
                //InitializeLineChart();
                //BindLineChart(result.Data);
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
                await LoadSaleReport();
            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.TotalPages > 0)
            {
                _pagination.Page = _pagination.TotalPages;
                await LoadSaleReport();
            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadSaleReport();
        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.HasPreviousPage)
            {
                _pagination.Page--;
                await LoadSaleReport();
            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.Page > 1)
            {
                _pagination.Page = 1;
                await LoadSaleReport();
            }
        }

        private async void from_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadSaleReport();
        }

        private async void to_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadSaleReport();
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

                var result = await report.GetSaleReport(startOfDay, endOfDay, allPagination);

                if (result.Data != null && result.Data.Any())
                {
                    var excelUtils = new ExcelUtils();
                    excelUtils.ExportToExcel(result.Data.ToList(), "Sale Report", "sale_report_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx");
                }
                else
                {
                    MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
