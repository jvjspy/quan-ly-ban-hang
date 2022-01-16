using QuanLyBanHang.DAO;
using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.UI
{
    public partial class ProviderImportProductForm : Form
    {
        private ProviderDAO providerDAO = new ProviderDAO();
        private ProductDAO productDAO = new ProductDAO();
        private ReceiptDAO receiptDAO = new ReceiptDAO();
        private ReceiptDetailDAO ReceiptDetail = new ReceiptDetailDAO();
        public ProviderImportProductForm()
        {
            InitializeComponent();
        }

        private void ProviderImportProductForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            txtNgayTao.Value = DateTime.Now.Date;
        }

        private void LoadCombobox()
        {
            var ls = providerDAO.GetProviders();
            ls.Insert(0, new Provider { Id = -1, Name = "Tất cả" });
            cbxNCC.DataSource = ls;
            cbxNCC.DisplayMember = "Name";
            cbxNCC.ValueMember = "Id";
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có chắc muốn nhập hàng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    Receipt add = new Receipt();
                    add.ProvId = (long)cbxNCC.SelectedValue;
                    add.RecDate = txtNgayTao.Value;
                    add.Notes = txtGhiChu.Text;

                    ReceiptDetail add2 = new ReceiptDetail();
                    add2.ProdId = long.Parse(txtMaHang.Text);
                    add2.RecId = long.Parse(txtMaBienLai.Text);
                    add2.Amount = Int32.Parse(txtSoLuong.Text);
                    add2.Price = Int32.Parse(txtDonGia.Text);
                    ReceiptDetail.AddReceiptDetail(add2);

                    receiptDAO.AddRececipt(add);
                   
                    MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    //MessageBox.Show("Có lỗi xảy ra trong khi nhập hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
