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
    }
}
