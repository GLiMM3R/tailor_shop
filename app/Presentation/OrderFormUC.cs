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
    public partial class OrderFormUC : UserControl
    {
        public OrderFormUC()
        {
            InitializeComponent();
        }

        private void OrderFormUC_Load(object sender, EventArgs e)
        {
            // The 'DateTimePicker' control does not have a 'BorderStyle' property.
            // To achieve a borderless appearance, you can use a workaround like setting the control's FlatStyle or modifying its appearance.
            due_date_dpk.Enabled = false; // Example: Disable the control to give a read-only appearance.
        }
    }
}
