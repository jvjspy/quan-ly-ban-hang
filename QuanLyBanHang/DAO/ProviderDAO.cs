using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
    class ProviderDAO
    {
		private readonly DBContext db = new DBContext();
		public Provider GetProviderById(long id)
		{
			return db.Providers.Find(id);
		}
		public List<Provider> GetProviders()
		{
			return db.Providers.ToList();
		}
		public void AddProvider(Provider pr)
		{
			db.Providers.Add(pr);
			db.SaveChanges();
		}

		public void SaveProvider(Provider pr)
		{
			Provider provider = db.Providers.FirstOrDefault(i => i.Id == pr.Id);
			provider.Name = pr.Name;
			provider.Address = pr.Address;
			provider.PhoneNumber = pr.PhoneNumber;
			provider.Email = pr.Email;
			
			db.SaveChanges();
		}
		public void DeleteProvider(List<long> ids)
		{
			db.Providers.RemoveRange(db.Providers.Where(i => ids.Contains(i.Id)));
			db.SaveChanges();
		}

		public List<Provider> GetListProvider(Provider fill)
		{
			if (fill == null)
			{
				var list = from pr in db.Providers
						   select pr;
				return list.ToList();
			}
			else
			{
				var list = from pr in db.Providers
						   where pr.Name.Contains(fill.Name) &&
							pr.Email.Contains(fill.Email) && pr.PhoneNumber.Contains(fill.PhoneNumber) &&
							pr.Email.Contains(fill.Email)
						   select pr;
				return list.ToList();
			}
		}
	}
}
