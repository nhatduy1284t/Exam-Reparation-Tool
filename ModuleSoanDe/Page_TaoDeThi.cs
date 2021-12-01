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
using System.Xml.Linq;
using ModuleSoanDe.Class;

//reference:https://stackoverflow.com/questions/14473321/generating-random-unique-values-c-sharp
//https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
namespace ModuleSoanDe
{
    //public class WrapListBox : ListBox
    //{
    //    private void WrapListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
    //    {
    //        e.DrawBackground();
    //        //Let's declare a brush, so that we can color the items that are added in the listbox.
    //        Brush myBrush = default(Brush);
    //        if ((e.State == DrawItemState.Selected))
    //        {
    //            e.Graphics.FillRectangle(Brushes.LightCyan, e.Bounds);
    //        }
    //        //Determine the color of the brush to draw each item based on the index of the item to draw.
    //        switch ((e.Index) % 3)
    //        {
    //            case 0:
    //                myBrush = Brushes.Chocolate;
    //                break;
    //            case 1:
    //                myBrush = Brushes.MediumSlateBlue;
    //                break;
    //            case 2:
    //                myBrush = Brushes.Teal;
    //                break;
    //        }
    //        // Draw the current item text based on the current Font and the custom brush settings.
    //        e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, myBrush,
    //         new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
    //        //If the ListBox has focus, draw a focus rectangle around the selected item.
    //        e.DrawFocusRectangle();
    //    }
    //    public WrapListBox()
    //    {
    //        MeasureItem += WrapListBox_MeasureItem;
    //        DrawItem += WrapListBox_DrawItem;
    //        //This is super important. If you miss it... you won't be able to Draw the item.
    //        //If you make it OwnerDrawFixed you won't be able to measure the item.
    //        this.DrawMode = DrawMode.OwnerDrawVariable;
            
            
    //    }
    //    private void WrapListBox_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
    //    {
    //        Graphics g = e.Graphics;
    //        //We will get the size of the string which we are about to draw,
    //        //so that we could set the ItemHeight and ItemWidth property
    //        SizeF size = g.MeasureString(this.Items[e.Index].ToString(), this.Font, this.Width - 5 - SystemInformation.VerticalScrollBarWidth);
    //        e.ItemHeight = Convert.ToInt32(size.Height) + 5;
    //        e.ItemWidth = Convert.ToInt32(size.Width) + 5;
    //    }
    //}
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
            cbx_LuaChon.SelectedIndex = 0;
            LoadQuestionFromFileToList("data.xml");
            txt_SoLuongCauHoi.Maximum = lstCauHoi.Count;
            lbl_SoLuongToiDa.Text = $"Tối đa {lstCauHoi.Count.ToString()}";
            FillCheckedListBoxCauHoi();
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
            else if (cbx_LuaChon.SelectedItem.ToString() == "Tự chọn")
            {
                DisplayViewOptionTuChon();

            }
        }

        private void clbx_CauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexChon = clbx_CauHoi.SelectedIndex;
            if (!lstViTriCauHoiTuChon.Contains(indexChon))
                lstViTriCauHoiTuChon.Add(indexChon);
            else
                lstViTriCauHoiTuChon.Remove(indexChon);
        }
        private List<int> CreateRandomDistinctIndexList(int maxValue, int amount)
        {
            int n = 0;
            Random r = new Random();
            List<int> lstIndex = new List<int>();
            while (n <= amount)
            {
                int number = r.Next(0, maxValue);
                if (!lstIndex.Contains(number))
                {
                    lstIndex.Add(number);
                    n++;
                }
            }
            return lstIndex;
        }
        private bool WriteFileHistory()
        {
            string historyFileName = "history.xml";
            if (File.Exists(historyFileName))
            {
                using (XmlReader xmlReader = XmlReader.Create(historyFileName))
                    while (xmlReader.ReadToFollowing("questions"))
                    {
                        xmlReader.MoveToAttribute("code");
                        if (xmlReader.Value == txt_MaDe.Text)
                        {
                            DialogResult dialogResult = MessageBox.Show($"Đã tồn tại mã đề {txt_MaDe.Text}", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                break;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return false;
                            }
                        }
                    }
                XDocument doc = XDocument.Load(historyFileName);
                XElement questions = new XElement("questions",
                    new XAttribute("month", DateTime.Now.ToString("MM")),
                    new XAttribute("code", txt_MaDe.Text));

                foreach (var q in lstCauHoi)
                {
                    questions.Add(new XElement("question"));
                    questions.Add(new XElement("content", q.Content));
                    questions.Add(new XElement("trueanswer", q.TrueAnswer));
                }
                doc.Root.Add(questions);
                doc.Save(historyFileName, SaveOptions.None);
            }
            else
                using (XmlWriter xml = XmlWriter.Create(historyFileName, new XmlWriterSettings() { Indent = true }))
                {
                    xml.WriteStartElement("history");
                    xml.WriteStartElement("questions");
                    xml.WriteAttributeString("month", DateTime.Now.ToString("MM"));
                    xml.WriteAttributeString("code", txt_MaDe.Text);

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
                    xml.WriteEndElement();
                }
            return true;
        }
        private void WriteFileTest()
        {
            int soLuongCauHoi = int.Parse(txt_SoLuongCauHoi.Value.ToString());
            string maDe = txt_MaDe.Text;
            string fileName = $"dethi-{maDe}.xml";
            string luaChon = cbx_LuaChon.SelectedItem.ToString();
            using (XmlWriter xml = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true }))
            {
                xml.WriteStartElement("questions");
                xml.WriteAttributeString("month", DateTime.Now.ToString("MM"));
                xml.WriteAttributeString("code", maDe);
                if (luaChon == "Ngẫu nhiên")
                {
                    List<int> lstIndex = CreateRandomDistinctIndexList(lstCauHoi.Count, soLuongCauHoi);
                    for (int i = 0; i < soLuongCauHoi; i++)
                    {
                        int indexChon = lstIndex[i];
                        xml.WriteStartElement("question");
                        xml.WriteAttributeString("field", lstCauHoi[indexChon].Field);
                        xml.WriteAttributeString("answerCount", lstCauHoi[indexChon].Answers.Count.ToString());
                        xml.WriteStartElement("content");
                        xml.WriteValue(lstCauHoi[indexChon].Content);
                        xml.WriteEndElement();
                        foreach (var answer in lstCauHoi[indexChon].Answers)
                        {
                            xml.WriteStartElement("answer");
                            xml.WriteValue(answer);
                            xml.WriteEndElement();
                        }
                        xml.WriteEndElement();//end for element "question"
                    }
                }
                else
                {
                    for (int i = 0; i < lstViTriCauHoiTuChon.Count; i++)
                    {
                        int indexChon = lstViTriCauHoiTuChon[i];
                        xml.WriteStartElement("question");
                        xml.WriteAttributeString("field", lstCauHoi[indexChon].Field);
                        xml.WriteAttributeString("answerCount", lstCauHoi[indexChon].Answers.Count.ToString());
                        xml.WriteStartElement("content");
                        xml.WriteValue(lstCauHoi[indexChon].Content);
                        xml.WriteEndElement();
                        foreach (var answer in lstCauHoi[indexChon].Answers)
                        {
                            xml.WriteStartElement("answer");
                            xml.WriteValue(answer);
                            xml.WriteEndElement();
                        }
                        xml.WriteEndElement();//end for element "question"
                    }
                }
                xml.WriteEndElement();//end for element "questions"   
            }
        }
        private void btn_TaoDeThi_Click(object sender, EventArgs e)
        {
            if (WriteFileHistory())
            {
                WriteFileTest();
            }
        }
    }
}
