
namespace ModuleSoanDe
{
    partial class frmMain
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
            this.btn_SoanCauHoi = new System.Windows.Forms.Button();
            this.btn_ChamBai = new System.Windows.Forms.Button();
            this.btn_TaoBaiThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SoanCauHoi
            // 
            this.btn_SoanCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SoanCauHoi.Location = new System.Drawing.Point(12, 95);
            this.btn_SoanCauHoi.Name = "btn_SoanCauHoi";
            this.btn_SoanCauHoi.Size = new System.Drawing.Size(539, 60);
            this.btn_SoanCauHoi.TabIndex = 0;
            this.btn_SoanCauHoi.TabStop = false;
            this.btn_SoanCauHoi.Text = "Soạn câu hỏi";
            this.btn_SoanCauHoi.UseVisualStyleBackColor = true;
            this.btn_SoanCauHoi.Click += new System.EventHandler(this.btn_SoanCauHoi_Click);
            // 
            // btn_ChamBai
            // 
            this.btn_ChamBai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChamBai.Location = new System.Drawing.Point(12, 245);
            this.btn_ChamBai.Name = "btn_ChamBai";
            this.btn_ChamBai.Size = new System.Drawing.Size(539, 60);
            this.btn_ChamBai.TabIndex = 0;
            this.btn_ChamBai.TabStop = false;
            this.btn_ChamBai.Text = "Chấm bài";
            this.btn_ChamBai.UseVisualStyleBackColor = true;
            this.btn_ChamBai.Click += new System.EventHandler(this.btn_ChamBai_Click);
            // 
            // btn_TaoBaiThi
            // 
            this.btn_TaoBaiThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoBaiThi.Location = new System.Drawing.Point(12, 169);
            this.btn_TaoBaiThi.Name = "btn_TaoBaiThi";
            this.btn_TaoBaiThi.Size = new System.Drawing.Size(539, 60);
            this.btn_TaoBaiThi.TabIndex = 0;
            this.btn_TaoBaiThi.TabStop = false;
            this.btn_TaoBaiThi.Text = "Tạo bài thi";
            this.btn_TaoBaiThi.UseVisualStyleBackColor = true;
            this.btn_TaoBaiThi.Click += new System.EventHandler(this.btn_TaoBaiThi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Công cụ soạn đề thi";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Location = new System.Drawing.Point(13, 9);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(75, 29);
            this.btn_QuayLai.TabIndex = 2;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Visible = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(563, 482);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TaoBaiThi);
            this.Controls.Add(this.btn_ChamBai);
            this.Controls.Add(this.btn_SoanCauHoi);
            this.Name = "frmMain";
            this.Text = "Module soạn đề";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SoanCauHoi;
        private System.Windows.Forms.Button btn_ChamBai;
        private System.Windows.Forms.Button btn_TaoBaiThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QuayLai;
    }
}

