using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Presentation.Report;

namespace app.Presentation
{
    public partial class ReportUC : UserControl
    {
        public MainForm _mainForm;
        public ReportUC(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private void order_report_btn_Click(object sender, EventArgs e)
        {
            var report = new OrderReportUC();
            _mainForm.LoadFormIntoPanel(report);
        }
    }
}
