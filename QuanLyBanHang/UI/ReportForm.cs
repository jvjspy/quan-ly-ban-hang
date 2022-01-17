using QuanLyBanHang.DAO;
using System;
using System.Data;
using System.Linq;
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

		private void ReportForm_Load(object sender, EventArgs e)
		{
			comboMonth.Items.AddRange(Enumerable.Range(1, 12).Cast<object>().ToArray());
			comboYear.Items.AddRange(repDAO.GetAvailableYears().Cast<object>().ToArray());
			var today = DateTime.Now;
			comboMonth.SelectedItem = today.Month;
			comboYear.SelectedItem = today.Year;
			comboReport.SelectedIndex = 0;
			var (invCount, profit, prodCount, inventory) = repDAO.GetNumericReport();
			lbInvCount.Text = invCount.ToString("n0");
			lbProfit.Text = profit.ToString("n0");
			lbProdCount.Text = prodCount.ToString("n0");
			lbInventory.Text = inventory.ToString("n0");
			LoadTopProducts();
		}
		private void DrawChart()
		{
			chart.Series[0].Points.Clear();
			chart.Series[1].Points.Clear();
			chart.Series[2].Points.Clear();
			(int[], int[], int[]) data;
			if (comboReport.SelectedIndex == 0)
			{
				data = repDAO.GetChartReportInMonth((int)comboMonth.SelectedItem, (int)comboYear.SelectedItem);
			}
			else if (comboReport.SelectedIndex == 1)
			{
				data = repDAO.GetChartReportInYear((int)comboYear.SelectedItem);
			}
			else
			{
				return;
			}
			var (revenues, costs, profits) = data;
			for (int i = 0; i < revenues.Length; i++)
			{
				chart.Series[0].Points.AddXY(i + 1, revenues[i]);
				chart.Series[1].Points.AddXY(i + 1, costs[i]);
				chart.Series[2].Points.AddXY(i + 1, profits[i]);
			}
		}
		private void LoadTopProducts()
		{
			dgvProd.DataSource = repDAO.GetTopProducts();
		}
		private void comboReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboReport.SelectedIndex == 0)
			{
				comboMonth.Enabled = true;
			}
			else if (comboReport.SelectedIndex == 1)
			{
				comboMonth.Enabled = false;
			}
			DrawChart();
		}

		private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			DrawChart();
		}

		private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			DrawChart();
		}
	}
}
