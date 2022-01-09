using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
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
            List<Product> list = new List<Product>();
			if (fill == null)
			{
				list = db.Products
				.ToList();
			}
			else
			{
				list = db.Products.Where(i => i.Name.Contains(fill.Name) &&
				(fill.Amount >= i.Amount || fill.Amount ==-1) && (fill.CatId == i.CatId || fill.CatId == -1)
				).ToList();
			}
		
			return list;
        }
		public void SaveUpload(List<Product> ls)
        {
            foreach (var item in ls)
            {
				if(item.Id == 0)
                {
					db.Products.Add(item);
                }
                else
                {
					Product product = db.Products.FirstOrDefault(i => i.Id == item.Id);
					product.Name = item.Name;
					product.Description = item.Description;
					product.CatId = categoryDAO.GetCategoriesByName(item.Category.Name).Id;
					product.BuyPrice = item.BuyPrice;
					product.SellPrice = item.SellPrice;
					product.Amount += item.Amount;
					if (item.Image == "")
					{
						product.Image = item.Image;
					}
				}
            }
			db.SaveChanges();
        }
	}
}
