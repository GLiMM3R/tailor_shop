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

namespace app.Presentation
{
    public partial class GarmentForm : Form
    {
        private GarmentUC _garmentUC;
        private GarmentService _garmentService;
        private Garment? _garment;
        public GarmentForm(GarmentUC garmentUC, GarmentService garmentService, Garment? garment)
        {
            InitializeComponent();
            this._garmentUC = garmentUC;
            this._garmentService = garmentService;
            this._garment = garment;
        }

        private void GarmentForm_Load(object sender, EventArgs e)
        {
            name_txt.KeyDown += FormTextBox_KeyDown;
            description_txt.KeyDown += FormTextBox_KeyDown;
            base_price_num.KeyDown += FormTextBox_KeyDown;

            if (this._garment != null)
            {
                add_btn.Text = "ແກ້ໄຂ";
                name_txt.Text = this._garment.Name;
                base_price_num.Value = this._garment.BasePrice ?? 0; // Use null-coalescing operator to handle null values  
                description_txt.Text = this._garment.Description ?? string.Empty; // Use null-coalescing operator to handle null values  
            }
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (this._garment != null)
            {
                await UpdateFabric();
            }
            else
            {
                await CreateGarment();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task CreateGarment()
        {
            if (string.IsNullOrWhiteSpace(name_txt.Text))
            {
                MessageBox.Show("Please enter valid garment details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newGarment = new Garment
                {
                    Name = name_txt.Text.Trim(),
                    BasePrice = base_price_num.Value,
                    Description = description_txt.Text.Trim()
                };


                await this._garmentService.Create(newGarment);
                MessageBox.Show("New Garment Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await this._garmentUC.LoadGarments();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating garment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateFabric()
        {
            try
            {
                var garment = await this._garmentService.GetByID(this._garment!.Id);

                if (garment == null)
                {
                    MessageBox.Show("Garment not found!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (garment.Name != name_txt.Text && !string.IsNullOrWhiteSpace(name_txt.Text))
                {
                    garment.Name = name_txt.Text.Trim();
                }

                if (garment.BasePrice != base_price_num.Value && base_price_num.Value != 0)
                {
                    garment.BasePrice = base_price_num.Value;
                }


                if (garment.Description != description_txt.Text && !string.IsNullOrWhiteSpace(description_txt.Text))
                {
                    garment.Description = description_txt.Text;
                }

                await _garmentService.Update(garment);
                MessageBox.Show("Garment Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await this._garmentUC.LoadGarments();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating garment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Optionally prevent the ding sound
                e.SuppressKeyPress = true;
                add_btn.PerformClick();
            }
        }
    }
}
