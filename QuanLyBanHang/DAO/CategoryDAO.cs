using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
	class CategoryDAO
	{
		private readonly DBContext db = new DBContext();
		public List<Category> GetCategories()
		{
			return db.Categories.ToList();
		}
		public List<Product> GetProductsInCategory(long id)
		{
			if (id < 0)
			{
				return db.Products.AsNoTracking().ToList();
			}
			return db.Products.AsNoTracking().Where(p => p.CatId == id).ToList();
		}
		public List<Product> SearchProductsInCategory(long id,string text)
		{
			return GetProductsInCategory(id).Where(p => p.Name.ToLower().Contains(text.ToLower())).ToList();
		}
	}
}
