using QuanLyBanHang.DAO;
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
	public partial class ReportForm : Form
	{
		private readonly ReportDAO repDAO = new ReportDAO();
		public ReportForm()
		{
			InitializeComponent();
		}

		private void lbStock_Click(object sender, EventArgs e)
		{

		}

		private void ReportForm_Load(object sender, EventArgs e)
		{
			comboReport.SelectedIndex = 0;
			var (invCount,profit,prodCount,inventory) = repDAO.GetNumericReport();
			lbInvCount.Text = invCount.ToString("n0");
			lbProfit.Text = profit.ToString("n0");
			lbProdCount.Text = prodCount.ToString("n0");
			lbInventory.Text = inventory.ToString("n0");
			LoadTopProducts();
		}
		private void DrawChart(ReportBy by)
		{
			chart.Series[0].Points.Clear();
			chart.Series[1].Points.Clear();
			chart.Series[2].Points.Clear();
			var (revenues, costs, profits) = repDAO.GetChartReport(by);
			for (int i = 0; i < revenues.Length; i++)
			{
				chart.Series[0].Points.AddXY(i + 1, revenues[i]);
				chart.Series[1].Points.AddXY(i + 1, costs[i]);
				chart.Series[2].Points.AddXY(i + 1, profits[i]);
			}
		}
		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}
		private void LoadTopProducts()
		{
			dgvProd.DataSource = repDAO.GetTopProducts();
		}
		private void comboReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboReport.SelectedIndex == 0)
			{
				DrawChart(ReportBy.MONTH);
			} else
			{
				DrawChart(ReportBy.YEAR);
			}
		}
	}
}
