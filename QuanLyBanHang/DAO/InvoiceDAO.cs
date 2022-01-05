using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
	class InvoiceSearch
	{
		public long? Id { get; set; }
		public string CusName { get; set; }
		public DateTime? FromDate { get; set; } = null;
		public DateTime? ToDate { get; set; } = null;
	}
	class InvoiceDAO
	{
		private readonly DBContext db = new DBContext();
		public InvoiceDAO()
		{
			db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
		}
		public Invoice CreateInvoice(Invoice dto)
		{
			var newInv = db.Invoices.Add(new Invoice
			{
				CusName = dto.CusName,
				InvDate = dto.InvDate,
				Notes = dto.Notes,
				Seller = dto.Seller,
				InvoiceDetails = dto.InvoiceDetails.Select(id => new InvoiceDetail
				{
					ProdId = id.ProdId,
					Amount = id.Amount,
					Price = id.Price,
				}).ToList()
			});
			foreach(var detail in dto.InvoiceDetails)
			{
				db.Products.Find(detail.ProdId).Amount -= detail.Amount;
			}
			db.SaveChanges();
			return newInv;
		}
		//public void UpdateInvoice(Invoice dto)
		//{
		//	var inv = GetInvoiceById(dto.Id);
		//	inv.CusName = dto.CusName;
		//	inv.InvDate = dto.InvDate;
		//	inv.Seller = dto.Seller;
		//	inv.Notes = dto.Notes;
		//	var details = db.InvoiceDetails.RemoveRange(inv.InvoiceDetails);
		//	TriggerRemoveInvoiceDetails(details);
		//	details = db.InvoiceDetails.AddRange(dto.InvoiceDetails.Select(id => new InvoiceDetail
		//	{
		//		InvId = inv.Id,
		//		ProdId = id.ProdId,
		//		Amount = id.Amount,
		//		Price = id.Price
		//	}));
		//	TriggerAddInvoiceDetails(details);
		//	db.SaveChanges();
		//}
		public Invoice GetInvoiceById(long id)
		{
			return db.Invoices.Include("InvoiceDetails.Product").FirstOrDefault(i => i.Id == id);
		}
		public List<Invoice> GetInvoicesList()
		{
			return db.Invoices.Include("InvoiceDetails").AsNoTracking().OrderByDescending(i=>i.InvDate).ToList();
		}
		public List<Invoice> SearchInvoices(InvoiceSearch invSearch)
		{
			var invs = db.Invoices.Include("InvoiceDetails").AsNoTracking().AsQueryable();
			if (invSearch.Id.HasValue)
			{
				invs = invs.Where(i => i.Id == invSearch.Id);
			}
			if (!string.IsNullOrEmpty(invSearch.CusName))
			{
				invs = invs.Where(i => i.CusName.ToLower().Contains(invSearch.CusName.ToLower()));
			}
			if (invSearch.FromDate.HasValue && invSearch.ToDate.HasValue)
			{
				invs = invs.Where(i => invSearch.FromDate <= i.InvDate && i.InvDate <= invSearch.ToDate);
			}
			return invs.ToList();
		}
		public void DeleteInvoices(List<long> ids)
		{
			db.Invoices.RemoveRange(db.Invoices.Where(i => ids.Contains(i.Id)));
			db.SaveChanges();
		}
	}
}
