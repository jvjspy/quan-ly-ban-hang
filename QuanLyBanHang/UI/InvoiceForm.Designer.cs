
namespace QuanLyBanHang.UI
{
	partial class InvoiceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.gbProd = new System.Windows.Forms.GroupBox();
			this.lbProdAmount = new System.Windows.Forms.Label();
			this.btnAddProd = new System.Windows.Forms.Button();
			this.tbProdSearchName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.libProds = new System.Windows.Forms.ListBox();
			this.comboCat = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pbProdImg = new System.Windows.Forms.PictureBox();
			this.gbCommon = new System.Windows.Forms.GroupBox();
			this.tbNotes = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbSeller = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.tbCusName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbDetails = new System.Windows.Forms.GroupBox();
			this.lbTip = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lbInvSum = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dgvProds = new System.Windows.Forms.DataGridView();
			this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DetailSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.sfdInvoice = new System.Windows.Forms.SaveFileDialog();
			this.gbProd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProdImg)).BeginInit();
			this.gbCommon.SuspendLayout();
			this.gbDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProds)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(450, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
			// 
			// gbProd
			// 
			this.gbProd.Controls.Add(this.lbProdAmount);
			this.gbProd.Controls.Add(this.btnAddProd);
			this.gbProd.Controls.Add(this.tbProdSearchName);
			this.gbProd.Controls.Add(this.label3);
			this.gbProd.Controls.Add(this.libProds);
			this.gbProd.Controls.Add(this.comboCat);
			this.gbProd.Controls.Add(this.label2);
			this.gbProd.Controls.Add(this.pbProdImg);
			this.gbProd.Location = new System.Drawing.Point(12, 53);
			this.gbProd.Name = "gbProd";
			this.gbProd.Size = new System.Drawing.Size(256, 597);
			this.gbProd.TabIndex = 1;
			this.gbProd.TabStop = false;
			this.gbProd.Text = "Sản phẩm";
			// 
			// lbProdAmount
			// 
			this.lbProdAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbProdAmount.ForeColor = System.Drawing.Color.Navy;
			this.lbProdAmount.Location = new System.Drawing.Point(9, 520);
			this.lbProdAmount.Name = "lbProdAmount";
			this.lbProdAmount.Size = new System.Drawing.Size(222, 23);
			this.lbProdAmount.TabIndex = 4;
			this.lbProdAmount.Text = "label12";
			this.lbProdAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAddProd
			// 
			this.btnAddProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProd.Image")));
			this.btnAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddProd.Location = new System.Drawing.Point(9, 546);
			this.btnAddProd.Name = "btnAddProd";
			this.btnAddProd.Size = new System.Drawing.Size(222, 42);
			this.btnAddProd.TabIndex = 6;
			this.btnAddProd.Text = "Thêm vào hóa đơn";
			this.btnAddProd.UseVisualStyleBackColor = true;
			this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
			// 
			// tbProdSearchName
			// 
			this.tbProdSearchName.Location = new System.Drawing.Point(9, 260);
			this.tbProdSearchName.Name = "tbProdSearchName";
			this.tbProdSearchName.Size = new System.Drawing.Size(222, 22);
			this.tbProdSearchName.TabIndex = 2;
			this.tbProdSearchName.TextChanged += new System.EventHandler(this.tbProdSearchName_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tên sản phẩm";
			// 
			// libProds
			// 
			this.libProds.DisplayMember = "Name";
			this.libProds.FormattingEnabled = true;
			this.libProds.ItemHeight = 16;
			this.libProds.Location = new System.Drawing.Point(9, 296);
			this.libProds.Name = "libProds";
			this.libProds.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.libProds.Size = new System.Drawing.Size(222, 212);
			this.libProds.TabIndex = 4;
			this.libProds.ValueMember = "Id";
			this.libProds.SelectedIndexChanged += new System.EventHandler(this.libProds_SelectedIndexChanged);
			// 
			// comboCat
			// 
			this.comboCat.DisplayMember = "Name";
			this.comboCat.FormattingEnabled = true;
			this.comboCat.Location = new System.Drawing.Point(6, 191);
			this.comboCat.Name = "comboCat";
			this.comboCat.Size = new System.Drawing.Size(225, 24);
			this.comboCat.TabIndex = 2;
			this.comboCat.ValueMember = "Id";
			this.comboCat.SelectedIndexChanged += new System.EventHandler(this.comboCat_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nhóm sản phẩm";
			// 
			// pbProdImg
			// 
			this.pbProdImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbProdImg.Location = new System.Drawing.Point(6, 30);
			this.pbProdImg.Name = "pbProdImg";
			this.pbProdImg.Size = new System.Drawing.Size(225, 116);
			this.pbProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProdImg.TabIndex = 2;
			this.pbProdImg.TabStop = false;
			// 
			// gbCommon
			// 
			this.gbCommon.Controls.Add(this.tbNotes);
			this.gbCommon.Controls.Add(this.label8);
			this.gbCommon.Controls.Add(this.tbSeller);
			this.gbCommon.Controls.Add(this.label7);
			this.gbCommon.Controls.Add(this.dtpInvDate);
			this.gbCommon.Controls.Add(this.label6);
			this.gbCommon.Controls.Add(this.tbCusName);
			this.gbCommon.Controls.Add(this.label5);
			this.gbCommon.Controls.Add(this.tbId);
			this.gbCommon.Controls.Add(this.label4);
			this.gbCommon.Location = new System.Drawing.Point(274, 53);
			this.gbCommon.Name = "gbCommon";
			this.gbCommon.Size = new System.Drawing.Size(625, 197);
			this.gbCommon.TabIndex = 2;
			this.gbCommon.TabStop = false;
			this.gbCommon.Text = "Thông tin chung";
			// 
			// tbNotes
			// 
			this.tbNotes.Location = new System.Drawing.Point(9, 133);
			this.tbNotes.Multiline = true;
			this.tbNotes.Name = "tbNotes";
			this.tbNotes.Size = new System.Drawing.Size(581, 58);
			this.tbNotes.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Ghi chú";
			// 
			// tbSeller
			// 
			this.tbSeller.Location = new System.Drawing.Point(407, 64);
			this.tbSeller.Name = "tbSeller";
			this.tbSeller.Size = new System.Drawing.Size(183, 22);
			this.tbSeller.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(318, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Người lập";
			// 
			// dtpInvDate
			// 
			this.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInvDate.Location = new System.Drawing.Point(95, 64);
			this.dtpInvDate.Name = "dtpInvDate";
			this.dtpInvDate.Size = new System.Drawing.Size(183, 22);
			this.dtpInvDate.TabIndex = 9;
			this.dtpInvDate.Value = new System.DateTime(2022, 1, 4, 0, 0, 0, 0);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Ngày lập";
			// 
			// tbCusName
			// 
			this.tbCusName.Location = new System.Drawing.Point(407, 27);
			this.tbCusName.Name = "tbCusName";
			this.tbCusName.Size = new System.Drawing.Size(183, 22);
			this.tbCusName.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(318, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Khách hàng";
			// 
			// tbId
			// 
			this.tbId.Enabled = false;
			this.tbId.Location = new System.Drawing.Point(95, 27);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(183, 22);
			this.tbId.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Mã hóa đơn";
			// 
			// gbDetails
			// 
			this.gbDetails.Controls.Add(this.lbTip);
			this.gbDetails.Controls.Add(this.label11);
			this.gbDetails.Controls.Add(this.lbInvSum);
			this.gbDetails.Controls.Add(this.label9);
			this.gbDetails.Controls.Add(this.dgvProds);
			this.gbDetails.Location = new System.Drawing.Point(274, 256);
			this.gbDetails.Name = "gbDetails";
			this.gbDetails.Size = new System.Drawing.Size(821, 394);
			this.gbDetails.TabIndex = 3;
			this.gbDetails.TabStop = false;
			this.gbDetails.Text = "Thông tin hàng hóa";
			// 
			// lbTip
			// 
			this.lbTip.AutoSize = true;
			this.lbTip.ForeColor = System.Drawing.Color.DarkRed;
			this.lbTip.Location = new System.Drawing.Point(6, 20);
			this.lbTip.Name = "lbTip";
			this.lbTip.Size = new System.Drawing.Size(303, 17);
			this.lbTip.TabIndex = 8;
			this.lbTip.Text = "Kích vào ô số lượng hoặc đơn giá để chỉnh sửa";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.DarkRed;
			this.label11.Location = new System.Drawing.Point(9, 365);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(199, 17);
			this.label11.TabIndex = 7;
			this.label11.Text = "Kích đúp vào một hàng để xóa";
			// 
			// lbInvSum
			// 
			this.lbInvSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbInvSum.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbInvSum.Location = new System.Drawing.Point(645, 364);
			this.lbInvSum.Name = "lbInvSum";
			this.lbInvSum.Size = new System.Drawing.Size(170, 23);
			this.lbInvSum.TabIndex = 2;
			this.lbInvSum.Text = "label10";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DarkRed;
			this.label9.Location = new System.Drawing.Point(547, 367);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 17);
			this.label9.TabIndex = 1;
			this.label9.Text = "Tổng tiền";
			// 
			// dgvProds
			// 
			this.dgvProds.AllowUserToAddRows = false;
			this.dgvProds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.Amount,
            this.Price,
            this.DetailSum});
			this.error.SetIconAlignment(this.dgvProds, System.Windows.Forms.ErrorIconAlignment.TopLeft);
			this.dgvProds.Location = new System.Drawing.Point(9, 40);
			this.dgvProds.Name = "dgvProds";
			this.dgvProds.RowHeadersWidth = 51;
			this.dgvProds.RowTemplate.Height = 24;
			this.dgvProds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvProds.Size = new System.Drawing.Size(806, 316);
			this.dgvProds.TabIndex = 0;
			this.dgvProds.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProds_CellDoubleClick);
			this.dgvProds.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProds_CellValidated);
			this.dgvProds.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvProds_CellValidating);
			this.dgvProds.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProds_CellValueChanged);
			// 
			// ProdId
			// 
			this.ProdId.DataPropertyName = "ProdId";
			this.ProdId.HeaderText = "Mã SP";
			this.ProdId.MinimumWidth = 6;
			this.ProdId.Name = "ProdId";
			this.ProdId.ReadOnly = true;
			this.ProdId.ToolTipText = "Mã sản phẩm";
			// 
			// ProdName
			// 
			this.ProdName.DataPropertyName = "ProdName";
			this.ProdName.HeaderText = "Tên SP";
			this.ProdName.MinimumWidth = 6;
			this.ProdName.Name = "ProdName";
			this.ProdName.ReadOnly = true;
			this.ProdName.ToolTipText = "Tên sản phẩm";
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "Amount";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = null;
			this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
			this.Amount.HeaderText = "Số lượng";
			this.Amount.MinimumWidth = 6;
			this.Amount.Name = "Amount";
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = null;
			this.Price.DefaultCellStyle = dataGridViewCellStyle3;
			this.Price.HeaderText = "Đơn giá";
			this.Price.MinimumWidth = 6;
			this.Price.Name = "Price";
			// 
			// DetailSum
			// 
			this.DetailSum.DataPropertyName = "DetailSum";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			dataGridViewCellStyle4.NullValue = null;
			this.DetailSum.DefaultCellStyle = dataGridViewCellStyle4;
			this.DetailSum.HeaderText = "Thành tiền";
			this.DetailSum.MinimumWidth = 6;
			this.DetailSum.Name = "DetailSum";
			this.DetailSum.ReadOnly = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnRefresh);
			this.groupBox4.Controls.Add(this.btnClose);
			this.groupBox4.Controls.Add(this.btnPrint);
			this.groupBox4.Controls.Add(this.btnSave);
			this.groupBox4.Location = new System.Drawing.Point(905, 53);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(190, 197);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Thao tác";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRefresh.Location = new System.Drawing.Point(6, 18);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(178, 41);
			this.btnRefresh.TabIndex = 0;
			this.btnRefresh.Text = "Làm lại";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Image = global::QuanLyBanHang.Properties.Resources.close;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(6, 150);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(178, 41);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Đóng";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnPrint
			// 
			this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrint.Location = new System.Drawing.Point(6, 106);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(178, 41);
			this.btnPrint.TabIndex = 2;
			this.btnPrint.Text = "In hóa đơn";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(6, 62);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(178, 41);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Lưu hóa đơn";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// sfdInvoice
			// 
			this.sfdInvoice.Title = "Lưu file pdf hóa đơn";
			// 
			// InvoiceForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1107, 662);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.gbDetails);
			this.Controls.Add(this.gbCommon);
			this.Controls.Add(this.gbProd);
			this.Controls.Add(this.label1);
			this.Name = "InvoiceForm";
			this.Text = "InvoiceForm";
			this.Load += new System.EventHandler(this.InvoiceForm_Load);
			this.gbProd.ResumeLayout(false);
			this.gbProd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProdImg)).EndInit();
			this.gbCommon.ResumeLayout(false);
			this.gbCommon.PerformLayout();
			this.gbDetails.ResumeLayout(false);
			this.gbDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProds)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbProd;
		private System.Windows.Forms.Button btnAddProd;
		private System.Windows.Forms.TextBox tbProdSearchName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox libProds;
		private System.Windows.Forms.ComboBox comboCat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbProdImg;
		private System.Windows.Forms.GroupBox gbCommon;
		private System.Windows.Forms.GroupBox gbDetails;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbNotes;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbSeller;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpInvDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbCusName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lbInvSum;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dgvProds;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbProdAmount;
		private System.Windows.Forms.Label lbTip;
		private System.Windows.Forms.SaveFileDialog sfdInvoice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn DetailSum;
	}
}