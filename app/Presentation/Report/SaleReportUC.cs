﻿using System;
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
    public partial class SaleReportUC : UserControl
    {
        private Pagination _pagination = new Pagination(1, 10);

        public SaleReportUC()
        {
            InitializeComponent();
        }

        private async void SaleReportUC_Load(object sender, EventArgs e)
        {
            await LoadSaleReport();
        }

        private void InitializeDataGridView()
        {
            sale_report_dgv.AutoGenerateColumns = false;
            sale_report_dgv.Columns.Clear();

            sale_report_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ລະຫັດລູກຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Name", headerText: "ຊື່ລູກຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Gender", headerText: "ເພດ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Phone", headerText: "ເບີໂທ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderCount", headerText: "ຈຳນວນອໍເດີ້", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalQuantity", headerText: "ຈຳນວນສິນຄ້າ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "TotalSpent", headerText: "ຍອດລວມ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "LastOrderDate", headerText: "ອໍເດີ້ລ່າສຸດ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CreatedAt", headerText: "ວັນທີສ້າງ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Updated", headerText: "ວັນທີແກ້ໄຂ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight, autoSizeMode: DataGridViewAutoSizeColumnMode.Fill)
            );

            sale_report_dgv.CellFormatting += CustomerReportDgv_CellFormatting;
        }

        private void CustomerReportDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = sale_report_dgv.Columns[e.ColumnIndex].DataPropertyName;
            if (columnName == "TotalSpent")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N2"); // Use "N2" for 2 decimal places  
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
                var reportType = report_type_cbb.SelectedValue is ReportService.CustomerReportType type ? type : ReportService.CustomerReportType.All;

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

        private async void report_type_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the report type based on the selected value
            if (report_type_cbb.SelectedValue is CustomerReportType selectedReportType)
            {
                // You can use this value to filter or change the report logic if needed
                // For now, we just reload the report with the new type
                _pagination.Page = 1; // Reset to first page when changing report type
                await LoadSaleReport();
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
    }
}
