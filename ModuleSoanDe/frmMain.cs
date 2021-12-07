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
//https://helpex.vn/question/cach-dat-z-order-cua-control-bang-winforms-60d203b1853e4fd7cbc7ff6d
namespace ModuleSoanDe
{
    
    public partial class frmMain : Form
    {
        List<Control> menuControls = new List<Control>();
        Size initialSize;
        string displayingPage;
        public frmMain()
        {
            InitializeComponent();
            initialSize = this.Size;
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
                    {                  
                        Page_SoanCauHoi pageControl = new Page_SoanCauHoi();
                        Controls.Add(pageControl);
                        //pageControl.SetSizeToParent();
             
                    }    
                    break;
                case Page.TAO_DE_THI:
                    {
                        Page_TaoDeThi pageControl = new Page_TaoDeThi();
                        Controls.Add(pageControl);
                        //pageControl.SetSizeToParent();
                    }
                    break;
                case Page.CHAM_BAI:
                    {
                        Page_ChamBai pageControl = new Page_ChamBai();
                        Controls.Add(pageControl);
                        //pageControl.SetSizeToParent();
                    }
                    break;           
            }
            displayingPage = page;

        }
     
        private void ClearPage()
        {
            btn_QuayLai.Visible = !btn_QuayLai.Visible;
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if(Controls[i]!=btn_QuayLai )
                    Controls.Remove(Controls[i]);
            }
            //this.Size = initialSize;
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

        private void frmMain_Resize(object sender, EventArgs e)
        {
            
            //if(displayingPage!=null)
            //{
            //    switch (displayingPage)
            //    {
            //        case Page.SOAN_CAU_HOI:
            //            {
                            
            //                Page_SoanCauHoi pageControl = (Page_SoanCauHoi)Controls[1];                       
            //                pageControl.SetSizeToParent();
            //            }
            //            break;
            //        case Page.TAO_DE_THI:
            //            {
            //                Page_TaoDeThi pageControl = (Page_TaoDeThi)Controls[0];
            //                //pageControl.SetSizeToParent();
            //            }
            //            break;
            //        case Page.CHAM_BAI:
            //            {
            //                Page_ChamBai pageControl = (Page_ChamBai)Controls[0];
            //                //pageControl.SetSizeToParent();
            //            }
            //            break;
            //    }
            //}
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            //if (displayingPage!=null && WindowState == FormWindowState.Normal)
            //{
                //this.AutoSize = false;
            //}
            //if(WindowState == FormWindowState.Maximized)
            //{
            //    AutoSize = false;
            //}
        }
    }
}
