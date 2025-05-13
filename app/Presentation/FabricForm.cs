using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Model;
using app.Service;
using Microsoft.IdentityModel.Tokens;

namespace app.Presentation
{
    public partial class FabricForm : Form
    {
        private readonly FabricUC _fabricUC;
        private readonly FabricService _fabricService;
        private Fabric? _fabric;
        private string _hexColor;
        public FabricForm(FabricUC fabricUC, FabricService fabricService, Fabric? fabric)
        {
            InitializeComponent();

            this._fabricUC = fabricUC;
            this._fabricService = fabricService;
            this._fabric = fabric;
        }

        private void choose_color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color_pn.BackColor = colorDialog.Color;
                this._hexColor = $"#{colorDialog.Color.R:X2}{colorDialog.Color.G:X2}{colorDialog.Color.B:X2}";
            }
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            if (this._fabric != null) { }
            else
            {
               isSuccess = await this.CreateFabric();
            }

            if (isSuccess)
            {
                this._fabricUC!.LoadFabrics();
                this.Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<bool> CreateFabric()
        {
            if(this._hexColor.IsNullOrEmpty())
            {
                MessageBox.Show("Color is empty");
                return false;
            }

            var newFabric = new Fabric
            {
                Type = type_txt.Text.Trim(),
                Color = this._hexColor,
            };

            try
            {
                await this._fabricService.Create(newFabric);
                this._hexColor = string.Empty;
                MessageBox.Show("New Fabric Created!");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating fabric: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
