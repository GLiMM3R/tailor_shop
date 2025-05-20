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

namespace app.Presentation
{
    public partial class GarmentUC : UserControl
    {
        private AppDbContext _dbContext;
        private GarmentService _garmentService;
        public GarmentUC()
        {
            InitializeComponent();
            this._dbContext = new AppDbContext();
            this._garmentService = new GarmentService(this._dbContext);
        }
        private void GarmentUC_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            _ = LoadGarments();
        }

        private void new_garment_btn_Click(object sender, EventArgs e)
        {
            var form = new GarmentForm(this, this._garmentService, null);
            form.ShowDialog();
        }


        private void InitializeDataGridView()
        {
            garment_dvg.AutoGenerateColumns = false;
            garment_dvg.Columns.Clear();

            garment_dvg.Columns.AddRange(
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Id", headerText: "ID"),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Name", headerText: "Name", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, dataGridViewContentAlignment: DataGridViewContentAlignment.MiddleLeft, fillWeight: 80),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "BasePrice", headerText: "BasePrice", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill, fillWeight: 40),
                DataGridViewUtils.CreateTextBoxColumn(dataPropertyName: "Description", headerText: "Description", autoSizeMode: DataGridViewAutoSizeColumnMode.Fill)
                );

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

            garment_dvg.Columns.Add(actionColumn);

            //fabric_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //garment_dvg.CellFormatting += this.fabric_dgv_CellFormatting;
            garment_dvg.CellContentClick += this.garment_dgv_CellContentClick;
        }

        private void garment_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (garment_dvg.Columns[e.ColumnIndex].Name == "Edit")
                {
                    if (garment_dvg.Rows[e.RowIndex].DataBoundItem is Garment selectedGarment)
                    {
                        var form = new GarmentForm(this, this._garmentService, selectedGarment);
                        form.ShowDialog();
                    }
                }
            }
        }

        public async Task LoadGarments()
        {
            var garments = await _garmentService.GetAll(null);
            garment_dvg.DataSource = garments;
        }
    }
}
