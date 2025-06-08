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
        private readonly FabricService _fabricService;
        private Fabric? _fabric;
        private string _hexColor;
        public bool IsUpdate { get; set; } = false;
        public FabricForm(FabricService fabricService, Fabric? fabric)
        {
            InitializeComponent();

            this._fabricService = fabricService;
            this._fabric = fabric;
        }

        private void FabricForm_Load(object sender, EventArgs e)
        {
            type_txt.KeyDown += FormTextBox_KeyDown;
            color_name_txt.KeyDown += FormTextBox_KeyDown;
            unit_price_txt.KeyDown += FormTextBox_KeyDown;

            if (this._fabric != null)
            {
                add_btn.Text = "ແກ້ໄຂ";

                type_txt.Text = this._fabric.MaterialType;
                color_code_txt.Text = this._fabric.ColorCode;
                color_name_txt.Text = this._fabric.ColorName;
                unit_price_txt.Value = this._fabric.UnitPrice;

                if (_fabric.Image != null)
                {
                    using (var ms = new MemoryStream(_fabric.Image))
                    {
                        fabric_pb.Image = Image.FromStream(ms);
                    }
                }

                if (this._fabric.Color != null)
                {
                    this._hexColor = this._fabric.Color;
                    Color fabricColor = System.Drawing.ColorTranslator.FromHtml(this._hexColor);
                    color_pn.BackColor = fabricColor;
                }
            }
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
            if (this._fabric != null)
            {
                await this.UpdateFabric();
            }
            else
            {
                await this.CreateFabric();
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
                    MaterialType = type_txt.Text.Trim(),
                    ColorCode = color_code_txt.Text.Trim(),
                    ColorName = color_name_txt.Text.Trim(),
                    Color = this._hexColor,
                    UnitPrice = unit_price_txt.Value,
                };

                if (fabric_pb.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        // Image.RawFormat is good because it preserves the original format (JPG, PNG, etc.)
                        fabric_pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        newFabric.Image = ms.ToArray();
                    }
                }

                await this._fabricService.Create(newFabric);
                MessageBox.Show("New Fabric Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsUpdate = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating fabric: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Do not clear _hexColor here, as it may be needed for further operations
            }
        }

        private async Task UpdateFabric()
        {
            try
            {
                var fabric = await this._fabricService.GetByID(this._fabric!.Id);

                if (fabric == null)
                {
                    MessageBox.Show("Fabric not found!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (fabric.MaterialType != type_txt.Text && !string.IsNullOrWhiteSpace(type_txt.Text))
                {
                    fabric.MaterialType = type_txt.Text;
                }

                if (fabric.ColorCode != color_code_txt.Text && !string.IsNullOrWhiteSpace(color_code_txt.Text))
                {
                    fabric.ColorCode = color_code_txt.Text;
                }

                if (fabric.ColorName != color_name_txt.Text && !string.IsNullOrWhiteSpace(color_name_txt.Text))
                {
                    fabric.ColorName = color_name_txt.Text;
                }

                if (fabric.Color != this._hexColor && !string.IsNullOrWhiteSpace(this._hexColor))
                {
                    fabric.Color = this._hexColor;
                }

                if (fabric.UnitPrice != unit_price_txt.Value && unit_price_txt.Value != 0)
                {
                    fabric.UnitPrice = unit_price_txt.Value;
                }

                if (fabric_pb.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        fabric_pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        fabric.Image = ms.ToArray();
                    }
                }
                else
                {
                    fabric.Image = null; // Clear image if PictureBox is empty
                }


                await _fabricService.Update(fabric);
                MessageBox.Show("Fabric Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsUpdate = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void browse_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var originalImage = new Bitmap(openFileDialog.FileName))
                    {
                        // Set desired width and height (e.g., PictureBox size)
                        int targetWidth = fabric_pb.Width;
                        int targetHeight = fabric_pb.Height;

                        // Maintain aspect ratio
                        float ratioX = (float)targetWidth / originalImage.Width;
                        float ratioY = (float)targetHeight / originalImage.Height;
                        float ratio = Math.Min(ratioX, ratioY);

                        int newWidth = (int)(originalImage.Width * ratio);
                        int newHeight = (int)(originalImage.Height * ratio);

                        var resizedImage = new Bitmap(originalImage, newWidth, newHeight);
                        fabric_pb.Image = resizedImage;
                    }
                }
            }
        }

        private void clear_image_btn_Click(object sender, EventArgs e)
        {
            if (fabric_pb.Image != null)
            {
                fabric_pb.Image.Dispose();
                fabric_pb.Image = null;
            }
        }
    }
}
