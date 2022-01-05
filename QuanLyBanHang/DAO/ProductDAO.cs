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
		private readonly DBContext db = new DBContext();
		public Product GetProductById(long id)
		{
			return db.Products.Find(id);
		}
	}
}
