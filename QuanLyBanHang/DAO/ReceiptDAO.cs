using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
    class ReceiptDAO
    {
        private readonly DBContext db = new DBContext();

        public void AddRececipt(Receipt re)
        {
            db.Receipts.Add(re);
            db.SaveChanges();
        }

        public Receipt GetByID(int id)
        {
            return db.Receipts.FirstOrDefault(i => i.Id == id);
        }

        public void DeleteById(int id)
        {
            db.ReceiptDetails.RemoveRange(db.ReceiptDetails.Where(i => id == i.RecId));
            db.Receipts.RemoveRange(db.Receipts.Where(i => id == i.Id));
            
            db.SaveChanges();  
        }

        public List<Receipt> GetAllBy(Receipt fill)
        {
            if(fill == null)
            {
                return db.Receipts.ToList();
            }
            else
            {
                var rs = from Receipt in db.Receipts
                         where (fill.ProvId == Receipt.ProvId || fill.ProvId == -1)
                         && (fill.Id == Receipt.Id || fill.Id == 0)
                         select Receipt;
                return rs.ToList();
            }
        }
    }
}
