using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
    class ReceiptDetailDAO
    {
        private readonly DBContext db = new DBContext();

        public void AddReceiptDetail(ReceiptDetail red)
        {
            db.ReceiptDetails.Add(red);
            db.SaveChanges();
        }
    }
}
