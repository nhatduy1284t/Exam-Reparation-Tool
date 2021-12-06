
namespace ModuleThiTracNghiem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_De = new System.Windows.Forms.Label();
            this.btn_BatDau = new System.Windows.Forms.Button();
            this.btn_ChonDe = new System.Windows.Forms.Button();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_De
            // 
            this.lbl_De.AutoSize = true;
            this.lbl_De.Location = new System.Drawing.Point(173, 184);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(51, 20);
            this.lbl_De.TabIndex = 12;
            this.lbl_De.Text = "mã đề";
            this.lbl_De.Visible = false;
            // 
            // btn_BatDau
            // 
            this.btn_BatDau.Location = new System.Drawing.Point(14, 376);
            this.btn_BatDau.Name = "btn_BatDau";
            this.btn_BatDau.Size = new System.Drawing.Size(359, 41);
            this.btn_BatDau.TabIndex = 11;
            this.btn_BatDau.TabStop = false;
            this.btn_BatDau.Text = "Bắt đầu thi";
            this.btn_BatDau.UseVisualStyleBackColor = true;
            this.btn_BatDau.Click += new System.EventHandler(this.btn_BatDau_Click);
            // 
            // btn_ChonDe
            // 
            this.btn_ChonDe.Location = new System.Drawing.Point(279, 180);
            this.btn_ChonDe.Name = "btn_ChonDe";
            this.btn_ChonDe.Size = new System.Drawing.Size(94, 29);
            this.btn_ChonDe.TabIndex = 10;
            this.btn_ChonDe.TabStop = false;
            this.btn_ChonDe.Text = "Chọn đề";
            this.btn_ChonDe.UseVisualStyleBackColor = true;
            this.btn_ChonDe.Click += new System.EventHandler(this.btn_ChonDe_Click);
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(117, 128);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(256, 27);
            this.txt_MaNhanVien.TabIndex = 1;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(117, 80);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(256, 27);
            this.txt_HoTen.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điền thông tin cá nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(388, 427);
            this.Controls.Add(this.lbl_De);
            this.Controls.Add(this.btn_BatDau);
            this.Controls.Add(this.btn_ChonDe);
            this.Controls.Add(this.txt_MaNhanVien);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ứng dụng thi trắc nghiệm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.Button btn_BatDau;
        private System.Windows.Forms.Button btn_ChonDe;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

