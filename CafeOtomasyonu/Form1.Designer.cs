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
            katlariGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { katEkleToolStripMenuItem, katlariGörüntüleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(861, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // katEkleToolStripMenuItem
            // 
            katEkleToolStripMenuItem.Name = "katEkleToolStripMenuItem";
            katEkleToolStripMenuItem.Size = new Size(118, 36);
            katEkleToolStripMenuItem.Text = "Kat Ekle";
            katEkleToolStripMenuItem.Click += katEkleToolStripMenuItem_Click;
            // 
            // katlariGörüntüleToolStripMenuItem
            // 
            katlariGörüntüleToolStripMenuItem.Name = "katlariGörüntüleToolStripMenuItem";
            katlariGörüntüleToolStripMenuItem.Size = new Size(129, 36);
            katlariGörüntüleToolStripMenuItem.Text = "Anasayfa";
            katlariGörüntüleToolStripMenuItem.Click += katlariGörüntüleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 693);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem katlariGörüntüleToolStripMenuItem;
    }
}