﻿using QuanLyBanHang.DAO;
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
    public partial class ReciptForm : Form
    {
        private ReceiptDAO peciptDAO = new ReceiptDAO();
        private ProviderDAO providerDAO = new ProviderDAO();
        public ReciptForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            LoadCNN();
            loaddata(null);
        }
        private void LoadCNN()
        {
            var ls = providerDAO.GetProviders();
            ls.Insert(0, new Provider { Id = -1, Name = "Tất cả" });
            cbxNCC.DataSource = ls;
            cbxNCC.DisplayMember = "Name";
            cbxNCC.ValueMember = "Id";
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            int mbl; 
            if(int.TryParse(txtMaBienLai.Text, out mbl))
            {
                new ProviderImportProductForm(mbl).Show();
                this.Close();
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMaBienLai, "Nhập mã biên lai");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ProviderImportProductForm().Show();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int mbl;
            if (int.TryParse(txtMaBienLai.Text, out mbl))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập " + mbl, "Thông báo", MessageBoxButtons.OKCancel);
                if(dr == DialogResult.OK)
                {
                    peciptDAO.DeleteById(mbl);
                    loaddata(null);
                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMaBienLai, "Nhập mã biên lai");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            int mbi;
            int.TryParse(txtMaBienLai.Text,out mbi);
            receipt.Id = mbi;
            receipt.ProvId = (long)cbxNCC.SelectedValue;
            loaddata(receipt);
        }
        private void loaddata(Receipt recipt)
        {
            dataGridView1.DataSource = peciptDAO.GetAllBy(recipt);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = "";
            txtMaBienLai.Text = "";
            txtNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxNCC.SelectedIndex = 0;
            loaddata(null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            var dr = dataGridView1.CurrentRow;
            txtGhiChu.Text = dr.Cells["Notes"].Value.ToString();
            txtMaBienLai.Text = dr.Cells["RecId"].Value.ToString();
            txtNgayTao.Text = dr.Cells["RecDate"].Value.ToString();
            cbxNCC.SelectedValue = dr.Cells["Provid"].Value;
        }
    }
}
