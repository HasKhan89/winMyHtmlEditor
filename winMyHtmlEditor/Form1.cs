using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winMyHtmlEditor.Classes;

namespace winMyHtmlEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            HtmlBold bold = new HtmlBold();
            bold.Value = "Hasan Kahraman";
            txtHtmlKod.AppendText(bold.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);           
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            HtmlItalic italic = new HtmlItalic();
            italic.Value = "Hasan Kahraman";
            txtHtmlKod.AppendText(italic.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            HtmlUnderline underline = new HtmlUnderline();
            underline.Value = "Hasan Kahraman";
            txtHtmlKod.AppendText(underline.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHtmlKod.AppendText(Environment.NewLine);
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            webTarayici.DocumentText = txtHtmlKod.Text;
        }

        private void btnSatirAtla_Click(object sender, EventArgs e)
        {
            HtmlBreak breaking = new HtmlBreak(); 
            txtHtmlKod.AppendText(breaking.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            HtmlLink link = new HtmlLink();
            link.Href = "http://www.google.com";
            link.Title = "Google'a git!";
            link.Value = "Google Sayfası";

            txtHtmlKod.AppendText(link.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            HtmlParagraph para = new HtmlParagraph();
            para.Value = "Bu bir paragraftır.";

            txtHtmlKod.AppendText(para.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;

            HtmlH h = new HtmlH();
            h.HNo = int.Parse(btn.Tag.ToString());
            h.Value = "Heading";

            txtHtmlKod.AppendText(h.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void btnOL_Click(object sender, EventArgs e)
        {
            HtmlOL ol = new HtmlOL();
            

            HtmlListForm form = new HtmlListForm();
            form.ShowDialog();

            foreach (string item in form.Degerlerim)
            {
                ol.Items.Add(item);
            }

            txtHtmlKod.AppendText(ol.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }

        private void btnUL_Click(object sender, EventArgs e)
        {
            HtmlUL ul = new HtmlUL();
            

            HtmlListForm form = new HtmlListForm();
            form.ShowDialog();

            foreach (string item in form.Degerlerim)
            {
                ul.Items.Add(item);
            }

            txtHtmlKod.AppendText(ul.GetHtmlString());
            txtHtmlKod.AppendText(Environment.NewLine);
        }
    }
}
