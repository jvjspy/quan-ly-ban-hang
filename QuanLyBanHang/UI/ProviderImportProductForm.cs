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
        BindingList<ReceiptDetail> gdvdata = new BindingList<ReceiptDetail>();
        public ProviderImportProductForm()
        {
            InitializeComponent();
            
        }

        public ProviderImportProductForm(int mbl)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            txtDonGia.Enabled = false;
            txtGhiChu.Enabled = false;
            txtNgayTao.Enabled = false;
            txtSoLuong.Enabled = false;
            cbxNCC.Enabled = false;
            cbxProduct.Enabled = false;
            txtMaBienLai.Text = ""+mbl;
            Receipt re =  receiptDAO.GetByID(mbl);
            txtGhiChu.Text = re.Notes;
            cbxNCC.SelectedValue = re.ProvId;
            txtNgayTao.Value = re.RecDate;
            dataGridView1.DataSource = ReceiptDetail.GetAll(mbl);
            btn_Them.Enabled = false;
            btn_xoa.Enabled = false;
            btnRefresh.Enabled = false;
            btnNhapHang.Enabled = false;
            
        }

        private void ProviderImportProductForm_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadProduct();
            txtNgayTao.Value = DateTime.Now.Date;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void LoadCombobox()
        {
            var ls = providerDAO.GetProviders();
            cbxNCC.DataSource = ls;
            cbxNCC.DisplayMember = "Name";
            cbxNCC.ValueMember = "Id";
        }
        private void LoadProduct()
        {
            var ls = productDAO.GetListProduct(null);
            cbxProduct.DataSource = ls;
            cbxProduct.DisplayMember = "Name";
            cbxProduct.ValueMember = "Id";
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
           if(gdvdata.Count > 0)
            {
                try
                {
                    Receipt receipt = new Receipt();
                    receipt.ProvId = (long)cbxNCC.SelectedValue;
                    receipt.RecDate = txtNgayTao.Value;
                    receipt.Notes = txtGhiChu.Text;
                    receipt.ReceiptDetails = gdvdata;
                    productDAO.NhapHang(gdvdata.ToList());
                    receiptDAO.AddRececipt(receipt);
                    DialogResult dr = MessageBox.Show("Nhập hàng thành công", "Thông báo",MessageBoxButtons.OK);
                    if(dr == DialogResult.OK)
                    {
                        ReciptForm frm = new ReciptForm();
                        frm.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra!! \n"+ex.Message, "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Biên lai không được để trống", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gdvdata.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!valid()) return;
            ReceiptDetail add = new ReceiptDetail();
            add.ProdId = (long)cbxProduct.SelectedValue;
            add.Amount = int.Parse(txtSoLuong.Text);
            add.Price = int.Parse(txtDonGia.Text);
            gdvdata.Add(add);
            dataGridView1.DataSource = gdvdata;
        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            var dr = dataGridView1.CurrentRow;
            cbxProduct.SelectedValue = dr.Cells[0].Value;
            txtDonGia.Text =dr.Cells[3].Value.ToString();
            txtSoLuong.Text = dr.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReciptForm frm = new ReciptForm();
            frm.Show();
            this.Close();
        }

        private bool valid()
        {
            error.Clear();
            bool val = true;
            if (String.IsNullOrEmpty(txtDonGia.Text))
            {
                error.SetError(txtDonGia, "Đơn giá không được để trống");
                val = false;
            }
            if (String.IsNullOrEmpty(txtSoLuong.Text))
            {
                error.SetError(txtSoLuong, "Số lượng không được để trống");
                val = false;
            }

            return val;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
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

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            txtDonGia.Text = "";
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
