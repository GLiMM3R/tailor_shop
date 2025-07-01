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
using app.Utils;
using Microsoft.EntityFrameworkCore;

namespace app.Presentation
{
    public partial class MeasurementsForm : Form
    {
        private int _orderId;
        private List<Measurement> measurements;
        public MeasurementsForm(int orderId)
        {
            InitializeComponent();
            InitializeDataGridView();
            _orderId = orderId;
        }

        private async void MeasurementsForm_Load(object sender, EventArgs e)
        {
            await LoadMeasurements();
        }

        private async Task LoadMeasurements()
        {
            using (var context = new AppDbContext())
            {
                measurements = await context.Measurements
                    .Where(m => m.OrderItemId == _orderId)
                    .ToListAsync();
            }

            if (measurements.Count > 0)
            {
                measurements_dgv.DataSource = measurements;
            }
        }

        private void InitializeDataGridView()
        {
            measurements_dgv.AutoGenerateColumns = false;
            measurements_dgv.Columns.Clear();

            measurements_dgv.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ລະຫັດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 20),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "BodyType", headerText: "ປະເພດ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "BodyPart", headerText: "ສ່ວນຮ່າງກາຍ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Value", headerText: "ຄ່າວັດແທກ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Unit", headerText: "ຫົວໜ່ວຍ", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleCenter, fillWeight: 50)
            );

            measurements_dgv.CellFormatting += MeasurementDgv_CellFormatting;
        }

        private void MeasurementDgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (measurements_dgv.Columns[e.ColumnIndex].DataPropertyName == "BodyType")
            {
                if (measurements_dgv.Rows[e.RowIndex].DataBoundItem is Measurement item)
                {
                    e.Value = item.BodyType == BodyType.UpperBody ? "ຮ່າງກາຍສ່ວນເທິງ" : "ຮ່າງກາຍສ່ວນລຸ່ມ";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
