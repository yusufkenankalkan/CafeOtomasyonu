namespace CafeOtomasyonu.Forms
{
    partial class MasaForm
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
            cmbUrun = new ComboBox();
            cmbKategori = new ComboBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(179, 30);
            cmbUrun.Margin = new Padding(2, 1, 2, 1);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(132, 23);
            cmbUrun.TabIndex = 0;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(26, 30);
            cmbKategori.Margin = new Padding(2, 1, 2, 1);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(132, 23);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(164, 102);
            btnEkle.Margin = new Padding(2, 1, 2, 1);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(81, 22);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // MasaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 260);
            Controls.Add(btnEkle);
            Controls.Add(cmbKategori);
            Controls.Add(cmbUrun);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MasaForm";
            Text = "MasaForm";
            Load += MasaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbUrun;
        private ComboBox cmbKategori;
        private Button btnEkle;
    }
}