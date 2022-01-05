using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Utils
{
	class InvoicePrinter
	{
		private const string COMPANY_NAME = "Công ty TNHH Nhóm 1";
		private const string ADDRESS = "Bắc Từ Liêm, TP.Hà Nội";
		private const string PHONE_NUMBER = "0393417020";
		private const string EMAIL = "ngochung1762@gmail.com";
		private Document doc;
		private readonly PdfFont regular,bold,italic;
		public InvoicePrinter()
		{
			regular = PdfFontFactory.CreateFont(@"fonts\Montserrat-Regular.ttf");
			bold = PdfFontFactory.CreateFont(@"fonts\Montserrat-Bold.ttf");
			italic = PdfFontFactory.CreateFont(@"fonts\Montserrat-Italic.ttf");
		}
		public void PrintToFile(string fileName,Invoice inv)
		{
			var pdf = new PdfWriter(fileName);
			var pdfDoc = new PdfDocument(pdf);
			doc = new Document(pdfDoc);
			doc.SetFont(regular);
			doc.SetFontSize(13);
			PrintHeader();
			PrintCommonSection(inv);
			PrintInvoiceDetailsTable(inv);
			PrintFooter();
			doc.Close();
		}
		private void PrintHeader()
		{
			var tb = new Table(2,false);
			tb.SetWidth(UnitValue.CreatePercentValue(100));
			var logo = new Image(ImageDataFactory.Create(@"images\logo.png"));
			tb.AddCell(new Cell().Add(logo).SetBorder(Border.NO_BORDER));
			var companyInfo = new Cell();
			companyInfo.Add(new Paragraph(COMPANY_NAME).SetFontSize(14).SetFont(bold).SetTextAlignment(TextAlignment.RIGHT));
			companyInfo.Add(new Paragraph().SetTextAlignment(TextAlignment.RIGHT).Add(new Text("Địa chỉ: ").SetFont(bold)).Add(new Text(ADDRESS)));
			companyInfo.Add(new Paragraph().SetTextAlignment(TextAlignment.RIGHT).Add(new Text("Số điện thoại: ").SetFont(bold)).Add(new Text(PHONE_NUMBER)));
			companyInfo.Add(new Paragraph().SetTextAlignment(TextAlignment.RIGHT).Add(new Text("Email: ").SetFont(bold)).Add(new Text(EMAIL)));
			tb.AddCell(companyInfo.SetBorder(Border.NO_BORDER));
			doc.Add(tb);
			doc.Add(new Paragraph("HÓA ĐƠN BÁN HÀNG").SetFont(bold).SetFontSize(18).SetTextAlignment(TextAlignment.CENTER));
		}
		private void PrintCommonSection(Invoice inv)
		{
			doc.Add(new Paragraph().Add("Số hóa đơn: ").Add(inv.Id.ToString()));
			doc.Add(new Paragraph().Add("Ngày bán: ").Add(inv.InvDate.ToShortDateString()));
			doc.Add(new Paragraph().Add("Khách hàng: ").Add(inv.CusName));
			doc.Add(new Paragraph().Add("Nhân viên: ").Add(inv.Seller));
			doc.Add(new Paragraph().Add("Ghi chú: ").Add(inv.Notes));
		}
		private void PrintInvoiceDetailsTable(Invoice inv)
		{
			var tb = new Table(7, false);
			tb.SetHorizontalAlignment(HorizontalAlignment.CENTER);
			tb.SetFontSize(11);
			tb.SetWidth(UnitValue.CreatePercentValue(100));
			tb.AddHeaderCell(new Cell().Add(new Paragraph("STT").SetFont(bold).SetTextAlignment(TextAlignment.RIGHT)));
			tb.AddHeaderCell(new Cell().Add(new Paragraph("Mã SP").SetFont(bold)));
			tb.AddHeaderCell(new Cell().Add(new Paragraph("Tên SP").SetFont(bold)));
			tb.AddHeaderCell(new Cell().Add(new Paragraph("SL").SetFont(bold).SetTextAlignment(TextAlignment.RIGHT)));
			tb.AddHeaderCell(new Cell().Add(new Paragraph("ĐVT").SetFont(bold)));
			tb.AddHeaderCell(new Cell().Add(new Paragraph("Đơn giá").SetFont(bold).SetTextAlignment(TextAlignment.RIGHT)));
			tb.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(bold).SetTextAlignment(TextAlignment.RIGHT)));
			var details = inv.InvoiceDetails.ToList();
			for(int i = 0; i < details.Count; i++)
			{
				var detail = details[i];
				tb.AddCell(new Cell().Add(new Paragraph((i + 1).ToString()).SetTextAlignment(TextAlignment.RIGHT)));
				tb.AddCell(new Cell().Add(new Paragraph(detail.ProdId.ToString())));
				tb.AddCell(new Cell().Add(new Paragraph(detail.Product.Name)));
				tb.AddCell(new Cell().Add(new Paragraph($"{detail.Amount:n0}").SetTextAlignment(TextAlignment.RIGHT)));
				tb.AddCell(new Cell().Add(new Paragraph($"{detail.Product.Unit}")));
				tb.AddCell(new Cell().Add(new Paragraph($"{detail.Price:n0} đ").SetTextAlignment(TextAlignment.RIGHT)));
				tb.AddCell(new Cell().Add(new Paragraph($"{detail.DetailSum:n0} đ").SetTextAlignment(TextAlignment.RIGHT)));
			}
			tb.AddCell(new Cell(1, 6).Add(new Paragraph("Tổng cộng").SetTextAlignment(TextAlignment.CENTER)));
			tb.AddCell(new Cell().Add(new Paragraph($"{inv.InvSum:n0} đ")));
			doc.Add(tb);
		}
		private void PrintFooter()
		{
			var tb = new Table(2, false);
			tb.SetFontSize(9);
			tb.SetWidth(UnitValue.CreatePercentValue(100));
			var now = DateTime.Now.ToString("G");
			tb.AddCell(new Cell().Add(new Paragraph(now).SetFont(italic)).SetBorder(Border.NO_BORDER));
			tb.AddCell(new Cell().Add(new Paragraph("Hóa đơn được tạo tự động bởi phần mềm QLBH Nhóm 1").SetFont(italic).SetTextAlignment(TextAlignment.RIGHT)).SetBorder(Border.NO_BORDER));
			doc.Add(tb);
		}
	}
}
