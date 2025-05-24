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
using System.Windows.Forms.DataVisualization.Charting;
using app.Entity;
using System.ComponentModel.DataAnnotations;


namespace app.Presentation.Report
{
    public enum PeriodType
    {
        [Display(Name = "ມຶ້ນີ້")]
        Today,
        [Display(Name = "ມື້ວານ")]
        Yesterday,
        [Display(Name = "ອາທິດນີ້")]
        ThisWeek,
        [Display(Name = "ເດືອນນີ້")]
        ThisMonth,
        [Display(Name = "ປີນີ້")]
        ThisYear,
        [Display(Name = "ໄຕມາດນີ້")]
        ThisQuarter,
        [Display(Name = "7ມື້ທີ່ແລ້ວ")]
        Last7Days,
        [Display(Name = "30ມື້ທີ່ແລ້ວ")]
        Last30Days,
        [Display(Name = "ອາທິດທີ່ແລ້ວ")]
        LastWeek,
        [Display(Name = "ເດືອນທີ່ແລ້ວ")]
        LastMonth,
        [Display(Name = "ປີກ່ອນ")]
        LastYear,
    }

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


            // Usage:
            var periodItems = Enum.GetValues(typeof(PeriodType))
                .Cast<PeriodType>()
                .Select(pt => new { Value = pt, Display = GetEnumDisplayName(pt) })
                .ToList();

            period_cbb.DataSource = periodItems;
            period_cbb.DisplayMember = "Display";
            period_cbb.ValueMember = "Value";
            period_cbb.SelectedIndex = 0;

            pagesize_cbb.SelectedIndex = 0; // Set default page size to first item
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
        }

        public static string GetEnumDisplayName(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = field.GetCustomAttributes(typeof(DisplayAttribute), false)
                            .FirstOrDefault() as DisplayAttribute;
            return attr?.Name ?? value.ToString();
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
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Discount", headerText: "ສ່ວນຫຼຸດ", dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleRight),
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
                    e.Value = value.ToString("N2"); // Use "N2" for 2 decimal places  
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
            }
        }

        private async void last_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.TotalPages > 0)
            {
                _pagination.Page = _pagination.TotalPages;
                await LoadOrders();
            }
        }

        private async void pagesize_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pagination.PageSize = int.Parse(pagesize_cbb.SelectedItem?.ToString() ?? "10");
            await LoadOrders();
        }

        private async void prev_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.HasPreviousPage)
            {
                _pagination.Page--;
                await LoadOrders();
            }
        }

        private async void first_page_btn_Click(object sender, EventArgs e)
        {
            if (_pagination.Page > 1)
            {
                _pagination.Page = 1;
                await LoadOrders();
            }
        }

        private async void from_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadOrders();
        }

        private async void to_date_dpk_ValueChanged(object sender, EventArgs e)
        {
            await LoadOrders();
        }

        //private void InitializeLineChart()
        //{
        //    overallSaleChart.Series.Clear();
        //    overallSaleChart.ChartAreas.Clear();

        //    // Create chart area
        //    var chartArea = new ChartArea("MainArea");
        //    overallSaleChart.ChartAreas.Add(chartArea);

        //    // Create line series
        //    var series = new Series("Total Sales")
        //    {
        //        ChartType = SeriesChartType.Line,
        //        XValueType = ChartValueType.Date,
        //        BorderWidth = 2
        //    };
        //    overallSaleChart.Series.Add(series);

        //    // Optional: Set axis format
        //    overallSaleChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
        //}

        //private void BindLineChart(IEnumerable<OverallSaleReport> data)
        //{
        //    var series = overallSaleChart.Series["Total Sales"];
        //    series.Points.Clear();

        //    foreach (var item in data)
        //    {
        //        // X: OrderDate, Y: TotalAmount
        //        series.Points.AddXY(item.OrderDate, item.TotalAmount);
        //    }
        //}


        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void period_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var today = DateTime.Now.Date; // Declare 'today' at the beginning of the method
            switch (period_cbb.SelectedValue)
            {
                case PeriodType.Today:
                    from_date_dpk.Value = today;
                    to_date_dpk.Value = today.AddDays(1).AddTicks(-1); // Set to end of today
                    break; 
                case PeriodType.Yesterday:
                    from_date_dpk.Value = today.AddDays(-1); // Set to yesterday
                    to_date_dpk.Value = today.AddTicks(-1); // Set to end of yesterday
                    break;
                case PeriodType.ThisWeek:
                    var weekRange = DateUtils.GetWeekRange(today);
                    from_date_dpk.Value = weekRange.StartOfWeek; // 'today' is now properly declared
                    to_date_dpk.Value = weekRange.EndOfWeek; // Set to end of today
                    break;
                case PeriodType.ThisMonth:
                    var monthRange = DateUtils.GetMonthRange(today);
                    from_date_dpk.Value = monthRange.StartOfMonth; // 'today' is now properly declared
                    to_date_dpk.Value = monthRange.EndOfMonth; // Set to end of today
                    break;
                case PeriodType.ThisYear:
                    var yearRange = DateUtils.GetYearRange(today);
                    from_date_dpk.Value = yearRange.StartOfYear; // 'today' is now properly declared
                    to_date_dpk.Value = yearRange.EndOfYear; // Set to end of today
                    break;
                case PeriodType.ThisQuarter:
                    var quarterRange = DateUtils.GetQuarterRange(today);
                    from_date_dpk.Value = quarterRange.StartOfQuarter; // 'today' is now properly declared
                    to_date_dpk.Value = quarterRange.EndOfQuarter; // Set to end of today
                    break;
                case PeriodType.Last7Days:
                    var last7DaysRange = DateUtils.GetLast7DaysRange(today);
                    from_date_dpk.Value = last7DaysRange.Start; // 'today' is now properly declared
                    to_date_dpk.Value = last7DaysRange.End; // Set to end of today
                    break;
                case PeriodType.Last30Days:
                    from_date_dpk.Value = today.AddDays(-30); // 'today' is now properly declared
                    to_date_dpk.Value = today; // Set to end of today
                    break;
                case PeriodType.LastWeek:
                    var lastWeekRange = DateUtils.GetWeekRange(today.AddDays(-7));
                    from_date_dpk.Value = lastWeekRange.StartOfWeek; // 'today' is now properly declared
                    to_date_dpk.Value = lastWeekRange.EndOfWeek; // Set to end of today
                    break;
                case PeriodType.LastMonth:
                    var lastMonthRange2 = DateUtils.GetLastMonthRange(today);
                    from_date_dpk.Value = lastMonthRange2.Start; // 'today' is now properly declared
                    to_date_dpk.Value = lastMonthRange2.End; // Set to end of today
                    break;
                case PeriodType.LastYear:
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