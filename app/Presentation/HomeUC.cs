using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using app.Database;
using app.Entity;
using app.Model;
using app.Service;
using app.Utils;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;

namespace app.Presentation
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public async Task LoadLineChart()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new ReportService(dbContext);
                var now = DateTime.Now;

                var from_date = now.AddDays(-30); // 30 days ago
                var to_date = now;

                var result = await report.GetOverallSaleReport(from_date, to_date, new Pagination(1, 30));

                // Update chart
                InitializeLineChart();
                BindLineChart(result.Data);
            }
        }

        public async Task LoadOverallStatistic()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var report = new StatisticService(dbContext);
                var now = DateTime.Now;

                var monthRange = DateUtils.GetMonthRange(now);

                var from_date = now.AddDays(-30); // 30 days ago
                var to_date = now;

                var result = await report.GetOverallSaleStatistic(monthRange.StartOfMonth, monthRange.EndOfMonth);

                if (result != null)
                {
                    total_orders_lbl.Text = result.TotalOrders.ToString("N0");
                    total_amount_lbl.Text = result.TotalAmount.ToString("N2");
                    new_customers_lbl.Text = (await dbContext.Customers
                        .Where(c => c.CreatedAt >= monthRange.StartOfMonth && c.CreatedAt <= monthRange.EndOfMonth)
                        .CountAsync()).ToString();

                    BindDonutChart(result);
                }
            }
        }

        private void InitializeLineChart()
        {
            line_chart.Series.Clear();
            line_chart.ChartAreas.Clear();

            // Create chart area
            var chartArea = new ChartArea("MainArea");
            line_chart.ChartAreas.Add(chartArea);

            // Create line series
            var series = new Series("Total Sales")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Date,
                BorderWidth = 2
            };
            line_chart.Series.Add(series);

            // Optional: Set axis format
            line_chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
        }

        private void BindLineChart(IEnumerable<OverallSaleReport> data)
        {
            var series = line_chart.Series["Total Sales"];
            series.Points.Clear();

            foreach (var item in data)
            {
                // X: OrderDate, Y: TotalAmount
                series.Points.AddXY(item.OrderDate, item.TotalAmount);
            }
        }

        private async void HomeUC_Load(object sender, EventArgs e)
        {
            InitializeDonutChart();
            await LoadLineChart();
            await LoadOrders();
            await LoadOverallStatistic();
        }

        private void InitializeDonutChart()
        {
            donut_chart.Series.Clear();
            donut_chart.ChartAreas.Clear();

            // Create chart area
            var chartArea = new ChartArea();
            donut_chart.ChartAreas.Add(chartArea);

            // Create line series
            var series = new Series("Payments")
            {
                ChartType = SeriesChartType.Doughnut,
                BorderWidth = 2
            };
            // Show values on the chart
            series.IsValueShownAsLabel = true;
            donut_chart.Series.Add(series);
        }

        private void BindDonutChart(OverallSaleStatistic data)
        {
            var series = donut_chart.Series["Payments"];
            series.Points.Clear();

            series.Points.AddXY("ຍອດລວມສຸດທິ", data.TotalAmount.ToString("N2"));
            series.Points.AddXY("ມັດຈຳ", data.DepositAmount.ToString("N2"));
        }

        private void InitializeDataGridView()
        {
            order_dgv.AutoGenerateColumns = false;
            order_dgv.Columns.Clear();

            order_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 20),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "OrderNumber", headerText: "ເລກທີສັ່ງຕັດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 38),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Garment", headerText: "ປະເພດເສື້ອຜ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Customer", headerText: "ຊື່ລູກຄ້າ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "User", headerText: "ຊື່ຜູ້ໃຊ້ລະບົບ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Status", headerText: "ສະຖານະ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 30),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "CreatedAt", headerText: "ວັນທີສ້າງ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "UpdatedAt", headerText: "ວັນທີແກ້ໄຂ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 50)
            );

            order_dgv.CellFormatting += OrderDgv_CellFormatting;
        }

        private void OrderDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "Customer")
            {
                var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
                if (order != null && order.Customer != null)
                {
                    e.Value = order.Customer.Name;
                    e.FormattingApplied = true;
                }
            }

            if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "User")
            {
                var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
                if (order != null && order.User != null)
                {
                    e.Value = order.User.Username;
                    e.FormattingApplied = true;
                }
            }

            if (order_dgv.Columns[e.ColumnIndex].DataPropertyName == "Garment")
            {
                var order = order_dgv.Rows[e.RowIndex].DataBoundItem as Order;
                if (order != null && order.Garment != null)
                {
                    e.Value = order.Garment.Name;
                    e.FormattingApplied = true;
                }
            }
        }

        public async Task LoadOrders()
        {
            // Always create a new DbContext and OrderService to avoid caching
            using (var dbContext = new AppDbContext())
            {
                var _filter = new FilterOrder(1, 5);
                var orderService = new OrderService(dbContext);
                var result = await orderService.GetAll(_filter);
                order_dgv.DataSource = null;
                order_dgv.DataSource = result.Data.ToList();
                order_dgv.ClearSelection();
            }
        }
    }
}
