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
        List<Control> menuControls = new List<Control>();
        public frmMain()
        {
            InitializeComponent();
            foreach (Control c in Controls)
            {
                menuControls.Add(c);
            }
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
                case Page.CHAM_BAI:
                    Controls.Add(new Page_ChamBai());
                    break;           
            }      
        }
     
        private void ClearPage()
        {
            btn_QuayLai.Visible = !btn_QuayLai.Visible;
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if(Controls[i]!=btn_QuayLai)
                    Controls.Remove(Controls[i]);
            }
        }
        private void DisplayMenu()
        {
            foreach (Control c in menuControls)
            {
                Controls.Add(c);
            }
        }
        private void btn_ChamBai_Click(object sender, EventArgs e)
        {
            DisplayPage(Page.CHAM_BAI);
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            ClearPage();
            DisplayMenu();
        }
    }
}
