
namespace QuanLyBanHang.UI
{
	partial class InvoiceListForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListForm));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbAllDays = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCusName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvInvoice = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDetails = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(267, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH SÁCH HÓA ĐƠN";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbAllDays);
			this.groupBox1.Controls.Add(this.btnRefresh);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtpTo);
			this.groupBox1.Controls.Add(this.dtpFrom);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbCusName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(22, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(560, 144);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm hóa đơn";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// cbAllDays
			// 
			this.cbAllDays.AutoSize = true;
			this.cbAllDays.Location = new System.Drawing.Point(95, 101);
			this.cbAllDays.Name = "cbAllDays";
			this.cbAllDays.Size = new System.Drawing.Size(131, 21);
			this.cbAllDays.TabIndex = 16;
			this.cbAllDays.Text = "Tất cả các ngày";
			this.cbAllDays.UseVisualStyleBackColor = true;
			this.cbAllDays.CheckedChanged += new System.EventHandler(this.cbAllDays_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(285, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Đến ngày";
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(399, 64);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(142, 22);
			this.dtpTo.TabIndex = 11;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(95, 64);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(171, 22);
			this.dtpFrom.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ngày lập";
			// 
			// tbCusName
			// 
			this.tbCusName.Location = new System.Drawing.Point(399, 28);
			this.tbCusName.Name = "tbCusName";
			this.tbCusName.Size = new System.Drawing.Size(142, 22);
			this.tbCusName.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(285, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Tên khách hàng";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(95, 28);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(171, 22);
			this.tbId.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Mã hóa đơn";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Controls.Add(this.btnDetails);
			this.groupBox2.Controls.Add(this.btnDel);
			this.groupBox2.Controls.Add(this.btnClose);
			this.groupBox2.Location = new System.Drawing.Point(588, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 186);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thao tác";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvInvoice);
			this.groupBox3.Location = new System.Drawing.Point(22, 245);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(766, 316);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tất cả hóa đơn";
			// 
			// dgvInvoice
			// 
			this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
			this.error.SetIconAlignment(this.dgvInvoice, System.Windows.Forms.ErrorIconAlignment.TopRight);
			this.dgvInvoice.Location = new System.Drawing.Point(6, 21);
			this.dgvInvoice.Name = "dgvInvoice";
			this.dgvInvoice.RowHeadersWidth = 51;
			this.dgvInvoice.RowTemplate.Height = 24;
			this.dgvInvoice.Size = new System.Drawing.Size(754, 297);
			this.dgvInvoice.TabIndex = 4;
			this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Id.DefaultCellStyle = dataGridViewCellStyle2;
			this.Id.HeaderText = "Mã HD";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.ToolTipText = "Mã hóa đơn";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "CusName";
			this.Column2.HeaderText = "Tên KH";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ToolTipText = "Họ tên khách hàng";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "InvDate";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column3.HeaderText = "Ngày lập";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Seller";
			this.Column4.HeaderText = "Người lập";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Notes";
			this.Column5.HeaderText = "Ghi chú";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "InvSum";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Format = "n0";
			dataGridViewCellStyle4.NullValue = null;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column7.HeaderText = "Tổng tiền";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.DarkRed;
			this.label6.Location = new System.Drawing.Point(25, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(557, 39);
			this.label6.TabIndex = 15;
			this.label6.Text = "Kích vào biểu tượng mũi tên ở đầu dòng để chọn một hàng hoặc nhấn giữ shift để ch" +
    "ọn nhiều";
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(6, 142);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(188, 37);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Đóng";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(6, 60);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(188, 37);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Tạo mới hóa đơn";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDetails
			// 
			this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
			this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDetails.Location = new System.Drawing.Point(6, 19);
			this.btnDetails.Name = "btnDetails";
			this.btnDetails.Size = new System.Drawing.Size(188, 37);
			this.btnDetails.TabIndex = 4;
			this.btnDetails.Text = "Chi tiết";
			this.btnDetails.UseVisualStyleBackColor = true;
			this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
			// 
			// btnDel
			// 
			this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
			this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDel.Location = new System.Drawing.Point(6, 101);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(188, 37);
			this.btnDel.TabIndex = 5;
			this.btnDel.Text = "Xóa hóa đơn";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRefresh.Location = new System.Drawing.Point(402, 96);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(139, 36);
			this.btnRefresh.TabIndex = 14;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(268, 96);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(128, 36);
			this.btnSearch.TabIndex = 13;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// InvoiceListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(800, 573);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "InvoiceListForm";
			this.Text = "InvoiceListForm";
			this.Load += new System.EventHandler(this.InvoiceListForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbCusName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDetails;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvInvoice;
		private System.Windows.Forms.CheckBox cbAllDays;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
	}
}