using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class CustomerReportUC : UserControl
    {
        private Pagination _pagination;
        private MainForm _mainForm;

        public CustomerReportUC(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            InitializeDataGridView();

            _pagination = new Pagination(1, 10);
        }
        private async void CustomerReportUC_Load(object sender, EventArgs e)
        {
            await LoadCustomerReport();
            await LoadCustomerStatistic();

            // Usage:
            var reportTypes = Enum.GetValues(typeof(CustomerReportType))
                .Cast<CustomerReportType>()
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

        public async Task LoadCustomerReport()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);
                var reportType = report_type_cbb.SelectedValue is ReportService.CustomerReportType type ? type : ReportService.CustomerReportType.All;

                var result = await report.GetCustomerReport(startOfDay, endOfDay, _pagination, reportType);
                _pagination.TotalItems = result.Total;
                customer_report_dgv.DataSource = null;
                customer_report_dgv.DataSource = result.Data.ToList();
                customer_report_dgv.ClearSelection();
                UpdatePageNumber();

                // Update chart
                //InitializeLineChart();
                //BindLineChart(result.Data);
            }
        }

        public async Task LoadCustomerStatistic()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new StatisticService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetCustomerStatistic(startOfDay, endOfDay);
                if (result != null)
                {
                    total_customers_lbl.Text = result.TotalCustomers.ToString();
                    new_customers_lbl.Text = result.NewCustomers.ToString();
                    repeat_customers_lbl.Text = result.RepeatCustomers.ToString();
                }
            }
        }

        private void InitializeDataGridView()
        {
            customer_report_dgv.AutoGenerateColumns = false;
            customer_report_dgv.Columns.Clear();

            customer_report_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ລະຫັດລູກຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Name", headerText: "ຊື່ລູກຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Gender", headerText: "ເພດ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Phone", headerText: "ເບີໂທ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderCount", headerText: "ຈຳນວນອໍເດີ້", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalQuantity", headerText: "ຈຳນວນສິນຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalSpent", headerText: "ຍອດລວມ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "LastOrderDate", headerText: "ອໍເດີ້ລ່າສຸດ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CreatedAt", headerText: "ວັນທີສ້າງ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Updated", headerText: "ວັນທີແກ້ໄຂ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill)
            );

            customer_report_dgv.CellFormatting += CustomerReportDgv_CellFormatting;
        }

        private void CustomerReportDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = customer_report_dgv.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "TotalSpent")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N0"); // Use "N2" for 2 decimal places  
                    e.FormattingApplied = true;
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
                await LoadCustomerReport();
                await LoadCustomerStatistic();
            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.TotalPages > 0)
            {
                _pagination.Page = _pagination.TotalPages;
                await LoadCustomerReport();
                await LoadCustomerStatistic();

            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadCustomerReport();
            await LoadCustomerStatistic();

        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.HasPreviousPage)
            {
                _pagination.Page--;
                await LoadCustomerReport();
                await LoadCustomerStatistic();

            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.Page > 1)
            {
                _pagination.Page = 1;
                await LoadCustomerReport();
                await LoadCustomerStatistic();

            }
        }

        private async void from_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadCustomerReport();
            await LoadCustomerStatistic();

        }

        private async void to_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadCustomerReport();
            await LoadCustomerStatistic();

        }

        private async void report_type_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the report type based on the selected value
            if (report_type_cbb.SelectedValue is CustomerReportType selectedReportType)
            {
                // You can use this value to filter or change the report logic if needed
                // For now, we just reload the report with the new type
                _pagination.Page = 1; // Reset to first page when changing report type
                await LoadCustomerReport();
                await LoadCustomerStatistic();

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

                var result = await report.GetCustomerReport(startOfDay, endOfDay, allPagination);

                if (result.Data != null && result.Data.Any())
                {
                    var excelUtils = new ExcelUtils();
                    excelUtils.ExportToExcel(result.Data.ToList(), "Customer Report", "customer_report_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx");
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
