namespace BaiTapBuoi5
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDtb = new System.Windows.Forms.TextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số sinh viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tến sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm TB";
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(210, 56);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(243, 22);
            this.txtMssv.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(321, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtDtb
            // 
            this.txtDtb.Location = new System.Drawing.Point(210, 221);
            this.txtDtb.Name = "txtDtb";
            this.txtDtb.Size = new System.Drawing.Size(100, 22);
            this.txtDtb.TabIndex = 3;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngôn ngữ anh",
            "Quản trị kinh doanh"});
            this.cbKhoa.Location = new System.Drawing.Point(210, 161);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(321, 24);
            this.cbKhoa.TabIndex = 2;
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(339, 293);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(98, 33);
            this.btnThemmoi.TabIndex = 4;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(443, 293);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 353);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.txtDtb);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDtb;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnThoat;
    }
}