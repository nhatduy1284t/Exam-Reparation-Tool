﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleThiTracNghiem
{
    public partial class frmMain : Form
    {
        string xmlFilePath;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_ChonDe_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon tap tin .xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = dlg.FileName;
                lbl_De.Text = Path.GetFileName(xmlFilePath);
                lbl_De.Visible = true;
            }
        }
        private void DisplayPage(string page)
        {
            ClearPage();

            switch (page)
            {
                case Page.LAM_BAI:
                    {
                        var page_LamBai = new Page_LamBai(xmlFilePath);          
                        page_LamBai.name = txt_HoTen.Text;
                        page_LamBai.id = txt_MaNhanVien.Text;
                        Controls.Add(page_LamBai);
                        MessageBox.Show(page_LamBai.Location.Y.ToString());
                    }
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
        private bool CheckFillInfo()
        {
            if (txt_HoTen.Text == "" || txt_MaNhanVien.Text == "")
            {
                MessageBox.Show("Hãy điền đầy thủ thông tin trước khi bắt đầu làm bài!");
                return false;
            }
            return true;
        }
        private bool CheckSelectedFile()
        {
            if(xmlFilePath==null)
            {
                MessageBox.Show("Chưa chọn file đề thi!");
                return false;
            }
            return true;
        }
        private void btn_BatDau_Click(object sender, EventArgs e)
        {
            
            if (CheckFillInfo() && CheckSelectedFile())
                DisplayPage(Page.LAM_BAI);         
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            //Controls[0].MaximumSize = Controls[0].Parent.MaximumSize;
            //Controls[0].Size = new Size(Controls[0].Parent.Size.Width-30, this.Size.Height-30);
            
        }
    }
}
