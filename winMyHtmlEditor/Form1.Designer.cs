namespace winMyHtmlEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtHtmlKod = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webTarayici = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatirAtla = new System.Windows.Forms.ToolStripButton();
            this.btnLink = new System.Windows.Forms.ToolStripButton();
            this.btnH = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnH1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnH2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnH3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnH4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnH5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnH6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnP = new System.Windows.Forms.ToolStripButton();
            this.btnOL = new System.Windows.Forms.ToolStripButton();
            this.btnUL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnText = new System.Windows.Forms.ToolStripButton();
            this.btnButton = new System.Windows.Forms.ToolStripButton();
            this.btnCheckbox = new System.Windows.Forms.ToolStripButton();
            this.btnRadio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTable = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCalistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(597, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(597, 285);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(597, 335);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtHtmlKod);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(597, 285);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtHtmlKod
            // 
            this.txtHtmlKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHtmlKod.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHtmlKod.Location = new System.Drawing.Point(0, 0);
            this.txtHtmlKod.Name = "txtHtmlKod";
            this.txtHtmlKod.Size = new System.Drawing.Size(272, 285);
            this.txtHtmlKod.TabIndex = 0;
            this.txtHtmlKod.Text = "<!-- Buradaki kodlar HTML kodları olmalıdır.. -->";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.webTarayici);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 285);
            this.panel1.TabIndex = 0;
            // 
            // webTarayici
            // 
            this.webTarayici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webTarayici.Location = new System.Drawing.Point(0, 0);
            this.webTarayici.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTarayici.Name = "webTarayici";
            this.webTarayici.Size = new System.Drawing.Size(319, 283);
            this.webTarayici.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.toolStripSeparator1,
            this.btnSatirAtla,
            this.btnLink,
            this.btnH,
            this.btnP,
            this.btnOL,
            this.btnUL,
            this.toolStripSeparator2,
            this.btnText,
            this.btnButton,
            this.btnCheckbox,
            this.btnRadio,
            this.toolStripSeparator3,
            this.btnTable});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(389, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = global::winMyHtmlEditor.Properties.Resources.b_24;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = global::winMyHtmlEditor.Properties.Resources.i_24;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = global::winMyHtmlEditor.Properties.Resources.u_24;
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSatirAtla
            // 
            this.btnSatirAtla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSatirAtla.Image = global::winMyHtmlEditor.Properties.Resources.br_24;
            this.btnSatirAtla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatirAtla.Name = "btnSatirAtla";
            this.btnSatirAtla.Size = new System.Drawing.Size(23, 22);
            this.btnSatirAtla.Text = "Satır Atla";
            this.btnSatirAtla.Click += new System.EventHandler(this.btnSatirAtla_Click);
            // 
            // btnLink
            // 
            this.btnLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLink.Image = global::winMyHtmlEditor.Properties.Resources.a_24;
            this.btnLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(23, 22);
            this.btnLink.Text = "Link";
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnH
            // 
            this.btnH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnH1,
            this.btnH2,
            this.btnH3,
            this.btnH4,
            this.btnH5,
            this.btnH6});
            this.btnH.Image = global::winMyHtmlEditor.Properties.Resources.h1_24;
            this.btnH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(29, 22);
            this.btnH.Text = "toolStripDropDownButton1";
            // 
            // btnH1
            // 
            this.btnH1.Image = global::winMyHtmlEditor.Properties.Resources.h1_24;
            this.btnH1.Name = "btnH1";
            this.btnH1.Size = new System.Drawing.Size(152, 22);
            this.btnH1.Tag = "1";
            this.btnH1.Text = "H1";
            this.btnH1.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnH2
            // 
            this.btnH2.Image = global::winMyHtmlEditor.Properties.Resources.h2_24;
            this.btnH2.Name = "btnH2";
            this.btnH2.Size = new System.Drawing.Size(152, 22);
            this.btnH2.Tag = "2";
            this.btnH2.Text = "H2";
            this.btnH2.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnH3
            // 
            this.btnH3.Image = global::winMyHtmlEditor.Properties.Resources.h3_24;
            this.btnH3.Name = "btnH3";
            this.btnH3.Size = new System.Drawing.Size(152, 22);
            this.btnH3.Tag = "3";
            this.btnH3.Text = "H3";
            this.btnH3.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnH4
            // 
            this.btnH4.Image = global::winMyHtmlEditor.Properties.Resources.h4_24;
            this.btnH4.Name = "btnH4";
            this.btnH4.Size = new System.Drawing.Size(152, 22);
            this.btnH4.Tag = "4";
            this.btnH4.Text = "H4";
            this.btnH4.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnH5
            // 
            this.btnH5.Image = global::winMyHtmlEditor.Properties.Resources.h5_24;
            this.btnH5.Name = "btnH5";
            this.btnH5.Size = new System.Drawing.Size(152, 22);
            this.btnH5.Tag = "5";
            this.btnH5.Text = "H5";
            this.btnH5.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnH6
            // 
            this.btnH6.Image = global::winMyHtmlEditor.Properties.Resources.h6_24;
            this.btnH6.Name = "btnH6";
            this.btnH6.Size = new System.Drawing.Size(152, 22);
            this.btnH6.Tag = "6";
            this.btnH6.Text = "H6";
            this.btnH6.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnP
            // 
            this.btnP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnP.Image = global::winMyHtmlEditor.Properties.Resources.p_24;
            this.btnP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(23, 22);
            this.btnP.Text = "toolStripButton1";
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnOL
            // 
            this.btnOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOL.Image = global::winMyHtmlEditor.Properties.Resources.ol_24;
            this.btnOL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOL.Name = "btnOL";
            this.btnOL.Size = new System.Drawing.Size(23, 22);
            this.btnOL.Text = "toolStripButton2";
            this.btnOL.Click += new System.EventHandler(this.btnOL_Click);
            // 
            // btnUL
            // 
            this.btnUL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUL.Image = global::winMyHtmlEditor.Properties.Resources.ul_24;
            this.btnUL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUL.Name = "btnUL";
            this.btnUL.Size = new System.Drawing.Size(23, 22);
            this.btnUL.Text = "toolStripButton3";
            this.btnUL.Click += new System.EventHandler(this.btnUL_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnText
            // 
            this.btnText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnText.Image = global::winMyHtmlEditor.Properties.Resources.text_24;
            this.btnText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(23, 22);
            this.btnText.Text = "toolStripButton4";
            // 
            // btnButton
            // 
            this.btnButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnButton.Image = global::winMyHtmlEditor.Properties.Resources.button_24;
            this.btnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(23, 22);
            this.btnButton.Text = "toolStripButton5";
            // 
            // btnCheckbox
            // 
            this.btnCheckbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheckbox.Image = global::winMyHtmlEditor.Properties.Resources.checkbox_24;
            this.btnCheckbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckbox.Name = "btnCheckbox";
            this.btnCheckbox.Size = new System.Drawing.Size(23, 22);
            this.btnCheckbox.Text = "toolStripButton6";
            // 
            // btnRadio
            // 
            this.btnRadio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRadio.Image = global::winMyHtmlEditor.Properties.Resources.radio_24;
            this.btnRadio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(23, 22);
            this.btnRadio.Text = "toolStripButton7";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTable
            // 
            this.btnTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTable.Image = global::winMyHtmlEditor.Properties.Resources.table_24;
            this.btnTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(23, 22);
            this.btnTable.Text = "toolStripButton8";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCalistir});
            this.toolStrip2.Location = new System.Drawing.Point(115, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(35, 25);
            this.toolStrip2.TabIndex = 1;
            // 
            // btnCalistir
            // 
            this.btnCalistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalistir.Image = global::winMyHtmlEditor.Properties.Resources._1455549440_go_next;
            this.btnCalistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(23, 22);
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 357);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox txtHtmlKod;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCalistir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webTarayici;
        private System.Windows.Forms.ToolStripButton btnSatirAtla;
        private System.Windows.Forms.ToolStripButton btnLink;
        private System.Windows.Forms.ToolStripDropDownButton btnH;
        private System.Windows.Forms.ToolStripMenuItem btnH1;
        private System.Windows.Forms.ToolStripMenuItem btnH2;
        private System.Windows.Forms.ToolStripMenuItem btnH3;
        private System.Windows.Forms.ToolStripMenuItem btnH4;
        private System.Windows.Forms.ToolStripMenuItem btnH5;
        private System.Windows.Forms.ToolStripMenuItem btnH6;
        private System.Windows.Forms.ToolStripButton btnP;
        private System.Windows.Forms.ToolStripButton btnOL;
        private System.Windows.Forms.ToolStripButton btnUL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnText;
        private System.Windows.Forms.ToolStripButton btnButton;
        private System.Windows.Forms.ToolStripButton btnCheckbox;
        private System.Windows.Forms.ToolStripButton btnRadio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnTable;


    }
}

