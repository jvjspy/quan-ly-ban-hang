namespace QuanLyBanHang.UI
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_buy = new System.Windows.Forms.TextBox();
            this.txt_sell = new System.Windows.Forms.TextBox();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cblmh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileImg = new System.Windows.Forms.OpenFileDialog();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.txtImg);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.txt_buy);
            this.groupBox1.Controls.Add(this.txt_sell);
            this.groupBox1.Controls.Add(this.txt_unit);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cblmh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(55, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(301, 193);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 21);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(301, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 119);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(5, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(5, 77);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 30);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(5, 42);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 33);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(301, 170);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 21);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(104, 166);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(191, 48);
            this.txt_desc.TabIndex = 17;
            this.txt_desc.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(301, 144);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(153, 21);
            this.btnUpload.TabIndex = 16;
            this.btnUpload.Text = "Chọn ảnh";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtImg
            // 
            this.txtImg.Enabled = false;
            this.txtImg.Location = new System.Drawing.Point(104, 145);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(191, 20);
            this.txtImg.TabIndex = 14;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(104, 124);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(191, 20);
            this.txt_amount.TabIndex = 13;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Only);
            // 
            // txt_buy
            // 
            this.txt_buy.Location = new System.Drawing.Point(104, 103);
            this.txt_buy.Name = "txt_buy";
            this.txt_buy.Size = new System.Drawing.Size(191, 20);
            this.txt_buy.TabIndex = 12;
            this.txt_buy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Only);
            // 
            // txt_sell
            // 
            this.txt_sell.Location = new System.Drawing.Point(104, 82);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(191, 20);
            this.txt_sell.TabIndex = 11;
            this.txt_sell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Only);
            // 
            // txt_unit
            // 
            this.txt_unit.Location = new System.Drawing.Point(104, 61);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(191, 20);
            this.txt_unit.TabIndex = 10;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(104, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(191, 20);
            this.txt_name.TabIndex = 9;
            // 
            // cblmh
            // 
            this.cblmh.FormattingEnabled = true;
            this.cblmh.Location = new System.Drawing.Point(104, 18);
            this.cblmh.Name = "cblmh";
            this.cblmh.Size = new System.Drawing.Size(191, 21);
            this.cblmh.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mô tả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giá mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại mặt hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv);
            this.groupBox3.Location = new System.Drawing.Point(55, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 186);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CatId,
            this.NameP,
            this.Unit,
            this.SellPrice,
            this.BuyPrice,
            this.Description,
            this.Amount,
            this.Img});
            this.dgv.Location = new System.Drawing.Point(6, 19);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(682, 161);
            this.dgv.TabIndex = 0;
            this.dgv.Click += new System.EventHandler(this.selectChange);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã mặt hàng";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CatId
            // 
            this.CatId.DataPropertyName = "Category";
            this.CatId.HeaderText = "Loại mặt hàng";
            this.CatId.Name = "CatId";
            this.CatId.ReadOnly = true;
            // 
            // NameP
            // 
            this.NameP.DataPropertyName = "Name";
            this.NameP.HeaderText = "Tên sản phẩm";
            this.NameP.Name = "NameP";
            this.NameP.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // SellPrice
            // 
            this.SellPrice.DataPropertyName = "SellPrice";
            this.SellPrice.HeaderText = "Giá bán";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            // 
            // BuyPrice
            // 
            this.BuyPrice.DataPropertyName = "BuyPrice";
            this.BuyPrice.HeaderText = "Giá mua";
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Mô tả";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Số lượng";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Img
            // 
            this.Img.DataPropertyName = "Image";
            this.Img.HeaderText = "Ảnh";
            this.Img.Name = "Img";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(287, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // openFileImg
            // 
            this.openFileImg.FileName = "openFileDialog1";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(296, 477);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(148, 33);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Xuất danh sách";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(448, 477);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(148, 33);
            this.btnImport.TabIndex = 15;
            this.btnImport.Text = "Thêm mới từ file";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::QuanLyBanHang.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(600, 477);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(531, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductForm";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_buy;
        private System.Windows.Forms.TextBox txt_sell;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cblmh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileImg;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Img;
    }
}