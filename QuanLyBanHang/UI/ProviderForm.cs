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
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataProvider, saveFileDialog1.FileName);
            }
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý nhà cung cấp";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Provider search = new Provider();
            search.Address = txtAddress.Text;
            search.Name = txtName.Text;
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
            return Regex.Match(phoneNumber, "^(([0-9]|\\+)(\\d{9})|(\\d{11}))$").Success;
        }

        private void dataProvider_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new System.Drawing.Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

    }
}


    