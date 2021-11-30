using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ModuleSoanDe.Class;
//reference:https://stackoverflow.com/questions/14473321/generating-random-unique-values-c-sharp
namespace ModuleSoanDe
{
    public partial class Page_TaoDeThi : UserControl
    {

        List<Question> lstCauHoi = new List<Question>();
        List<int> lstViTriCauHoiTuChon = new List<int>();
        public Page_TaoDeThi()
        {
            InitializeComponent();
            Form_Load();

        }
        private void Form_Load()
        {
            //cbx Lua chon
            cbx_LuaChon.Items.Add("Ngẫu nhiên");
            cbx_LuaChon.Items.Add("Tự chọn");
            LoadQuestionFromFileToList("data.xml");
            txt_SoLuongCauHoi.Maximum = lstCauHoi.Count;
            lbl_SoLuongToiDa.Text = $"Tối đa {lstCauHoi.Count.ToString()}";
        }
        private void LoadQuestionFromFileToList(string filePath)
        {
            using (XmlReader xml = XmlReader.Create(filePath))
            {
                xml.ReadToFollowing("questions");
                while (xml.ReadToFollowing("question"))
                {
                    Question q = new Question();
                    xml.MoveToAttribute("field");
                    q.Field = xml.Value;
                    xml.MoveToAttribute("answerCount");
                    int answerCount = int.Parse(xml.Value);
                    xml.ReadToFollowing("content");
                    q.Content = xml.ReadElementContentAsString();
                    for (int i = 0; i < answerCount; i++)
                    {
                        xml.ReadToFollowing("answer");
                        q.Answers.Add(xml.ReadElementContentAsString());
                    }
                    xml.ReadToFollowing("trueanswer");
                    q.TrueAnswer = xml.ReadElementContentAsString();
                    lstCauHoi.Add(q);
                }
            }
        }
        private void show(object s)
        {
            MessageBox.Show(s.ToString());
        }
        private void DisplayViewOptionNgauNhien()
        {
            lbl_SoLuongCauHoi.Visible = true;
            txt_SoLuongCauHoi.Visible = true;
            lbl_SoLuongToiDa.Visible = true;
            clbx_CauHoi.Visible = false;
        }
        private void DisplayViewOptionTuChon()
        {
            lbl_SoLuongCauHoi.Visible = false;
            txt_SoLuongCauHoi.Visible = false;
            lbl_SoLuongToiDa.Visible = false;
            clbx_CauHoi.Visible = true;
            FillCheckedListBoxCauHoi();
        }
        private void FillCheckedListBoxCauHoi()
        {
            foreach (var q in lstCauHoi)
            {
                clbx_CauHoi.Items.Add(q.Content);
            }
        }
        private bool CheckDuplicateIndex(int value, List<int> lstIndex)
        {
            foreach (var i in lstIndex)
            {
                if (value == i)
                {
                    return true;
                }
            }
            return false;
        }
        private void cbx_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_LuaChon.SelectedItem.ToString() == "Ngẫu nhiên")
            {
                DisplayViewOptionNgauNhien();
            }
            else
            {
                DisplayViewOptionTuChon();
            }
        }

        private void clbx_CauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexChon = clbx_CauHoi.SelectedIndex;
            if (!CheckDuplicateIndex(indexChon, lstViTriCauHoiTuChon))
                lstViTriCauHoiTuChon.Add(indexChon);
            else
                lstViTriCauHoiTuChon.Remove(indexChon);

        }
        private List<int> CreateRandomDistinctIndexList(int maxValue,int amount)
        {
            int n = 0;
            Random r = new Random();
            List<int> lstIndex = new List<int>();
            while (n <= amount)
            {
                int number = r.Next(0, maxValue);
                if(!lstIndex.Contains(number))
                {
                    lstIndex.Add(number);
                    n++;
                }
                
            }
            return lstIndex;
        }
        private void btn_TaoDeThi_Click(object sender, EventArgs e)
        {
            string fileName = "dethi.xml";
            string historyFileName = "history.xml";
            int soLuongCauHoi = int.Parse(txt_SoLuongCauHoi.Value.ToString());
            using (XmlWriter xmlTest = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true }))
            {
                xmlTest.WriteStartElement("questions");
                xmlTest.WriteAttributeString("month", DateTime.Now.ToString("MM"));
                if (cbx_LuaChon.SelectedItem.ToString() == "Ngẫu nhiên")
                {
                    List<int> lstIndex = CreateRandomDistinctIndexList(lstCauHoi.Count, soLuongCauHoi);
                    for (int i = 0; i < soLuongCauHoi; i++)
                    {
                        int indexChon = lstIndex[i];
                        xmlTest.WriteStartElement("question");
                        xmlTest.WriteAttributeString("field", lstCauHoi[indexChon].Field);
                        xmlTest.WriteAttributeString("answerCount", lstCauHoi[indexChon].Answers.Count.ToString());
                        xmlTest.WriteStartElement("content");
                        xmlTest.WriteValue(lstCauHoi[indexChon].Content);
                        xmlTest.WriteEndElement();
                        foreach (var answer in lstCauHoi[indexChon].Answers)
                        {
                            xmlTest.WriteStartElement("answer");
                            xmlTest.WriteValue(answer);
                            xmlTest.WriteEndElement();
                        }
                        xmlTest.WriteEndElement();//end for element "question"
                    }
                }
                else
                {
                    for (int i = 0; i < lstViTriCauHoiTuChon.Count; i++)
                    {
                        int indexChon = lstViTriCauHoiTuChon[i];
                        xmlTest.WriteStartElement("question");
                        xmlTest.WriteAttributeString("field", lstCauHoi[indexChon].Field);
                        xmlTest.WriteAttributeString("answerCount", lstCauHoi[indexChon].Answers.Count.ToString());
                        xmlTest.WriteStartElement("content");
                        xmlTest.WriteValue(lstCauHoi[indexChon].Content);
                        xmlTest.WriteEndElement();
                        foreach (var answer in lstCauHoi[indexChon].Answers)
                        {
                            xmlTest.WriteStartElement("answer");
                            xmlTest.WriteValue(answer);
                            xmlTest.WriteEndElement();
                        }
                        xmlTest.WriteEndElement();//end for element "question"
                    }
                }
                xmlTest.WriteEndElement();//end for element "questions"             
            }
            using (XmlWriter xml = XmlWriter.Create(historyFileName, new XmlWriterSettings() { Indent = true }))
            {
                xml.WriteStartElement("questions");
                foreach (var q in lstCauHoi)
                {
                    xml.WriteStartElement("question");
                    xml.WriteStartElement("content");
                    xml.WriteValue(q.Content);
                    xml.WriteEndElement();
                    xml.WriteStartElement("trueanswer");
                    xml.WriteValue(q.TrueAnswer);
                    xml.WriteEndElement();
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }
        }



    }
}
