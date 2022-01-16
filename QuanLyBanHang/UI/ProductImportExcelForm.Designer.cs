namespace QuanLyBanHang.UI
{
    partial class ProductImportExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductImportExcelForm));
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Image = global::QuanLyBanHang.Properties.Resources.close;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(636, 428);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 30);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Đóng";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(427, 428);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 33);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::QuanLyBanHang.Properties.Resources.add;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(219, 428);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(148, 33);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Chọn File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatId,
            this.NameP,
            this.Unit,
            this.SellPrice,
            this.BuyPrice,
            this.Description,
            this.Amount,
            this.Img});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 360);
            this.dgv.TabIndex = 18;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Double_To_Del);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::QuanLyBanHang.Properties.Resources.information;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(11, 428);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(148, 33);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.Text = "Lấy mẫu file";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnGetExcel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(294, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "* Chọn 2 lần vào 1 dòng để xóa dòng đó";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // CatId
            // 
            this.CatId.DataPropertyName = "Category";
            this.CatId.HeaderText = "Loại mặt hàng";
            this.CatId.Name = "CatId";
            this.CatId.Width = 50;
            // 
            // NameP
            // 
            this.NameP.DataPropertyName = "Name";
            this.NameP.HeaderText = "Tên sản phẩm";
            this.NameP.Name = "NameP";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.Name = "Unit";
            this.Unit.Width = 50;
            // 
            // SellPrice
            // 
            this.SellPrice.DataPropertyName = "SellPrice";
            this.SellPrice.HeaderText = "Giá bán";
            this.SellPrice.Name = "SellPrice";
            // 
            // BuyPrice
            // 
            this.BuyPrice.DataPropertyName = "BuyPrice";
            this.BuyPrice.HeaderText = "Giá mua";
            this.BuyPrice.Name = "BuyPrice";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Mô tả";
            this.Description.Name = "Description";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Số lượng";
            this.Amount.Name = "Amount";
            // 
            // Img
            // 
            this.Img.DataPropertyName = "Image";
            this.Img.HeaderText = "Ảnh";
            this.Img.Name = "Img";
            // 
            // ProductImportExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Name = "ProductImportExcelForm";
            this.Text = "Thêm mới từ file";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label2;
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