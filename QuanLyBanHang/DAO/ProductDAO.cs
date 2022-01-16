using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
	class ProductDAO
	{
		private CategoryDAO categoryDAO = new CategoryDAO();
		private readonly DBContext db = new DBContext();
		public Product GetProductById(long id)
		{
			return db.Products.Find(id);
		}

		public void AddProduct(Product p)
        {
			db.Products.Add(p);
			db.SaveChanges();
        }

		public void SaveProduct(Product p)
        {
			Product product = db.Products.FirstOrDefault( i => i.Id == p.Id);
			product.Name = p.Name;
			product.Description = p.Description;
			product.CatId = p.CatId;
			product.BuyPrice = p.BuyPrice;
			product.SellPrice = p.SellPrice;
			product.Amount = p.Amount;
			if(p.Image == "")
            {
				product.Image = p.Image;
            }
			db.SaveChanges();
        }
		public void DeleteProduct(List<long> ids)
        {
			db.Products.RemoveRange(db.Products.Where(i => ids.Contains(i.Id)));
			db.SaveChanges();
		}
		public List<Product> GetListProduct(Product fill)
        {
			if (fill == null)
			{
				var list = from p in db.Products
						   select p;
				return list.ToList();
			}
			else
			{
				var list = from p in db.Products
						   where p.Name.Contains(fill.Name) &&
							(fill.Amount >= p.Amount || fill.Amount == -1) &&
							(fill.CatId == p.CatId || fill.CatId == -1)
						   select p;
				return list.ToList();
			}
        }
		public void SaveUpload(List<Product> ls)
		{ 
            foreach (var item in ls)
            {
				if(item.Id == 0)
                {
					item.Category = null;
					db.Products.Add(item);
                }
            }
			db.SaveChanges();
        }
	}
}
