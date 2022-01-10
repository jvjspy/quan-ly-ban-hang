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


		public void addCategory(Category category)
        {
			db.Categories.Add(category);
			db.SaveChanges();
        }
		public void saveCategory(Category category)
        {
			Category edit = db.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (edit != null)
            {
				edit.Name = category.Name;
				edit.Description = category.Description;
            }
			db.SaveChanges();
        }

		public Category GetCategoriesById(long id)
		{
			return db.Categories.SingleOrDefault(i => i.Id == id);
		}
		public Category GetCategoriesByName(string text)
        {
			return db.Categories.SingleOrDefault(i => i.Name == text);
        }

		public void DeleteCategories(List<long> ids)
        {
			db.Categories.RemoveRange(db.Categories.Where(i => ids.Contains(i.Id)));
			db.SaveChanges();
		}

        public List<Category> FindCategoryByName(string text)
        {
            return db.Categories
				.Where(i => i.Name.Contains(text))
				.ToList();
        }
    }
}
