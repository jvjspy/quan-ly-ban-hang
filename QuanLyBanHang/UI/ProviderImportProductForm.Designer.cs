
namespace QuanLyBanHang.UI
{
    partial class ProviderImportProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMaBienLai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhập hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgayTao);
            this.groupBox1.Controls.Add(this.cbxNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin biên lai";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayTao.Location = new System.Drawing.Point(102, 58);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(136, 20);
            this.txtNgayTao.TabIndex = 5;
            // 
            // cbxNCC
            // 
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(102, 25);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(136, 21);
            this.cbxNCC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Tạo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(102, 92);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(136, 20);
            this.txtGhiChu.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Só lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(443, 35);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(136, 20);
            this.txtSoLuong.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtMaHang);
            this.groupBox2.Controls.Add(this.txtMaBienLai);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Location = new System.Drawing.Point(302, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhập hàng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(443, 78);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(136, 20);
            this.txtDonGia.TabIndex = 0;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(142, 35);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(136, 20);
            this.txtMaHang.TabIndex = 0;
            // 
            // txtMaBienLai
            // 
            this.txtMaBienLai.Location = new System.Drawing.Point(142, 75);
            this.txtMaBienLai.Name = "txtMaBienLai";
            this.txtMaBienLai.Size = new System.Drawing.Size(136, 20);
            this.txtMaBienLai.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Đơn giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã biên lai:";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(451, 404);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(75, 23);
            this.btnNhapHang.TabIndex = 3;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xuất phiếu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 132);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ProviderImportProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ProviderImportProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProviderImportProductForm";
            this.Load += new System.EventHandler(this.ProviderImportProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxNCC;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaBienLai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.DateTimePicker txtNgayTao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}