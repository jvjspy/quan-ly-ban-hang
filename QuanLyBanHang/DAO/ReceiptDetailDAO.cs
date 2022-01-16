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

        public List<ReceiptDetail> GetAll(long id) {
            return db.ReceiptDetails.Where(i => i.RecId == id).ToList();
        }

    }
}
