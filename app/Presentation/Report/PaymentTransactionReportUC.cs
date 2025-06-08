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
    public partial class PaymentTransactionReportUC : UserControl
    {
        private Pagination _pagination;
        public PaymentTransactionReportUC()
        {
            InitializeComponent();
            _pagination = new Pagination(1, 10);
        }

        private async void PaymentTransactionReportUC_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            await LoadPaymentReport();
            await LoadPaymentStatistic();

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
            payment_report_dgv.AutoGenerateColumns = false;
            payment_report_dgv.Columns.Clear();

            payment_report_dgv.Columns.AddRange(
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderNumber", headerText: "ເລກທີສັ່ງຊື້", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderDate", headerText: "ວັນທີສັ່ງຊື້", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CustomerName", headerText: "ຊື່ລູກຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalAmount", headerText: "ຍອດລວມທີ່ຕ້ອງຊຳລະ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "PaidAmount", headerText: "ຈຳນວນຊຳລະ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TransactionType", headerText: "ປະເພດທຸລະກຳ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CreatedAt", headerText: "ວັນທີສ້າງ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                            DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "UpdatedAt", headerText: "ວັນທີແກ້ໄຂ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter)
                        );

            payment_report_dgv.CellFormatting += PaymentReportDgv_CellFormatting;
        }

        private void PaymentReportDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = payment_report_dgv.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "TotalAmount" || columnName == "PaidAmount")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N0"); // Use "N2" for 2 decimal places  
                    e.FormattingApplied = true;
                }
            }
        }

        private async Task LoadPaymentReport()
        {
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetPaymentTransactionReport(startOfDay, endOfDay, _pagination);
                _pagination.TotalItems = result.Total;
                payment_report_dgv.DataSource = null;
                payment_report_dgv.DataSource = result.Data.ToList();
                payment_report_dgv.ClearSelection();
                UpdatePageNumber();

                // Update chart
                //InitializeLineChart();
                //BindLineChart(result.Data);
            }
        }

        private async Task LoadPaymentStatistic()
        {
            using (var dbContext = new AppDbContext())
            {
                var report = new StatisticService(dbContext);

                var startOfDay = from_date_dpk.Value.Date;
                var endOfDay = to_date_dpk.Value.Date.AddDays(1).AddTicks(-1);

                var result = await report.GetPaymentTransactionStatistic(startOfDay, endOfDay);
                if (result != null)
                {
                    total_transactions_lbl.Text = result.TotalTransactions.ToString("N0");
                    total_paid_amount_lbl.Text = result.TotalPaidAmount.ToString("N0");
                    total_cash_lbl.Text = result.TotalCashTransactions.ToString("N0");
                    total_bank_lbl.Text = result.TotalBankTransactions.ToString("N0");
                    total_deposit_lbl.Text = result.TotalDepositTransactions.ToString("N0");
                    total_avg_lbl.Text = result.AverageTransactionAmount.ToString("N0");
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
                await LoadPaymentReport();
                await LoadPaymentStatistic();

            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.TotalPages > 0)
            {
                _pagination.Page = _pagination.TotalPages;
                await LoadPaymentReport();
                await LoadPaymentStatistic();

            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadPaymentReport();
            await LoadPaymentStatistic();

        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.HasPreviousPage)
            {
                _pagination.Page--;
                await LoadPaymentReport();
                await LoadPaymentStatistic();

            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.Page > 1)
            {
                _pagination.Page = 1;
                await LoadPaymentReport();
                await LoadPaymentStatistic();

            }
        }

        private async void from_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadPaymentReport();
            await LoadPaymentStatistic();

        }

        private async void to_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadPaymentReport();
            await LoadPaymentStatistic();

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

                var result = await report.GetPaymentTransactionReport(startOfDay, endOfDay, allPagination);

                if (result.Data != null && result.Data.Any())
                {
                    var excelUtils = new ExcelUtils();
                    excelUtils.ExportToExcel(result.Data.ToList(), "Payment Transaction Report", "payment_transaction_report_" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xlsx");
                }
                else
                {
                    MessageBox.Show("No data available to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
