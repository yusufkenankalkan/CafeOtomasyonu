namespace CafeOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            katEkleToolStripMenuItem = new ToolStripMenuItem();
            katlariGoruntuleToolStripMenuItem = new ToolStripMenuItem();
            menüİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            urunKategoriEkleToolStripMenuItem = new ToolStripMenuItem();
            urunEkleToolStripMenuItem = new ToolStripMenuItem();
            urunDüzenleToolStripMenuItem = new ToolStripMenuItem();
            urunSilToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { katEkleToolStripMenuItem, katlariGoruntuleToolStripMenuItem, menüİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(464, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // katEkleToolStripMenuItem
            // 
            katEkleToolStripMenuItem.Name = "katEkleToolStripMenuItem";
            katEkleToolStripMenuItem.Size = new Size(60, 22);
            katEkleToolStripMenuItem.Text = "Kat Ekle";
            katEkleToolStripMenuItem.Click += katEkleToolStripMenuItem_Click_1;
            // 
            // katlariGoruntuleToolStripMenuItem
            // 
            katlariGoruntuleToolStripMenuItem.Name = "katlariGoruntuleToolStripMenuItem";
            katlariGoruntuleToolStripMenuItem.Size = new Size(67, 22);
            katlariGoruntuleToolStripMenuItem.Text = "Anasayfa";
            katlariGoruntuleToolStripMenuItem.Click += katlariGoruntuleToolStripMenuItem_Click;
            // 
            // menüİşlemleriToolStripMenuItem
            // 
            menüİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { urunKategoriEkleToolStripMenuItem, urunEkleToolStripMenuItem, urunDüzenleToolStripMenuItem, urunSilToolStripMenuItem });
            menüİşlemleriToolStripMenuItem.Name = "menüİşlemleriToolStripMenuItem";
            menüİşlemleriToolStripMenuItem.Size = new Size(97, 22);
            menüİşlemleriToolStripMenuItem.Text = "Menü İşlemleri";
            // 
            // urunKategoriEkleToolStripMenuItem
            // 
            urunKategoriEkleToolStripMenuItem.Name = "urunKategoriEkleToolStripMenuItem";
            urunKategoriEkleToolStripMenuItem.Size = new Size(171, 22);
            urunKategoriEkleToolStripMenuItem.Text = "Ürün Kategori Ekle";
            urunKategoriEkleToolStripMenuItem.Click += urunKategoriEkleToolStripMenuItem_Click;
            // 
            // urunEkleToolStripMenuItem
            // 
            urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            urunEkleToolStripMenuItem.Size = new Size(171, 22);
            urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            urunEkleToolStripMenuItem.Click += urunEkleToolStripMenuItem_Click;
            // 
            // urunDüzenleToolStripMenuItem
            // 
            urunDüzenleToolStripMenuItem.Name = "urunDüzenleToolStripMenuItem";
            urunDüzenleToolStripMenuItem.Size = new Size(171, 22);
            urunDüzenleToolStripMenuItem.Text = "Ürün Düzenle";
            // 
            // urunSilToolStripMenuItem
            // 
            urunSilToolStripMenuItem.Name = "urunSilToolStripMenuItem";
            urunSilToolStripMenuItem.Size = new Size(171, 22);
            urunSilToolStripMenuItem.Text = "Ürün Sil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 325);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem katEkleToolStripMenuItem;
        private ToolStripMenuItem katlariGoruntuleToolStripMenuItem;
        private ToolStripMenuItem menüİşlemleriToolStripMenuItem;
        private ToolStripMenuItem urunKategoriEkleToolStripMenuItem;
        private ToolStripMenuItem urunDüzenleToolStripMenuItem;
        private ToolStripMenuItem urunSilToolStripMenuItem;
        private ToolStripMenuItem urunEkleToolStripMenuItem;
    }
}