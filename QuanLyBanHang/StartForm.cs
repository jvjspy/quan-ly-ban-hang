using QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class StartForm : Form
    {
        AdminDAO adminDAO = new AdminDAO();
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void press_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }

        private void login()
        {
            error.Clear();
            if (txtName.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                var user = adminDAO.GetAdmin(txtName.Text);
                Cursor.Current = Cursors.Default;
                if (user == null)
                {
                    error.SetError(txtName, "Tài khoản không tồn tại!");
                }
                else if (user.Password != txtPass.Text)
                {
                    error.SetError(txtPass, "Mật khẩu không đúng!");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                error.SetError(txtName, "Tên tài khoản không được để trống!");
            }
            
        }
    }
}
