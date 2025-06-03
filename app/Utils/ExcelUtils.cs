using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace app.Utils
{
    public class ExcelUtils
    {
        public void ExportToExcel<T>(List<T> data, string sheetName, string fileName)
        {
            // Set the license context correctly for EPPlus 5.0 and later versions
            ExcelPackage.License.SetNonCommercialPersonal("Tailor");

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

                // add headers  
                int col = 1;
                foreach (var prop in typeof(T).GetProperties())
                {
                    worksheet.Cells[1, col].Value = prop.Name;
                    col++;
                }

                // add data rows with formatted values
                int row = 2;
                foreach (var item in data)
                {
                    col = 1;
                    foreach (var prop in typeof(T).GetProperties())
                    {
                        var value = prop.GetValue(item);
                        if (value is DateTime dt)
                        {
                            worksheet.Cells[row, col].Value = dt.ToString("dd-MM-yyyy HH:mm:ss");
                        }
                        else if (value is decimal dec)
                        {
                            worksheet.Cells[row, col].Value = dec;
                            worksheet.Cells[row, col].Style.Numberformat.Format = "#,##0.00";
                        }
                        else if (value is double dbl)
                        {
                            worksheet.Cells[row, col].Value = dbl;
                            worksheet.Cells[row, col].Style.Numberformat.Format = "#,##0.00";
                        }
                        else if (value is float flt)
                        {
                            worksheet.Cells[row, col].Value = flt;
                            worksheet.Cells[row, col].Style.Numberformat.Format = "#,##0.00";
                        }
                        else
                        {
                            worksheet.Cells[row, col].Value = value;
                        }
                        col++;
                    }
                    row++;
                }

                // autofit columns for better readability  
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // save the excel file  
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = fileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(excelFile);
                    MessageBox.Show("Data exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
