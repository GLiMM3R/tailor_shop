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
using app.Constant;


namespace app.Presentation.Report
{
    public partial class OverallSaleReportUC : UserControl
    {
        private Pagination _pagination;
        public OverallSaleReportUC()
        {
            InitializeComponent();
            _pagination = new Pagination(1, 10);
        }

        private async void OrderReportUC_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            await LoadOrders();
            await LoadStatistic();


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
            order_dgv.AutoGenerateColumns = false;
            order_dgv.Columns.Clear();

            order_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderDate", headerText: "ວັນທີ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalOrders", headerText: "ຈຳນວນອໍເດີ້", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalCustomers", headerText: "ຈຳນວນລູກຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalQuantity", headerText: "ຈຳນວນຕັດ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "SubTotal", headerText: "ຍອດລວມຂາຍ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "DepositAmount", headerText: "ຍອດລວມມັດຈຳ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalPaid", headerText: "ຍອດຊຳລະແລ້ວ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalAmount", headerText: "ຍອດລວມສຸດທິ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill)
            );

            order_dgv.CellFormatting += OrderReportDgv_CellFormatting;
        }

        private void OrderReportDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = order_dgv.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "SubTotal" || columnName == "Discount" || columnName == "DepositAmount" ||
                columnName == "TotalPaid" || columnName == "TotalAmount")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N0"); // Use "N2" for 2 decimal places  
                    e.FormattingApplied = true;
                }
            }
        }

        public async Task LoadOrders()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetOverallSaleReport(startOfDay, endOfDay, _pagination);
                _pagination.TotalItems = result.Total;
                order_dgv.DataSource = null;
                order_dgv.DataSource = result.Data.ToList();
                order_dgv.ClearSelection();
                UpdatePageNumber();

                // Update chart
                //InitializeLineChart();
                //BindLineChart(result.Data);
            }
        }

        public async Task LoadStatistic()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new StatisticService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetOverallSaleStatistic(startOfDay, endOfDay);

                if (result != null)
                {
                    gross_sales_lbl.Text = result.SubTotal.ToString("N0");
                    net_sales_lbl.Text = result.TotalAmount.ToString("N0");
                    total_orders_lbl.Text = result.TotalOrders.ToString("N0");
                    aov_lbl.Text = result.TotalAvg.ToString("N0");
                    paid_amount_lbl.Text = result.TotalPaid.ToString("N0");
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
                await LoadOrders();
                await LoadStatistic();

            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.TotalPages > 0)
            {
                _pagination.Page = _pagination.TotalPages;
                await LoadOrders();
                await LoadStatistic();

            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadOrders();
            await LoadStatistic();

        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.HasPreviousPage)
            {
                _pagination.Page--;
                await LoadOrders();
                await LoadStatistic();

            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.Page > 1)
            {
                _pagination.Page = 1;
                await LoadOrders();
                await LoadStatistic();

            }
        }

        private async void from_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadOrders();
            await LoadStatistic();

        }

        private async void to_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadOrders();
            await LoadStatistic();

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

        private async void export_to_excel_btn_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);
                var allPagination = new Pagination(1, int.MaxValue);

                var result = await report.GetOverallSaleReport(startOfDay, endOfDay, allPagination);

                if (result.Data != null && result.Data.Any())
                {
                    var excelUtils = new ExcelUtils();
                    excelUtils.ExportToExcel(result.Data.ToList(), "Overall Sale Report", "overall_sale_report_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx");
                }
                else
                {
                    MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}