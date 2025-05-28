using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.Entity;
using app.Service;
using QuestPDF.Fluent;

namespace app.Presentation
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Sample invoice data
                var invoiceModel = new InvoiceModel
                {
                    InvoiceNumber = "INV-001",
                    IssueDate = DateTime.Now,
                    SellerName = "ABC Company",
                    CustomerName = "John Doe",
                    CustomerPhone = "456 Customer Rd, City, Country",
                    Items = new List<InvoiceItem>
            {
                new InvoiceItem { Description = "Item 1", Quantity = 2, UnitPrice = 50.00m },
                new InvoiceItem { Description = "Item 2", Quantity = 1, UnitPrice = 150.00m },
                new InvoiceItem { Description = "Item 3", Quantity = 3, UnitPrice = 30.00m }
            }
                };

                // Create the document
                var document = new InvoiceDocument(invoiceModel);

                // Configure QuestPDF to use the community license
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

                // Generate PDF
                string filePath = "invoice.pdf";
                document.GeneratePdf(filePath);

                // Open the PDF (optional)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });

                MessageBox.Show("Invoice PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
