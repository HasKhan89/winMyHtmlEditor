using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winMyHtmlEditor
{
    public partial class HtmlListForm : Form
    {
        public HtmlListForm()
        {
            InitializeComponent();
        }

        public List<string> Degerlerim { get; set; }

        private void ListboxDoldur()
        {
            lstDegerler.Items.Clear();

            foreach (string item in Degerlerim)
            {
                lstDegerler.Items.Add(item);
            }
        }


        private void HtmlListForm_Load(object sender, EventArgs e)
        {
            Degerlerim = new List<string>();

            txtDeger.Clear();
            txtDeger.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Degerlerim.Add(txtDeger.Text);
            ListboxDoldur();

            txtDeger.Clear();
            txtDeger.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDegerler.SelectedIndex > -1)
            {
                Degerlerim.RemoveAt(lstDegerler.SelectedIndex);
                ListboxDoldur();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
