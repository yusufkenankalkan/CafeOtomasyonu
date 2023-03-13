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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.katEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katlariGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunKategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katEkleToolStripMenuItem,
            this.katlariGoruntuleToolStripMenuItem,
            this.menüİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // katEkleToolStripMenuItem
            // 
            this.katEkleToolStripMenuItem.Name = "katEkleToolStripMenuItem";
            this.katEkleToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.katEkleToolStripMenuItem.Text = "Kat Ekle";
            this.katEkleToolStripMenuItem.Click += new System.EventHandler(this.katEkleToolStripMenuItem_Click_1);
            // 
            // katlariGoruntuleToolStripMenuItem
            // 
            this.katlariGoruntuleToolStripMenuItem.Name = "katlariGoruntuleToolStripMenuItem";
            this.katlariGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.katlariGoruntuleToolStripMenuItem.Text = "Anasayfa";
            this.katlariGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.katlariGoruntuleToolStripMenuItem_Click);
            // 
            // menüİşlemleriToolStripMenuItem
            // 
            this.menüİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunKategoriEkleToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.urunDüzenleToolStripMenuItem,
            this.urunSilToolStripMenuItem});
            this.menüİşlemleriToolStripMenuItem.Name = "menüİşlemleriToolStripMenuItem";
            this.menüİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.menüİşlemleriToolStripMenuItem.Text = "Menü İşlemleri";
            // 
            // urunKategoriEkleToolStripMenuItem
            // 
            this.urunKategoriEkleToolStripMenuItem.Name = "urunKategoriEkleToolStripMenuItem";
            this.urunKategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunKategoriEkleToolStripMenuItem.Text = "Ürün Kategori Ekle";
            this.urunKategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.urunKategoriEkleToolStripMenuItem_Click);
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // urunDüzenleToolStripMenuItem
            // 
            this.urunDüzenleToolStripMenuItem.Name = "urunDüzenleToolStripMenuItem";
            this.urunDüzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunDüzenleToolStripMenuItem.Text = "Ürün Düzenle";
            // 
            // urunSilToolStripMenuItem
            // 
            this.urunSilToolStripMenuItem.Name = "urunSilToolStripMenuItem";
            this.urunSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunSilToolStripMenuItem.Text = "Ürün Sil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 325);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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