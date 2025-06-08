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
    public enum DocumentType
    {
        Invoice,
        Receipt,
    }
    public class InvoiceDocument : IDocument
    {
        private readonly InvoiceModel _model;
        private readonly DocumentType _document;
        private string title = "ໃບແຈ້ງໜີ້";

        public InvoiceDocument(InvoiceModel model, DocumentType document)
        {
            _model = model;
            _document = document;

            switch (document)
            {
                case DocumentType.Invoice:
                    title = "ໃບແຈ້ງໜີ້";
                    break;
                case DocumentType.Receipt:
                    title = "ໃບຮັບເງິນ";
                    break;
            }
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
                    //page.Footer().AlignCenter().Text(x =>
                    //{
                    //    x.Span("Page ");
                    //    x.CurrentPageNumber();
                    //});
                });
        }

        void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().AlignCenter().Text(this.title).FontSize(20).Bold();
                

                column.Item().PaddingTop(20).Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text("ຮ້ານຕັດຫຍິບ ທ້າວ ມີ ແສງຈັນ");
                        col.Item().Text("ບ້ານ ປ່ອງຄຳ, ນະຄອນຫຼວງພະບາງ, ແຂວງຫຼວງພະບາງ");
                        col.Item().Text("ເບີໂທ 020 78978978");
                    });

                    row.RelativeItem().Column(col =>
                    {
                        col.Item().AlignRight().Row(row =>
                        {
                            row.RelativeItem().AlignRight().Text("ໃບຮັບເງິນເລກທີ:");
                            row.ConstantItem(120).AlignRight().Text($"{_model.InvoiceNumber}");
                        });
                        col.Item().AlignRight().Row(row =>
                        {
                            row.RelativeItem().AlignRight().Text("ວັນທີ:");
                            row.ConstantItem(120).AlignRight().Text($"{_model.IssueDate:dd/MM/yyyy}");
                        });
                        col.Item().AlignRight().Row(row =>
                        {
                            row.RelativeItem().AlignRight().Text("ວັນທີຮັບເຄື່ອງ:");
                            row.ConstantItem(120).AlignRight().Text($"{_model.DueDate:dd/MM/yyyy}");
                        });
                    });
                });

                column.Item().PaddingVertical(10).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().AlignLeft().Row(row =>
                        {
                            row.ConstantItem(60).AlignLeft().Text("ຊື່ພະນັກງານ:");
                            row.RelativeItem().AlignLeft().Text(_model.SellerName);
                        });
                    });

                    row.ConstantItem(200).Column(col =>
                    {
                        col.Item().AlignRight().Row(row =>
                        {
                            row.RelativeItem().AlignRight().Text("ຊື່ລູກຄ້າ:");
                            row.ConstantItem(150).AlignRight().Text(_model.CustomerName);
                        });
                        col.Item().AlignRight().Row(row =>
                        {
                            row.RelativeItem().AlignRight().Text("ເບີໂທ:");
                            row.ConstantItem(150).AlignRight().Text(_model.CustomerPhone);
                        });

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
                        table.Cell().Padding(5).Text(item.UnitPrice.ToString("N0"));
                        table.Cell().Padding(5).Text(item.Total.ToString("N0"));
                    }
                });

                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ຍອດລວມ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.Subtotal:N0}").Bold();
                });
                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ມັດຈຳ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.DepositAmount:N0}").Bold();
                });
                column.Item().AlignRight().Row(row =>
                {
                    row.RelativeItem().AlignRight().PaddingTop(10).Text("ຍອດລວມສຸດທິ:").Bold();
                    row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{_model.TotalAmount:N0}").Bold();
                });
                column.Item().AlignRight().Row(row =>
                {
                    column.Item().AlignRight().Row(row =>
                    {
                        if (_document == DocumentType.Receipt)
                        {
                            row.RelativeItem().AlignRight().PaddingTop(10).Text("ຈຳນວນຊຳລະ:").Bold();
                        }
                        else
                        {
                            row.RelativeItem().AlignRight().PaddingTop(10).Text("ຈຳນວນຕ້ອງຊຳລະ:").Bold();
                        }
                        row.ConstantItem(120).AlignRight().PaddingTop(10).Text($"{(_model.TotalAmount - _model.DepositAmount):N0}").Bold();
                    });
                });
            });
        }
    }
}
