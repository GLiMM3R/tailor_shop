using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
            if (this._fabric != null) { }
            else
            {
                await this.CreateFabric();
                this._fabricUC!.LoadFabrics();
                this.Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task CreateFabric()
        {

            if (string.IsNullOrWhiteSpace(type_txt.Text) || string.IsNullOrWhiteSpace(color_name_txt.Text) ||
           string.IsNullOrWhiteSpace(this._hexColor))
            {
                MessageBox.Show("Please enter valid fabric details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newFabric = new Fabric
                {
                    Type = type_txt.Text.Trim(),
                    ColorName = color_name_txt.Text.Trim(),
                    Color = this._hexColor,
                };


                await this._fabricService.Create(newFabric);
                this._hexColor = string.Empty;

                MessageBox.Show("New Fabric Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating fabric: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
