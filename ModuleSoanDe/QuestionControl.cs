using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercise02
{
    public partial class QuestionControl : UserControl
    {
        public int trueIndexAnswer;
        public BindingList<RadioButton> listAns = new BindingList<RadioButton>();
        public string TrueAnswer;
        public int QuestionType{ get; set; }
        public string Content
        {
            get
            {
                return this.content.Text;
            }
            set
            {             
                content.MaximumSize= new Size(Width,Height);
                content.Text = value;
                SetLocationAnswers();
            }
        }
        public QuestionControl()
        {
            InitializeComponent();
            Controls.Add(content);
            listAns.Add(this.ans1);
            listAns.Add(this.ans2);
            listAns.Add(this.ans3);
            listAns.Add(this.ans4);
            content.AutoSize = true;
            content.Padding = new Padding(0, 0, 50, 0);
            AutoSize = true;
        }
        public void SetSize(int width,int height)
        {
            this.MaximumSize = new Size(width, height);
            this.Size= new Size(width, height);
            this.content.MaximumSize = new Size(width, height);
            this.content.Size = new Size(width, height);


   
        }
        void SetLocationAnswers()
        {     
            for (int i = 0; i < listAns.Count; i++)
            {
                int locationYBelowContent = content.Location.Y + content.Height;
                listAns[i].Location = new Point(listAns[i].Location.X, locationYBelowContent+40*(i+1));
            }   
        }
        
        public bool checkTrueAnswer(int indexAnswer)
        {
            if (indexAnswer == trueIndexAnswer)
                return true;
            return false;
        }
        public bool isTrueAnswer()
        {
            for (int i = 0; i < 4; i++) 
            {
                if(listAns[i].Checked)
                {
                    if(i==trueIndexAnswer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void resetQuestion()
        {
            for (int i = 0; i < listAns.Count; i++)
            {
                listAns[i].Checked = false;
            }
            shuffleAnswer();
        }

        public void shuffleAnswer()
        {
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                int randomIndex1 = r.Next(0, 4);//0 -> 3
                int randomIndex2 = r.Next(0, 4);
                if (randomIndex1 == trueIndexAnswer)
                {
                    trueIndexAnswer = randomIndex2;
                }
                else if (randomIndex2 == trueIndexAnswer)
                {
                    trueIndexAnswer = randomIndex1;
                }
                //swap noi dung cau tra loi
                string temp = listAns[randomIndex1].Text;
                listAns[randomIndex1].Text = listAns[randomIndex2].Text;
                listAns[randomIndex2].Text = temp;
            }
           

        }
    }
}
