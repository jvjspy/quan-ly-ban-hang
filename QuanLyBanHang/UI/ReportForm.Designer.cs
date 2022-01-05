
namespace QuanLyBanHang.UI
{
	partial class ReportForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbInvCount = new System.Windows.Forms.Label();
			this.lbProfit = new System.Windows.Forms.Label();
			this.lbProdCount = new System.Windows.Forms.Label();
			this.lbInventory = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboReport = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvProd = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(434, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "THỐNG KÊ";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Red;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Image = global::QuanLyBanHang.Properties.Resources.invoice;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(15, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(242, 78);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hóa đơn";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Green;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Image = global::QuanLyBanHang.Properties.Resources.profits;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(266, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(242, 78);
			this.label3.TabIndex = 2;
			this.label3.Text = "Lợi nhuận";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Orange;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Image = global::QuanLyBanHang.Properties.Resources.package;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new System.Drawing.Point(517, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 78);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sản phẩm";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Indigo;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Image = global::QuanLyBanHang.Properties.Resources.store;
			this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.Location = new System.Drawing.Point(768, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(255, 78);
			this.label5.TabIndex = 4;
			this.label5.Text = "Giá trị tồn";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lbInvCount
			// 
			this.lbInvCount.BackColor = System.Drawing.Color.Red;
			this.lbInvCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbInvCount.ForeColor = System.Drawing.Color.White;
			this.lbInvCount.Location = new System.Drawing.Point(100, 18);
			this.lbInvCount.Name = "lbInvCount";
			this.lbInvCount.Size = new System.Drawing.Size(157, 51);
			this.lbInvCount.TabIndex = 5;
			this.lbInvCount.Text = "100";
			this.lbInvCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbProfit
			// 
			this.lbProfit.BackColor = System.Drawing.Color.Green;
			this.lbProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbProfit.ForeColor = System.Drawing.Color.White;
			this.lbProfit.Location = new System.Drawing.Point(352, 18);
			this.lbProfit.Name = "lbProfit";
			this.lbProfit.Size = new System.Drawing.Size(156, 51);
			this.lbProfit.TabIndex = 6;
			this.lbProfit.Text = "100,000,000";
			this.lbProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbProdCount
			// 
			this.lbProdCount.BackColor = System.Drawing.Color.Orange;
			this.lbProdCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbProdCount.ForeColor = System.Drawing.Color.White;
			this.lbProdCount.Location = new System.Drawing.Point(597, 18);
			this.lbProdCount.Name = "lbProdCount";
			this.lbProdCount.Size = new System.Drawing.Size(162, 51);
			this.lbProdCount.TabIndex = 7;
			this.lbProdCount.Text = "100";
			this.lbProdCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbInventory
			// 
			this.lbInventory.BackColor = System.Drawing.Color.Indigo;
			this.lbInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbInventory.ForeColor = System.Drawing.Color.White;
			this.lbInventory.Location = new System.Drawing.Point(855, 18);
			this.lbInventory.Name = "lbInventory";
			this.lbInventory.Size = new System.Drawing.Size(168, 51);
			this.lbInventory.TabIndex = 8;
			this.lbInventory.Text = "500,000,000";
			this.lbInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbInventory.Click += new System.EventHandler(this.lbStock_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbProdCount);
			this.groupBox1.Controls.Add(this.lbInventory);
			this.groupBox1.Controls.Add(this.lbProfit);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lbInvCount);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1037, 110);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Số liệu thống kê";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboReport);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.chart);
			this.groupBox2.Location = new System.Drawing.Point(12, 161);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1037, 358);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Biểu đồ";
			// 
			// comboReport
			// 
			this.comboReport.FormattingEnabled = true;
			this.comboReport.Items.AddRange(new object[] {
            "Trong tháng",
            "Trong năm"});
			this.comboReport.Location = new System.Drawing.Point(835, 17);
			this.comboReport.Name = "comboReport";
			this.comboReport.Size = new System.Drawing.Size(188, 24);
			this.comboReport.TabIndex = 3;
			this.comboReport.SelectedIndexChanged += new System.EventHandler(this.comboReport_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(720, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 17);
			this.label6.TabIndex = 2;
			this.label6.Text = "Thống kê theo";
			// 
			// chart
			// 
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(18, 50);
			this.chart.Name = "chart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Thu";
			series1.XValueMember = "day";
			series1.YValueMembers = "revenue";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Chi";
			series2.XValueMember = "day";
			series2.YValueMembers = "cost";
			series3.BorderWidth = 2;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series3.Legend = "Legend1";
			series3.Name = "Lợi nhuận";
			series3.XValueMember = "day";
			series3.YValueMembers = "profit";
			this.chart.Series.Add(series1);
			this.chart.Series.Add(series2);
			this.chart.Series.Add(series3);
			this.chart.Size = new System.Drawing.Size(1005, 302);
			this.chart.TabIndex = 1;
			this.chart.Text = "chart1";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvProd);
			this.groupBox3.Location = new System.Drawing.Point(12, 522);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1043, 239);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sản phẩm bán chạy";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// dgvProd
			// 
			this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvProd.Location = new System.Drawing.Point(6, 21);
			this.dgvProd.Name = "dgvProd";
			this.dgvProd.RowHeadersWidth = 51;
			this.dgvProd.RowTemplate.Height = 24;
			this.dgvProd.Size = new System.Drawing.Size(1031, 212);
			this.dgvProd.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "Mã SP";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ToolTipText = "Mã sản phẩm";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Name";
			this.Column2.HeaderText = "Tên SP";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ToolTipText = "Tên sản phẩm";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Price";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = null;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column3.HeaderText = "ĐG Bán";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ToolTipText = "Đơn giá bán";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Amount";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = null;
			this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column4.HeaderText = "SL còn";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ToolTipText = "Số lượng còn";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Count";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			dataGridViewCellStyle4.NullValue = null;
			this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column5.HeaderText = "Đã bán";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 773);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "ReportForm";
			this.Text = "ReportForm";
			this.Load += new System.EventHandler(this.ReportForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbInvCount;
		private System.Windows.Forms.Label lbProfit;
		private System.Windows.Forms.Label lbProdCount;
		private System.Windows.Forms.Label lbInventory;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgvProd;
		private System.Windows.Forms.ComboBox comboReport;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}