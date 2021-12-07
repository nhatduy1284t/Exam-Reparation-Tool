
namespace ModuleSoanDe
{
    partial class Page_ChamBai
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DocFileBaiLam = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbx_Test = new System.Windows.Forms.ListBox();
            this.btn_ChamBai = new System.Windows.Forms.Button();
            this.lbl_FileDapAn = new System.Windows.Forms.Label();
            this.lbl_FileBaiLam = new System.Windows.Forms.Label();
            this.btn_ChonFileDapAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chấm bài";
            // 
            // btn_DocFileBaiLam
            // 
            this.btn_DocFileBaiLam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_DocFileBaiLam.Location = new System.Drawing.Point(20, 123);
            this.btn_DocFileBaiLam.Name = "btn_DocFileBaiLam";
            this.btn_DocFileBaiLam.Size = new System.Drawing.Size(135, 32);
            this.btn_DocFileBaiLam.TabIndex = 1;
            this.btn_DocFileBaiLam.Text = "Chọn file bài làm";
            this.btn_DocFileBaiLam.UseVisualStyleBackColor = true;
            this.btn_DocFileBaiLam.Click += new System.EventHandler(this.btn_DocFileBaiLam_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbx_Test
            // 
            this.lbx_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbx_Test.FormattingEnabled = true;
            this.lbx_Test.ItemHeight = 20;
            this.lbx_Test.Location = new System.Drawing.Point(20, 161);
            this.lbx_Test.Name = "lbx_Test";
            this.lbx_Test.Size = new System.Drawing.Size(512, 304);
            this.lbx_Test.TabIndex = 2;
            // 
            // btn_ChamBai
            // 
            this.btn_ChamBai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChamBai.Location = new System.Drawing.Point(20, 471);
            this.btn_ChamBai.Name = "btn_ChamBai";
            this.btn_ChamBai.Size = new System.Drawing.Size(512, 71);
            this.btn_ChamBai.TabIndex = 3;
            this.btn_ChamBai.Text = "Thực hiện chấm bài";
            this.btn_ChamBai.UseVisualStyleBackColor = true;
            this.btn_ChamBai.Click += new System.EventHandler(this.btn_ChamBai_Click);
            // 
            // lbl_FileDapAn
            // 
            this.lbl_FileDapAn.AutoSize = true;
            this.lbl_FileDapAn.Location = new System.Drawing.Point(172, 91);
            this.lbl_FileDapAn.Name = "lbl_FileDapAn";
            this.lbl_FileDapAn.Size = new System.Drawing.Size(0, 20);
            this.lbl_FileDapAn.TabIndex = 4;
            // 
            // lbl_FileBaiLam
            // 
            this.lbl_FileBaiLam.AutoSize = true;
            this.lbl_FileBaiLam.Location = new System.Drawing.Point(172, 129);
            this.lbl_FileBaiLam.Name = "lbl_FileBaiLam";
            this.lbl_FileBaiLam.Size = new System.Drawing.Size(0, 20);
            this.lbl_FileBaiLam.TabIndex = 4;
            // 
            // btn_ChonFileDapAn
            // 
            this.btn_ChonFileDapAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ChonFileDapAn.Location = new System.Drawing.Point(20, 81);
            this.btn_ChonFileDapAn.Name = "btn_ChonFileDapAn";
            this.btn_ChonFileDapAn.Size = new System.Drawing.Size(135, 29);
            this.btn_ChonFileDapAn.TabIndex = 5;
            this.btn_ChonFileDapAn.Text = "Chọn file đáp án";
            this.btn_ChonFileDapAn.UseVisualStyleBackColor = true;
            this.btn_ChonFileDapAn.Click += new System.EventHandler(this.btn_ChonFileDapAn_Click);
            // 
            // Page_ChamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btn_ChonFileDapAn);
            this.Controls.Add(this.lbl_FileBaiLam);
            this.Controls.Add(this.lbl_FileDapAn);
            this.Controls.Add(this.btn_ChamBai);
            this.Controls.Add(this.lbx_Test);
            this.Controls.Add(this.btn_DocFileBaiLam);
            this.Controls.Add(this.label1);
            this.Name = "Page_ChamBai";
            this.Size = new System.Drawing.Size(550, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DocFileBaiLam;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbx_Test;
        private System.Windows.Forms.Button btn_ChamBai;
        private System.Windows.Forms.Label lbl_FileDapAn;
        private System.Windows.Forms.Label lbl_FileBaiLam;
        private System.Windows.Forms.Button btn_ChonFileDapAn;
    }
}
