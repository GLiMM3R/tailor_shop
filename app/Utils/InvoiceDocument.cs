using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Entity;
using app.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace app.Utils
{
    public class InvoiceDocument : IDocument
    {
        private readonly InvoiceModel _model;

        public InvoiceDocument(InvoiceModel model)
        {
            _model = model;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50);
                    page.Size(PageSizes.A4);
                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Noto Sans Lao"));

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.Span("Page ");
                        x.CurrentPageNumber();
                    });
                });
        }

        void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().AlignCenter().Text("ໃບຮັບເງິນ").FontSize(20).Bold();
                column.Item().Text($"ໃບຮັບເງິນເລກທີ: {_model.InvoiceNumber}").FontSize(12);
                column.Item().Text($"ວັນທີ: {_model.IssueDate:dd/MM/yyyy}").FontSize(12);
                column.Item().Text($"ວັນທີຮັບເຄື່ອງ: {_model.DueDate:dd/MM/yyyy}").FontSize(12);
                column.Item().PaddingVertical(10).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text("ພະນັກງານ:").Bold();
                        col.Item().Text(_model.SellerName);
                    });

                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text("ລູກຄ້າ:").Bold();
                        col.Item().Text(_model.CustomerName);
                        col.Item().Text(_model.CustomerPhone);
                    });
                });
            });
        }

        void ComposeContent(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().PaddingVertical(10).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(50); // No.
                        columns.RelativeColumn(3); // Description
                        columns.ConstantColumn(100); // Quantity
                        columns.ConstantColumn(100); // Unit Price
                        columns.ConstantColumn(100); // Total
                    });

                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("No.").Bold();
                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("ລາຍການ").Bold();
                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("ຈຳນວນ").Bold();
                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("ລາຄາ").Bold();
                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("ລວມ").Bold();
                    });

                    int index = 1;
                    foreach (var item in _model.Items)
                    {
                        table.Cell().Padding(5).Text(index++.ToString());
                        table.Cell().Padding(5).Text(item.Description);
                        table.Cell().Padding(5).Text(item.Quantity.ToString());
                        table.Cell().Padding(5).Text($"{item.UnitPrice}");
                        table.Cell().Padding(5).Text($"{item.Total}");
                    }
                });

                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ຍອດລວມ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.Subtotal}").Bold();
                });
                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ສ່ວນຫຼຸດ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.Discount}").Bold();
                });
                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ມັດຈຳ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.DepositAmount}").Bold();
                });
                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ຍອດລວມສຸດທິ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.TotalAmount}").Bold();
                });
                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ຈຳນວນທີ່ຈ່າຍ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.TotalAmount - _model.DepositAmount}").Bold();
                });
            });
        }
    }
}
