using Microsoft.Office.Interop.Excel;
using QuanLyBanHang.DAO;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.UI
{
    public partial class ProductImportExcelForm : Form
    {
        ProductDAO productDAO = new ProductDAO();
        CategoryDAO categoryDAO = new CategoryDAO();
        public ProductImportExcelForm()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
        }

        public BindingList<Product> ReadExcel(string filePath)
        {
            BindingList<Product> products = new BindingList<Product>();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            try
            {
                for (int i = 3; i <= rowCount; i++)
                {
                    Product product = new Product();
                    Category ca = categoryDAO.GetCategoriesByName(xlRange.Cells[i, 1].Value2);
                    product.Id = 0;
                    product.Category = ca;
                    product.CatId = ca.Id;
                    product.Name = xlRange.Cells[i, 2].Value2.ToString();
                    product.Unit = xlRange.Cells[i, 3].Value2.ToString();
                    product.SellPrice = (int)xlRange.Cells[i, 4].Value2;
                    product.BuyPrice = (int)xlRange.Cells[i, 5].Value2;
                    product.Description = xlRange.Cells[i, 6].Value2;
                    product.Amount = (int)xlRange.Cells[i, 7].Value2;
                    product.Image = xlRange.Cells[i, 8].Value2.ToString();
                    products.Add(product);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(null,"Bạn cần xem lại file đã chọn. Có lỗi sảy ra trong quá trình đọc file!","Thông báo",MessageBoxButtons.OK);

            }finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:  
                //  never use two dots, all COM objects must be referenced and released individually  
                //  ex: [somthing].[something].[something] is bad  

                //release com objects to fully kill excel process from running in the background  
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            
            return products;
            
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {

                filePath = file.FileName; //get the path of the file  
                Cursor.Current = Cursors.WaitCursor;
                dgv.DataSource =  ReadExcel(filePath);
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> ls = (dgv.DataSource as BindingList<Product>).ToList();
                Cursor.Current = Cursors.WaitCursor;
                productDAO.SaveUpload(ls);
                Cursor.Current = Cursors.Default;
                var dr =  MessageBox.Show("Nhập file thành công! \nBạn có muốn trở lại màn hình quản lý sản phẩm","Thông báo",MessageBoxButtons.OKCancel);
                if(dr == DialogResult.OK)
                {
                    new ProductForm().Show();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi trong quá trình lưu file", "Thông báo");
                
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
            this.Close();
        }

        private void btnGetExcel(object sender, EventArgs e)
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
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 8]].Merge();
            worksheet.Cells[1, 1] = "Danh sách sản phẩm";
            worksheet.Cells[1, 1].EntireRow.Font.Bold = true;
            worksheet.Cells[1, 1].EntireRow.Font.Size = 20;
            worksheet.Range["A1", "H1"].Borders.LineStyle = XlLineStyle.xlContinuous;
            var list = categoryDAO.GetCategories().Select(x => x.Name).ToArray();

            var cell = (Microsoft.Office.Interop.Excel.Range)worksheet.Range["A3", "A1000"];
            cell.Validation.Delete();
            cell.Validation.Add(
               XlDVType.xlValidateList,
               XlDVAlertStyle.xlValidAlertInformation,
               XlFormatConditionOperator.xlEqual,
               String.Join(";", list));
            cell.Validation.IgnoreBlank = true;
            cell.Validation.InCellDropdown = true;
            // storing header part in Excel  
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[2, i] = dgv.Columns[i - 1].HeaderText;
                worksheet.Cells[2, i].EntireRow.Font.Bold = true;
                worksheet.Cells[2, i].Borders.LineStyle = XlLineStyle.xlContinuous;
            }
            worksheet.Columns.AutoFit();
            app.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cell_Double_To_Del(object sender, DataGridViewCellEventArgs e)
        {
            
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + dgv.Rows[e.RowIndex].Cells["NameP"].Value.ToString(), "Thông báo", MessageBoxButtons.OKCancel);
            if(rs == DialogResult.OK)
            {
                var ls = (dgv.DataSource as BindingList<Product>);
                ls.RemoveAt(e.RowIndex);
                ls.ResetBindings();
            }
        }
    }
}