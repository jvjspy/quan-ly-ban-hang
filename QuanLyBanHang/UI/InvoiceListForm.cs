using QuanLyBanHang.DAO;
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
	public partial class InvoiceListForm : Form
	{
		private InvoiceDAO invoiceDAO = new InvoiceDAO();
		public InvoiceListForm()
		{
			InitializeComponent();
			dgvInvoice.AutoGenerateColumns = false;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
		private void LoadData()
		{
			dgvInvoice.DataSource = invoiceDAO.GetInvoicesList();
			dgvInvoice.Refresh();
		}
		private void InvoiceListForm_Load(object sender, EventArgs e)
		{
			dtpFrom.Value = DateTime.Now.Date;
			dtpTo.Value = DateTime.Now.Date;
			LoadData();
		}
		private bool ValidateForm()
		{
			error.Clear();
			if (!Regex.IsMatch(tbId.Text, @"^\d*$"))
			{
				error.SetError(tbId, "Mã hóa đơn phải là số!");
				return false;
			}
			if (dtpFrom.Value.Date > dtpTo.Value.Date)
			{
				error.SetError(dtpFrom, "Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!");
				return false;
			}
			return true;
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!ValidateForm())
			{
				return;
			}
			var search = new InvoiceSearch
			{
				CusName = tbCusName.Text
			};
			if (!cbAllDays.Checked)
			{
				search.FromDate = dtpFrom.Value.Date;
				search.ToDate = dtpTo.Value.Date;
			}
			if (!string.IsNullOrEmpty(tbId.Text))
			{
				search.Id = long.Parse(tbId.Text);
			}
			dgvInvoice.DataSource = invoiceDAO.SearchInvoices(search);
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			dtpFrom.Value = DateTime.Now.Date;
			dtpTo.Value = DateTime.Now.Date;
			tbCusName.Clear();
			tbId.Clear();
			LoadData();
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			var ids = new List<long>();
			foreach (DataGridViewRow r in dgvInvoice.SelectedRows)
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
					invoiceDAO.DeleteInvoices(ids);
					MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadData();
				}
				catch
				{
					MessageBox.Show("Có lỗi xảy ra trong khi xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnDetails_Click(object sender, EventArgs e)
		{
			var row = dgvInvoice.CurrentRow;
			if (row == null || row.Index == -1)
			{
				MessageBox.Show("Chọn một bản ghi để xem chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			var id = Convert.ToInt64(row.Cells["Id"].Value);
			new InvoiceForm(id).ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (new InvoiceForm().ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
		}

		private void cbAllDays_CheckedChanged(object sender, EventArgs e)
		{
			dtpFrom.Enabled = !cbAllDays.Checked;
			dtpTo.Enabled = !cbAllDays.Checked;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
