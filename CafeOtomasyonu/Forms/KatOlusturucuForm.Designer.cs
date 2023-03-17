namespace CafeOtomasyonu.Forms
{
    partial class KatOlusturucuForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKatIsmi = new System.Windows.Forms.TextBox();
            this.txtKatSirasi = new System.Windows.Forms.TextBox();
            this.txtMasaSayisi = new System.Windows.Forms.TextBox();
            this.lstKatlar = new System.Windows.Forms.ListBox();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kat İsmi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kat Sirasi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa Sayisi:";
            // 
            // txtKatIsmi
            // 
            this.txtKatIsmi.Location = new System.Drawing.Point(115, 55);
            this.txtKatIsmi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtKatIsmi.Name = "txtKatIsmi";
            this.txtKatIsmi.Size = new System.Drawing.Size(110, 23);
            this.txtKatIsmi.TabIndex = 6;
            // 
            // txtKatSirasi
            // 
            this.txtKatSirasi.Location = new System.Drawing.Point(115, 112);
            this.txtKatSirasi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtKatSirasi.Name = "txtKatSirasi";
            this.txtKatSirasi.Size = new System.Drawing.Size(110, 23);
            this.txtKatSirasi.TabIndex = 7;
            // 
            // txtMasaSayisi
            // 
            this.txtMasaSayisi.Location = new System.Drawing.Point(115, 169);
            this.txtMasaSayisi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMasaSayisi.Name = "txtMasaSayisi";
            this.txtMasaSayisi.Size = new System.Drawing.Size(110, 23);
            this.txtMasaSayisi.TabIndex = 8;
            // 
            // lstKatlar
            // 
            this.lstKatlar.ContextMenuStrip = this.cmsSil;
            this.lstKatlar.FormattingEnabled = true;
            this.lstKatlar.ItemHeight = 15;
            this.lstKatlar.Location = new System.Drawing.Point(242, 55);
            this.lstKatlar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lstKatlar.Name = "lstKatlar";
            this.lstKatlar.Size = new System.Drawing.Size(147, 199);
            this.lstKatlar.TabIndex = 9;
            this.lstKatlar.SelectedIndexChanged += new System.EventHandler(this.lstKatlar_SelectedIndexChanged);
            // 
            // cmsSil
            // 
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(41, 232);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 22);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(144, 232);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 22);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // KatOlusturucuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 294);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKatlar);
            this.Controls.Add(this.txtMasaSayisi);
            this.Controls.Add(this.txtKatSirasi);
            this.Controls.Add(this.txtKatIsmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "KatOlusturucuForm";
            this.Text = "KatOlusturucuForm";
            this.Load += new System.EventHandler(this.KatOlusturucuForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KatOlusturucuForm_MouseClick);
            this.cmsSil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKatIsmi;
        private TextBox txtKatSirasi;
        private TextBox txtMasaSayisi;
        private ListBox lstKatlar;
        private Button btnEkle;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
        private Button btnGuncelle;
    }
}