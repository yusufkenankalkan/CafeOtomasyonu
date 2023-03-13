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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbKatIsmi = new TextBox();
            tbKatSirasi = new TextBox();
            tbMasaSayisi = new TextBox();
            lbKatlar = new ListBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 118);
            label1.Name = "label1";
            label1.Size = new Size(103, 32);
            label1.TabIndex = 0;
            label1.Text = "Kat İsmi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 261);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 1;
            label2.Text = "Kat Sirasi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 413);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 2;
            label3.Text = "Masa Sayisi:";
            // 
            // tbKatIsmi
            // 
            tbKatIsmi.Location = new Point(193, 118);
            tbKatIsmi.Name = "tbKatIsmi";
            tbKatIsmi.Size = new Size(200, 39);
            tbKatIsmi.TabIndex = 6;
            // 
            // tbKatSirasi
            // 
            tbKatSirasi.Location = new Point(193, 258);
            tbKatSirasi.Name = "tbKatSirasi";
            tbKatSirasi.Size = new Size(200, 39);
            tbKatSirasi.TabIndex = 7;
            // 
            // tbMasaSayisi
            // 
            tbMasaSayisi.Location = new Point(193, 406);
            tbMasaSayisi.Name = "tbMasaSayisi";
            tbMasaSayisi.Size = new Size(200, 39);
            tbMasaSayisi.TabIndex = 8;
            // 
            // lbKatlar
            // 
            lbKatlar.FormattingEnabled = true;
            lbKatlar.ItemHeight = 32;
            lbKatlar.Location = new Point(457, 60);
            lbKatlar.Name = "lbKatlar";
            lbKatlar.Size = new Size(269, 484);
            lbKatlar.TabIndex = 9;
            lbKatlar.SelectedIndexChanged += lbKatlar_SelectedIndexChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(193, 521);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(150, 46);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // KatOlusturucuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 628);
            Controls.Add(btnEkle);
            Controls.Add(lbKatlar);
            Controls.Add(tbMasaSayisi);
            Controls.Add(tbKatSirasi);
            Controls.Add(tbKatIsmi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KatOlusturucuForm";
            Text = "KatOlusturucuForm";
            Load += KatOlusturucuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbKatIsmi;
        private TextBox tbKatSirasi;
        private TextBox tbMasaSayisi;
        private ListBox lbKatlar;
        private Button btnEkle;
    }
}