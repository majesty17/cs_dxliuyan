using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace cs_dxliuyan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)(numericUpDown1.Value);
            

            string url = "http://www.bjdx.gov.cn/cms/modules/response-viewliuyan.jsp?id=" + value;


            HtmlWeb webClient = new HtmlWeb();

            HtmlDocument doc = null;
            try
            {
                doc= webClient.Load(url);
            }
            catch(Exception ex)
            {
                label_status.Text = ex.Message;
                label_status.ForeColor = Color.Red;
                //MessageBox.Show(ex.Message);
                return;
            }

            HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//td[@colspan='3']");

            if (hrefList != null)
            {
                foreach (HtmlNode href in hrefList)
                {
                    
                    Console.WriteLine(href.InnerHtml);

                }
                if (hrefList.Count >= 6)
                {
                    textBox_sub.Text = hrefList[0].InnerHtml;
                    textBox_date.Text = hrefList[1].InnerHtml;

                    richTextBox_msg.Text = hrefList[2].InnerHtml;
                    richTextBox_reply.Text = hrefList[3].InnerHtml;
                    textBox_reply_date.Text = hrefList[4].InnerHtml;
                    textBox_reply_dept.Text = hrefList[5].InnerHtml;
                }
                label_status.Text = "OK!";
                label_status.ForeColor = Color.Green;
            }
            else
            {
                label_status.Text = "ERROR!";
                label_status.ForeColor = Color.Red;
            }







        }
    }
}
