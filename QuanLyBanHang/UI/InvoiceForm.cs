using QuanLyBanHang.DAO;
using QuanLyBanHang.Models;
using QuanLyBanHang.Utils;
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
	public partial class InvoiceForm : Form
	{
		private long? id;
		private readonly InvoiceDAO invDAO = new InvoiceDAO();
		private readonly CategoryDAO catDAO = new CategoryDAO();
		private readonly ProductDAO prodDAO = new ProductDAO();
		public InvoiceForm()
		{
			InitializeComponent();
			dgvProds.AutoGenerateColumns = false;
		}

		public InvoiceForm(long? id) : this()
		{
			this.id = id;
		}

		private void InvoiceForm_Load(object sender, EventArgs e)
		{
			if (id.HasValue)
			{
				LoadInvoice(id.Value);
				gbProd.Enabled = false;
				gbCommon.Enabled = false;
				dgvProds.ReadOnly = true;
				btnSave.Enabled = false;
				btnRefresh.Enabled = false;
				lbTip.Text = "";
			}
			else
			{
				dtpInvDate.Value = DateTime.Now.Date;
				btnPrint.Enabled = false;
				dgvProds.DataSource = new BindingList<InvoiceDetail>();
			}
			LoadCategories();
		}
		private void LoadInvoice(long id)
		{
			var inv = invDAO.GetInvoiceById(id);
			if (inv == null)
			{
				MessageBox.Show("Hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}
			tbId.Text = inv.Id.ToString();
			tbCusName.Text = inv.CusName;
			tbSeller.Text = inv.Seller;
			tbNotes.Text = inv.Notes;
			dtpInvDate.Value = inv.InvDate;
			LoadInvoiceProducts(id);
			UpdateInvSum();
		}
		private void UpdateInvSum()
		{
			lbInvSum.Text = (dgvProds.DataSource as BindingList<InvoiceDetail>).Sum(id => id.DetailSum).ToString("n0");
		}
		private void LoadInvoiceProducts(long id)
		{
			dgvProds.DataSource = new BindingList<InvoiceDetail>(invDAO.GetInvoiceById(id).InvoiceDetails.ToList());
		}
		private void LoadCategories()
		{
			var cats = catDAO.GetCategories();
			cats.Insert(0, new Category { Id = -1, Name = "Tất cả danh mục" });
			comboCat.DataSource = cats;
		}
		private void LoadProductsList(long id)
		{
			libProds.DataSource = catDAO.GetProductsInCategory(id);
		}

		private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadProductsList(Convert.ToInt64(comboCat.SelectedValue));
		}

		private void libProds_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (libProds.SelectedIndex > -1)
			{
				var p = (libProds.SelectedItem as Product);
				var img = p.Image;
				pbProdImg.Image = Image.FromFile(@"images\" + img);
				if (p.Amount == 0)
				{
					lbProdAmount.Text = "Hết hàng.";
					btnAddProd.Enabled = false;
				} else
				{
					lbProdAmount.Text = $"Còn: {p.Amount:n0} {p.Unit}.";
					btnAddProd.Enabled = true;
				}
			}
		}

		private void tbProdSearchName_TextChanged(object sender, EventArgs e)
		{
			var id = Convert.ToInt64(comboCat.SelectedValue);
			var search = tbProdSearchName.Text;
			libProds.DataSource = catDAO.SearchProductsInCategory(id, search);
		}

		private void btnAddProd_Click(object sender, EventArgs e)
		{
			if (libProds.SelectedIndex == -1)
			{
				MessageBox.Show("Chọn ít nhất một mặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			var details = dgvProds.DataSource as BindingList<InvoiceDetail>;
			foreach (Product p in libProds.SelectedItems)
			{
				var item = details.FirstOrDefault(d => d.ProdId == p.Id);
				if (item == null)
				{
					details.Add(new InvoiceDetail
					{
						Product = p,
						Amount = 1,
						Price = p.SellPrice,
						ProdId = p.Id
					});
				}
				else if(item.Amount<p.Amount)
				{
					item.Amount++;
				} else
				{
					MessageBox.Show("Hàng trong kho không đủ! Hãy nhập thêm hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			details.ResetBindings();
			UpdateInvSum();
		}

		private void dgvProds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (id.HasValue) return;
			var details = (dgvProds.DataSource as BindingList<InvoiceDetail>);
			if (details.Count == 1)
			{
				MessageBox.Show("Hóa đơn phải có ít nhất một sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if(MessageBox.Show("Xóa mặt hàng này khỏi hóa đơn?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				details.RemoveAt(e.RowIndex);
				details.ResetBindings();
				UpdateInvSum();
			}
		}

		private void dgvProds_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			var index = e.RowIndex;
			if (index != -1)
			{
				var details = (dgvProds.DataSource as BindingList<InvoiceDetail>);
				details[index].Amount = Convert.ToInt32(dgvProds.Rows[index].Cells["Amount"].Value);
				details[index].Price = Convert.ToInt32(dgvProds.Rows[index].Cells["Price"].Value);
				details.ResetItem(index);
				UpdateInvSum();
			}
		}

		private void dgvProds_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (id.HasValue) return;
			var propName = dgvProds.Columns[e.ColumnIndex].DataPropertyName;
			if (propName != "Amount" && propName != "Price") return;
			var val = e.FormattedValue.ToString().Replace(",", "");
			var text = dgvProds.Columns[e.ColumnIndex].HeaderText;
			e.Cancel = true;
			if (string.IsNullOrEmpty(val))
			{
				dgvProds.Rows[e.RowIndex].ErrorText = $"Không được để trống {text}!";
				return;
			}
			if (!Regex.IsMatch(val, @"^\d+$") || int.Parse(val) <= 0)
			{
				dgvProds.Rows[e.RowIndex].ErrorText = $"Giá trị của {text} không hợp lệ!";
				return;
			}
			var prodId = Convert.ToInt64(dgvProds.Rows[e.RowIndex].Cells["ProdId"].Value);
			var prod = prodDAO.GetProductById(prodId);
			if (propName=="Amount" && prod.Amount < Convert.ToInt32(val))
			{
				MessageBox.Show("Hàng trong kho không đủ! Hãy nhập thêm hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				var details = dgvProds.DataSource as BindingList<InvoiceDetail>;
				details[e.RowIndex].Amount = prod.Amount;
				details.ResetItem(e.RowIndex);
			}
			e.Cancel = false;
		}

		private void dgvProds_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			dgvProds.Rows[e.RowIndex].ErrorText = null;
		}
		private bool ValidateInvoice()
		{
			error.Clear();
			bool valid = true;
			if (string.IsNullOrEmpty(tbCusName.Text))
			{
				error.SetError(tbCusName, "Tên khách hàng không được để trống!");
				valid = false;
			}
			if (string.IsNullOrEmpty(tbSeller.Text))
			{
				error.SetError(tbSeller, "Tên người bán không được để trống!");
				valid = false;
			}
			if (dgvProds.Rows.Count == 0)
			{
				MessageBox.Show("Hóa đơn phải có ít nhất một sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				valid = false;
			}
			return valid;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateInvoice()) return;
			try
			{
				//if (id.HasValue)
				//{
				//	invDAO.UpdateInvoice(new Invoice
				//	{
				//		Id = Convert.ToInt64(tbId.Text),
				//		CusName = tbCusName.Text,
				//		InvDate = dtpInvDate.Value,
				//		Seller = tbSeller.Text,
				//		Notes = tbNotes.Text,
				//		InvoiceDetails = (dgvProds.DataSource as BindingList<InvoiceDetail>).ToList()
				//	});
				//	MessageBox.Show("Hóa đơn được cập nhật!");
				//}
				if (!id.HasValue)
				{
					var newInv = invDAO.CreateInvoice(new Invoice
					{
						CusName = tbCusName.Text,
						InvDate = dtpInvDate.Value,
						Seller = tbSeller.Text,
						Notes = tbNotes.Text,
						InvoiceDetails = (dgvProds.DataSource as BindingList<InvoiceDetail>).ToList()
					});
					if(MessageBox.Show("Hóa đơn được tạo! Xuất hóa đơn ngay?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						PrintInvoice(newInv.Id);
					}
					DialogResult = DialogResult.OK;
					Close();
				}
				//LoadInvoice(id.Value);
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			foreach (var c in gbCommon.Controls.OfType<TextBox>())
			{
				c.Clear();
			}
			dtpInvDate.Value = DateTime.Now;
			var ivl = dgvProds.DataSource as BindingList<InvoiceDetail>;
			ivl.Clear();
		}
		private void PrintInvoice(long id)
		{
			if (sfdInvoice.ShowDialog() == DialogResult.OK)
			{
				new InvoicePrinter().PrintToFile(sfdInvoice.FileName, invDAO.GetInvoiceById(id));
				MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void btnPrint_Click(object sender, EventArgs e)
		{
			PrintInvoice(id.Value);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
