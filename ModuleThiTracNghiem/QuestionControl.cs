using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//refer:https://stackoverflow.com/questions/1204804/word-wrap-for-a-label-in-windows-forms
namespace ModuleThiTracNghiem
{
    public partial class QuestionControl : UserControl
    {
        public string Content
        {
            get
            {
                return lbl_content.Text;
            }
            set
            {
                lbl_content.Text = value;
            }
        }
        public List<RadioButton> Answers = new List<RadioButton>();
        public CheckBox cbNotice = new CheckBox();
        public QuestionControl()
        {
            InitializeComponent();
            SetContentSizeToParentSize();

        }

        public void SetContentSizeToParentSize()
        {
            lbl_content.MaximumSize = new Size(this.Size.Width,this.Size.Height);
            lbl_content.Size = this.Size;
            lbl_content.AutoSize = true;
        }
        public void SetSizeToParentSize()
        {         
            this.Size = new Size(Parent.ClientSize.Width-25,Parent.ClientSize.Height);
            SetContentSizeToParentSize();
        }
        public void SetLocationAnswers()
        {
            for (int i = 0; i < Answers.Count; i++)
            {
                int locationYBelowContent = lbl_content.Location.Y + lbl_content.Height;
                Answers[i].Location = new Point(lbl_content.Location.X, locationYBelowContent + 40 * (i + 1));
                Answers[i].AutoSize = true;
                Controls.Add(Answers[i]);
                Answers[i].Size = new Size(Answers[i].Parent.Size.Width, Answers[i].Size.Height);
            }
            SetLocationCheckBoxNotice();
        }
        public void SetLocationCheckBoxNotice()
        {
            Point vt = Answers[Answers.Count - 1].Location;
            cbNotice.Location = new Point(vt.X, vt.Y+50);
            cbNotice.AutoSize = true;
            cbNotice.Text = "Đánh dấu lưu ý";
            Controls.Add(cbNotice);
        }
        public bool IsDone()
        {
            foreach (var ans in Answers)
            {
                if (ans.Checked)
                    return true;
            }
            return false;
        }
        public string GetSelectedAnswer()
        {
            foreach (var ans in Answers)
            {
                if(ans.Checked)
                    return ans.Text;
            }
            return "";
        }
    }
}
