using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
	enum ReportBy
	{
		MONTH, YEAR
	}
	class TopProduct
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public int Amount { get; set; }
		public int Price { get; set; }
		public int Count { get; set; }
	}
	class ReportDAO
	{
		private readonly DBContext db = new DBContext();
		public (int invCount, int profit, int prodCount, int inventory) GetNumericReport()
		{
			var invCount = db.Invoices.Count();
			var cost = db.Receipts.Include("ReceiptDetails").AsEnumerable().Sum(r => r.RecSum);
			var revenue = db.Invoices.Include("InvoiceDetails").AsEnumerable().Sum(i => i.InvSum);
			var profit = revenue - cost;
			var prodCount = db.Products.Count();
			var inventory = db.Products.Sum(p => p.Amount * p.BuyPrice);
			return (invCount, profit, prodCount, inventory);
		}
		public (int[] revenue,int[] cost,int[] profit) GetChartReport(ReportBy by)
		{
			if (by == ReportBy.MONTH)
			{
				return GetChartReportInMonth();
			}
			return GetChartReportInYear();
		}
		private (int[],int[],int[]) GetChartReportInMonth()
		{
			var today = DateTime.Now;
			var dayCount = DateTime.DaysInMonth(today.Year, today.Month);
			var revenue = (from inv in db.Invoices.Include("InvoiceDetails").AsEnumerable() where inv.InvDate.Year == today.Year && inv.InvDate.Month == today.Month group inv by inv.InvDate into days select new { day = days.Key.Day, revenue = days.Sum(inv => inv.InvSum) });
			var revenueInMonth = new int[dayCount];
			revenue.ToList().ForEach(r =>
			{
				revenueInMonth[r.day - 1] = r.revenue;
			});
			var cost = (from rec in db.Receipts.Include("ReceiptDetails").AsEnumerable() where rec.RecDate.Year == today.Year && rec.RecDate.Month == today.Month group rec by rec.RecDate into days select new { day = days.Key.Day, cost = days.Sum(r => r.RecSum) });
			var costInMonth = new int[dayCount];
			cost.ToList().ForEach(c =>
			{
				costInMonth[c.day - 1] = c.cost;
			});
			var profitInMonth = revenueInMonth.Zip(costInMonth, (r, c) => r-c).ToArray();
			return (revenueInMonth, costInMonth, profitInMonth);
		}
		private (int[], int[], int[]) GetChartReportInYear()
		{
			var today = DateTime.Now;
			var revenue = (from inv in db.Invoices.Include("InvoiceDetails").AsEnumerable() where inv.InvDate.Year == today.Year group inv by inv.InvDate.Month into months select new { month = months.Key, revenue = months.Sum(inv => inv.InvSum) });
			var revenueInYear = new int[12];
			revenue.ToList().ForEach(r =>
			{
				revenueInYear[r.month - 1] = r.revenue;
			});
			var cost = (from rec in db.Receipts.Include("ReceiptDetails").AsEnumerable() where rec.RecDate.Year == today.Year group rec by rec.RecDate.Month into months select new { month = months.Key, cost = months.Sum(r => r.RecSum) });
			var costInYear = new int[12];
			cost.ToList().ForEach(c =>
			{
				costInYear[c.month - 1] = c.cost;
			});
			var profitInYear = revenueInYear.Zip(costInYear, (r, c) => r - c).ToArray();
			return (revenueInYear, costInYear, profitInYear);
		}
		public List<TopProduct> GetTopProducts()
		{
			return (from p in db.Products.Include("InvoiceDetails").AsNoTracking().AsEnumerable() select new { p, count = p.InvoiceDetails.Sum(id => id.Amount) } into prods orderby prods.count descending select new TopProduct { Id=prods.p.Id,Name=prods.p.Name,Amount=prods.p.Amount,Price=prods.p.SellPrice,Count=prods.count}).Take(30).ToList();
		}
	}
}
