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
    public partial class OrderDetailUC : UserControl
    {
        private OrderUC _orderUC;
        public OrderDetailUC(OrderUC orderUC)
        {
            InitializeComponent();
            _orderUC = orderUC;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //_orderUC._mainForm.LoadFormIntoPanel(_orderUC);
        }
    }
}
