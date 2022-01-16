using Microsoft.Office.Interop.Excel;
using QuanLyBanHang.DAO;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.UI
{
    public partial class ProductForm : Form
    {
        private ProductDAO productDAO = new ProductDAO();
        private CategoryDAO categoryDAO = new CategoryDAO();
        BindingList<Product> sr = null;
        public ProductForm()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData(null);
        }

        private void LoadCombobox()
        {
            var ls = categoryDAO.GetCategories();
            ls.Insert(0, new Category { Id = -1, Name = "Tất cả" });
            cblmh.DataSource = ls;
            cblmh.DisplayMember = "Name";
            cblmh.ValueMember = "Id";
        }

        private void Number_Only(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileImg.Title = "Chọn file ảnh";
            openFileImg.Filter = "JPEG Image|*.jpg|All Files|*.*";
            DialogResult result = openFileImg.ShowDialog();
            if(result == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileImg.FileName);
                pictureBox1.Image = img;
                txt_name.Text =openFileImg.SafeFileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!valid()) return;
            Product add = new Product();
            add.Name = txt_name.Text;
            add.Unit = txt_unit.Text;
            add.Image = txtImg.Text;
            add.BuyPrice = int.Parse(txt_buy.Text);
            add.SellPrice = int.Parse(txt_sell.Text);
            add.Description = txt_desc.Text;
            add.Amount = int.Parse(txt_amount.Text);
            txt_amount.Enabled = false;
            add.CatId = (long?)cblmh.SelectedValue;
            if(openFileImg.SafeFileName != "openFileDialog1")
            pictureBox1.Image.Save(openFileImg.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            productDAO.AddProduct(add);
            LoadData(null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!valid()) return;
            Product edit = new Product();
            edit.Id = (long)dgv.CurrentRow.Cells["ID"].Value;
            edit.Name = txt_name.Text;
            edit.Unit = txt_unit.Text;
            edit.Image = txtImg.Text;
            edit.BuyPrice = int.Parse(txt_buy.Text);
            edit.SellPrice = int.Parse(txt_sell.Text);
            edit.Description = txt_desc.Text;
            edit.CatId = (long?)cblmh.SelectedValue;
            if (openFileImg.SafeFileName != "openFileDialog1")
            pictureBox1.Image.Save(openFileImg.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            productDAO.SaveProduct(edit);
            LoadData(null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Product search = new Product();
            search.Name = txt_name.Text;
            if (txt_amount.Text == "")
            {
                search.Amount = -1;
            }
            else
            {
                search.Amount = int.Parse(txt_amount.Text);
            }
            
            search.CatId = (long?)cblmh.SelectedValue;
            LoadData(search);
        }

        private void LoadData(Product fill)
        {
            
            sr = new BindingList<Product>(productDAO.GetListProduct(fill));
            dgv.DataSource = sr;
            
        }

        private void selectChange(object sender, EventArgs e)
        {
            var drr = dgv.CurrentRow;
            txtImg.Text = drr.Cells["Img"].Value.ToString();
            txt_amount.Text = drr.Cells["Amount"].Value.ToString();
            txt_buy.Text = drr.Cells["BuyPrice"].Value.ToString();
            txt_desc.Text = drr.Cells["Description"].Value.ToString();
            txt_name.Text = drr.Cells["NameP"].Value.ToString();
            txt_sell.Text = drr.Cells["SellPrice"].Value.ToString();
            txt_unit.Text = drr.Cells["Unit"].Value.ToString();
            cblmh.Text = drr.Cells["CatId"].Value.ToString();
            if(File.Exists(@"images\" + drr.Cells["Img"].Value.ToString()))
            {
                pictureBox1.Image = Image.FromFile(@"images\" + drr.Cells["Img"].Value.ToString());
            }
            
        }
        private bool valid()
        {
            error.Clear();
            bool val = true;
            if (String.IsNullOrEmpty(txt_name.Text))
            {
                error.SetError(txt_name,"Tên sản phẩm không được để trống");
                val = false;
            }
            if (String.IsNullOrEmpty(txt_amount.Text))
            {
                error.SetError(txt_amount, "Số lượng không được để trống");
                val = false;
            }
            if (String.IsNullOrEmpty(txt_buy.Text))
            {
                error.SetError(txt_buy, "Tên sản phẩm không được để trống");
                val = false;
            }
            if (String.IsNullOrEmpty(txt_sell.Text))
            {
                error.SetError(txt_sell, "Tên sản phẩm không được để trống");
                val = false;
            }
            return val;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var ids = new List<long>();
            foreach (DataGridViewRow r in dgv.SelectedRows)
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
                    productDAO.DeleteProduct(ids);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(null);
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
            cblmh.SelectedIndex = -1;
            txtImg.Text = "";
            txt_amount.Text = "";
            txt_amount.Enabled = true;
            txt_buy.Text = "";
            txt_desc.Text = "";
            txt_name.Text = "";
            txt_sell.Text = "";
            txt_unit.Text = "";
            pictureBox1.Image = null;
            LoadData(null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add();
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Danh sách";
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 9]].Merge();
            worksheet.Cells[1, 1] = "Danh sách sản phẩm";
            worksheet.Cells[1, 1].EntireRow.Font.Bold = true;
            worksheet.Cells[1, 1].EntireRow.Font.Size = 20;
            worksheet.Range["A1", "I1"].Borders.LineStyle = XlLineStyle.xlContinuous;
            var list = categoryDAO.GetCategories().Select(x => x.Name).ToArray();
           
            var cell = (Microsoft.Office.Interop.Excel.Range)worksheet.Range["B3", "B1000"];
            cell.Validation.Delete();
            cell.Validation.Add(
               XlDVType.xlValidateList,
               XlDVAlertStyle.xlValidAlertInformation,
               XlFormatConditionOperator.xlEqual,
               String.Join(";",list));
            cell.Validation.IgnoreBlank = true;
            cell.Validation.InCellDropdown = true;
            // storing header part in Excel  
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[2, i] = dgv.Columns[i - 1].HeaderText;
                worksheet.Cells[2, i].EntireRow.Font.Bold = true;
                worksheet.Cells[2, i].Borders.LineStyle = XlLineStyle.xlContinuous;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    
                    worksheet.Cells[i+3, j+1].Borders.LineStyle = XlLineStyle.xlContinuous;
                }
            }
            worksheet.Columns.AutoFit();
            app.Visible=true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            new ProductImportExcelForm().Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
