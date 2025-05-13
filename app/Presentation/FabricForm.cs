using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Presentation
{
    public partial class FabricForm : Form
    {
        public FabricForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
        }

        private void choose_color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color_pn.BackColor = colorDialog.Color;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
