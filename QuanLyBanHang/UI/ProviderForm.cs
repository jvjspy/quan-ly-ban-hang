using Microsoft.Office.Interop.Excel;
using QuanLyBanHang.DAO;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.UI
{
    public partial class ProviderForm : Form
    {
        private ProviderDAO providerDAO = new ProviderDAO();

        BindingList<Provider> sr = null;
        public ProviderForm()
        {
            InitializeComponent();
            dataProvider.AutoGenerateColumns = false;
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void LoadData(Provider fill)
        {
            sr = new BindingList<Provider>(providerDAO.GetListProvider(fill));
            dataProvider.DataSource = sr;
        }

        private void selectChange(object sender, EventArgs e)
        {
            var drr = dataProvider.CurrentRow;
            txtName.Text = drr.Cells["NameNCC"].Value.ToString();
            txtEmail.Text = drr.Cells["Email"].Value.ToString();
            txtAddress.Text = drr.Cells["Address"].Value.ToString();
            txtPhone.Text = drr.Cells["PhoneNumber"].Value.ToString();
        }
        private bool valid()
        {
            error.Clear();
            bool val = true;
            if (String.IsNullOrEmpty(txtName.Text))
            {
                error.SetError(txtName, "Tên nhà cung cấp không được để trống");
                val = false;
            }

            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                error.SetError(txtAddress, "Địa chỉ nhà cung cấp không được để trống");
                val = false;
            }

            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                error.SetError(txtPhone, "Số điện thoại nhà cung cấp không được để trống");
                val = false;
            }

            if (!IsValidPhoneNumber(txtPhone.Text.ToString()))
            {
                error.SetError(txtPhone, "Số điện thoại không hợp lệ");
                val = false;
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                error.SetError(txtEmail, "Email nhà cung cấp không được để trống");
                val = false;
            }
            
            if (!IsValidEmail(txtEmail.Text.ToString()))
            {
                error.SetError(txtEmail, "Email không đúng định dạng");
                val = false;
            }
            
            return val;
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!valid()) return;
            
            if (MessageBox.Show($"Bạn có chắc muốn thêm nhà cung cấp?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    Provider add = new Provider();
                    add.Name = txtName.Text;
                    add.Address = txtAddress.Text;
                    add.PhoneNumber = txtPhone.Text;
                    add.Email = txtEmail.Text;

                    providerDAO.AddProvider(add);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(null);
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra trong khi sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!valid()) return;

            if (MessageBox.Show($"Bạn có chắc muốn sửa bản ghi này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    Provider edit = new Provider();
                    edit.Id = (long)dataProvider.CurrentRow.Cells["ID"].Value;
                    edit.Name = txtName.Text;
                    edit.Address = txtAddress.Text;
                    edit.PhoneNumber = txtPhone.Text;
                    edit.Email = txtEmail.Text;
                    providerDAO.SaveProvider(edit);
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra trong khi sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var ids = new List<long>();
            foreach (DataGridViewRow r in dataProvider.SelectedRows)
            {
                ids.Add(Convert.ToInt64(r.Cells["Id"].Value));
            }
            if (ids.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một bản ghi để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show($"Bạn có chắc muốn xóa {ids.Count} bản ghi này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    providerDAO.DeleteProvider(ids);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra trong khi xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData(null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

            LoadData(null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Danh sách nhà cung cấp";
            // storing header part in Excel  
            for (int i = 1; i < dataProvider.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataProvider.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataProvider.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataProvider.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataProvider.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\nhacungcap.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Provider search = new Provider();
            search.Address = txtAddress.Text;
            search.Name= txtName.Text;
            search.Email = txtEmail.Text;
            search.PhoneNumber = txtPhone.Text;

            LoadData(search);
        }

        public static bool IsValidPhoneNumber(string phone)
        {
            var phoneNumber = phone.Trim()
                .Replace(" ", "")
                .Replace("-", "")
                .Replace("(", "")
                .Replace(")", "");
            return Regex.Match(phoneNumber, @"^\+\d{5,15}$").Success;
        }
    }
}
