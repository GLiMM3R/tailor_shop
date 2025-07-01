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

        private void overall_sale_report_btn_Click(object sender, EventArgs e)
        {
            var report = new OverallSaleReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(report);
        }

        private void customer_report_btn_Click(object sender, EventArgs e)
        {
            var report = new CustomerReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(report);
        }

        private void fabric_report_btn_Click(object sender, EventArgs e)
        {
            var report = new FabricReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(report);
        }

        private void garment_report_btn_Click(object sender, EventArgs e)
        {
            var report = new GarmentReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(report);
        }

        private void payment_transaction_report_btn_Click(object sender, EventArgs e)
        {
            var report = new PaymentTransactionReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(report);
        }

        private void sale_report_btn_Click(object sender, EventArgs e)
        {
            var report = new SaleReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(report);
        }

        private void user_report_btn_Click(object sender, EventArgs e)
        {
            var report = new UserReportUC(_mainForm);
            _mainForm.LoadFormIntoPanel(report);
        }
    }
}
