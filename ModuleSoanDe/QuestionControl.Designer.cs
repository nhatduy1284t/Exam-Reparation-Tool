
namespace Exercise02
{
    partial class QuestionControl
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
            this.ans1 = new System.Windows.Forms.RadioButton();
            this.ans2 = new System.Windows.Forms.RadioButton();
            this.ans3 = new System.Windows.Forms.RadioButton();
            this.ans4 = new System.Windows.Forms.RadioButton();
            this.content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(23, 66);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(84, 24);
            this.ans1.TabIndex = 1;
            this.ans1.TabStop = true;
            this.ans1.Text = "answer1";
            this.ans1.UseVisualStyleBackColor = true;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(23, 96);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(84, 24);
            this.ans2.TabIndex = 1;
            this.ans2.TabStop = true;
            this.ans2.Text = "answer2";
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(23, 126);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(84, 24);
            this.ans3.TabIndex = 1;
            this.ans3.TabStop = true;
            this.ans3.Text = "answer3";
            this.ans3.UseVisualStyleBackColor = true;
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(23, 156);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(84, 24);
            this.ans4.TabIndex = 1;
            this.ans4.TabStop = true;
            this.ans4.Text = "answer4";
            this.ans4.UseVisualStyleBackColor = true;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(23, 17);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(59, 20);
            this.content.TabIndex = 2;
            this.content.Text = "content";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.content);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(454, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton ans1;
        private System.Windows.Forms.RadioButton ans2;
        private System.Windows.Forms.RadioButton ans3;
        private System.Windows.Forms.RadioButton ans4;
        private System.Windows.Forms.Label content;
    }
}
