using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModuleSoanDe
{
    
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
    
        }


        private void btn_SoanCauHoi_Click(object sender, EventArgs e)
        {
            DisplayPage(Page.SOAN_CAU_HOI);
        }
        private void btn_TaoBaiThi_Click(object sender, EventArgs e)
        {
            DisplayPage(Page.TAO_DE_THI);
        }
        private void DisplayPage(string page)
        {
            ClearPage();
       
            switch (page)
            {
                case Page.SOAN_CAU_HOI:                  
                        Controls.Add(new Page_SoanCauHoi());                   
                    break;
                case Page.TAO_DE_THI:
                    Controls.Add(new Page_TaoDeThi());
                    break;
            }

        }
        private void ClearPage()
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Controls.Remove(Controls[i]);
            }
        }

       
    }
}
