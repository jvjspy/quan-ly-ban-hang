using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Models;
namespace QuanLyBanHang.DAO
{
    public class AdminDAO
    {
        DBContext dbContext = new DBContext();

        public Admin GetAdmin(string UserName)
        {
            return dbContext.Admins.FirstOrDefault(i => i.Username == UserName);
        }
    }
}
