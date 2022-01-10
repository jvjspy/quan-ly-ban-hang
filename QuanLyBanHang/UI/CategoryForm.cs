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
    public partial class CategoryForm : Form
    {
        private CategoryDAO categoryDAO = new CategoryDAO();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void Loaddata()
        {
            dgv_lmh.DataSource = categoryDAO.GetCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateCategory(0,"ADD")) return;
            try
            {
                categoryDAO.addCategory(new Category { Name = txt_name.Text , Description =txt_desc.Text });
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loaddata();
        }

		private bool ValidateCategory(long id,string action)
		{
			error.Clear();
			bool valid = true;
			if (string.IsNullOrEmpty(txt_name.Text))
			{
				error.SetError(txt_name, "Tên loại hàng không được để trống!");
				valid = false;
			}
            else if(action == "ADD")
            {
                if(categoryDAO.GetCategoriesByName(txt_name.Text) != null)
                {
                    error.SetError(txt_name, "Tên loại hàng đã tồn tại!");
                    valid = false;
                }
            }else if(action == "EDIT")
            {
                var temp = categoryDAO.GetCategoriesByName(txt_name.Text);
                if (temp != null && id != temp.Id)
                {
                    error.SetError(txt_name, "Trùng tên hàng!");
                    valid = false;
                }
            }
			return valid;
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
            long id = (long)dgv_lmh.CurrentRow.Cells["ID"].Value;
            if (!ValidateCategory(id,"EDIT")) return;
            try
            {
                
                categoryDAO.saveCategory(new Category {
                    Id = id,
                    Name = txt_name.Text,
                    Description = txt_desc.Text }) ;
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loaddata();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dgv_lmh.AutoGenerateColumns = false;
            Loaddata();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var ids = new List<long>();
            foreach (DataGridViewRow r in dgv_lmh.SelectedRows)
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
                    categoryDAO.DeleteCategories(ids);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loaddata();
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra trong khi xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Loaddata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dr = dgv_lmh.CurrentRow;
            txt_name.Text = dr.Cells["NameLmh"].Value.ToString();
            txt_desc.Text = dr.Cells["Description"].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv_lmh.DataSource = categoryDAO.FindCategoryByName(txt_name.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txt_desc.Text = "";
            txt_name.Text = "";
            Loaddata();
        }
    }
}
