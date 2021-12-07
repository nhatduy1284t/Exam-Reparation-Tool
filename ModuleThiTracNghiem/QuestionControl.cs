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
                SetContentSizeToParentSize();
            }
        }
        public List<RadioButton> Answers = new List<RadioButton>();
        public CheckBox cbNotice = new CheckBox();
        public QuestionControl()
        {
            InitializeComponent();

            
        }

        public void SetContentSizeToParentSize()
        {
            lbl_content.MaximumSize = new Size(this.Size.Width, this.Height);
            //lbl_content.Width = this.Size.Width;
        }
        public void SetSizeToParentSize()
        {
            this.Size = new Size(Parent.Size.Width -5, this.Parent.Height -5);
            SetContentSizeToParentSize();
        }
        public void SetLocationAnswers()
        {
            for (int i = 0; i < Answers.Count; i++)
            {
                
                int locationYBelowContent = lbl_content.Location.Y + lbl_content.Height;              
                Controls.Add(Answers[i]);
                Answers[i].Location = new Point(lbl_content.Location.X, locationYBelowContent + 60 * (i + 1));
                Answers[i].AutoSize = false;
                Answers[i].MaximumSize= new Size(this.Width+700,this.Height+400);
                //Answers[i].MinimumSize = new Size(this.Width, 55);
                Answers[i].Size = new Size(this.Width, 55);
        
            }
            SetLocationCheckBoxNotice();
        }
        public void SetLocationCheckBoxNotice()
        {
            Point vt = Answers[Answers.Count - 1].Location;
            cbNotice.Location = new Point(vt.X, vt.Y+60);
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
