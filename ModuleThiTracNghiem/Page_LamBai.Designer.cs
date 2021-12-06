
namespace ModuleThiTracNghiem
{
    partial class Page_LamBai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MoveRight = new System.Windows.Forms.Button();
            this.btn_MoveLeft = new System.Windows.Forms.Button();
            this.lbl_Page = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_XemCauDanhDau = new System.Windows.Forms.Button();
            this.clock = new ModuleThiTracNghiem.Clock();
            this.SuspendLayout();
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_MoveRight.Location = new System.Drawing.Point(95, 453);
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.Size = new System.Drawing.Size(23, 29);
            this.btn_MoveRight.TabIndex = 13;
            this.btn_MoveRight.Text = "→";
            this.btn_MoveRight.UseVisualStyleBackColor = true;
            this.btn_MoveRight.Click += new System.EventHandler(this.btn_MoveRight_Click);
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_MoveLeft.Location = new System.Drawing.Point(66, 453);
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.Size = new System.Drawing.Size(23, 29);
            this.btn_MoveLeft.TabIndex = 14;
            this.btn_MoveLeft.Text = "←";
            this.btn_MoveLeft.UseVisualStyleBackColor = true;
            this.btn_MoveLeft.Click += new System.EventHandler(this.btn_MoveLeft_Click);
            // 
            // lbl_Page
            // 
            this.lbl_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Page.AutoSize = true;
            this.lbl_Page.Location = new System.Drawing.Point(21, 457);
            this.lbl_Page.Name = "lbl_Page";
            this.lbl_Page.Size = new System.Drawing.Size(51, 20);
            this.lbl_Page.TabIndex = 12;
            this.lbl_Page.Text = "  page";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Submit.Location = new System.Drawing.Point(325, 448);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(94, 39);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_XemCauDanhDau
            // 
            this.btn_XemCauDanhDau.Location = new System.Drawing.Point(125, 448);
            this.btn_XemCauDanhDau.Name = "btn_XemCauDanhDau";
            this.btn_XemCauDanhDau.Size = new System.Drawing.Size(194, 39);
            this.btn_XemCauDanhDau.TabIndex = 15;
            this.btn_XemCauDanhDau.Text = "Xem câu hỏi đã đánh dấu";
            this.btn_XemCauDanhDau.UseVisualStyleBackColor = true;
            this.btn_XemCauDanhDau.Click += new System.EventHandler(this.btn_XemCauDanhDau_Click);
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(156, 381);
            this.clock.mm = 0;
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(104, 61);
            this.clock.ss = 0;
            this.clock.TabIndex = 16;
            // 
            // Page_LamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clock);
            this.Controls.Add(this.btn_XemCauDanhDau);
            this.Controls.Add(this.btn_MoveRight);
            this.Controls.Add(this.btn_MoveLeft);
            this.Controls.Add(this.lbl_Page);
            this.Controls.Add(this.btn_Submit);
            this.Name = "Page_LamBai";
            this.Size = new System.Drawing.Size(442, 506);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MoveRight;
        private System.Windows.Forms.Button btn_MoveLeft;
        private System.Windows.Forms.Label lbl_Page;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_XemCauDanhDau;
        private Clock clock;
    }
}
