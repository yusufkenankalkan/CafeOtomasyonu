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
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(179, 30);
            this.cmbUrun.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(132, 23);
            this.cmbUrun.TabIndex = 0;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(26, 30);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(132, 23);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(105, 89);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 22);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // MasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 446);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbUrun);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MasaForm";
            this.Text = "MasaForm";
            this.Load += new System.EventHandler(this.MasaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbUrun;
        private ComboBox cmbKategori;
        private Button btnEkle;
    }
}