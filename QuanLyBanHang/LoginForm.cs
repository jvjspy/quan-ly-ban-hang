using QuanLyBanHang.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new InvoiceListForm().Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			new ReportForm().Show();
		}

        private void button3_Click(object sender, EventArgs e)
        {
			new CategoryForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
			new ProductForm().Show();
		}

        private void button6_Click(object sender, EventArgs e)
        {
			new ProviderForm().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
			new ReciptForm().Show();

		}
    }
}
