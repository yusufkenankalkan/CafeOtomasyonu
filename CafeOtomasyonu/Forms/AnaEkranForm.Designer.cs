namespace CafeOtomasyonu.Forms
{
    partial class AnaEkranForm
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
            this.flKatlar = new System.Windows.Forms.FlowLayoutPanel();
            this.flMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.tblUrun = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstHesap = new System.Windows.Forms.ListBox();
            this.tblUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flKatlar
            // 
            this.flKatlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flKatlar.Location = new System.Drawing.Point(0, 0);
            this.flKatlar.Name = "flKatlar";
            this.flKatlar.Size = new System.Drawing.Size(171, 453);
            this.flKatlar.TabIndex = 0;
            // 
            // flMasalar
            // 
            this.flMasalar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flMasalar.Location = new System.Drawing.Point(171, 0);
            this.flMasalar.Name = "flMasalar";
            this.flMasalar.Size = new System.Drawing.Size(384, 453);
            this.flMasalar.TabIndex = 1;
            // 
            // tblUrun
            // 
            this.tblUrun.ColumnCount = 1;
            this.tblUrun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUrun.Controls.Add(this.cmbUrun, 0, 1);
            this.tblUrun.Controls.Add(this.cmbKategori, 0, 0);
            this.tblUrun.Controls.Add(this.pbResim, 0, 2);
            this.tblUrun.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tblUrun.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tblUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUrun.Location = new System.Drawing.Point(555, 0);
            this.tblUrun.Name = "tblUrun";
            this.tblUrun.RowCount = 5;
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblUrun.Size = new System.Drawing.Size(252, 453);
            this.tblUrun.TabIndex = 2;
            // 
            // cmbUrun
            // 
            this.cmbUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(3, 57);
            this.cmbUrun.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(246, 23);
            this.cmbUrun.TabIndex = 2;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(3, 12);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(246, 23);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(33, 110);
            this.pbResim.Margin = new System.Windows.Forms.Padding(33, 20, 3, 3);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(181, 143);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 3;
            this.pbResim.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnSil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEkle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 274);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 61);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(140, 12);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(17, 12, 3, 3);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(86, 35);
            this.BtnSil.TabIndex = 1;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(17, 12);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(17, 12, 3, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 35);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lstHesap, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 341);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 109);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lstHesap
            // 
            this.lstHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHesap.ItemHeight = 15;
            this.lstHesap.Location = new System.Drawing.Point(3, 3);
            this.lstHesap.Name = "lstHesap";
            this.lstHesap.Size = new System.Drawing.Size(117, 103);
            this.lstHesap.TabIndex = 0;
            this.lstHesap.SelectedIndexChanged += new System.EventHandler(this.lstHesap_SelectedIndexChanged);
            // 
            // AnaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.tblUrun);
            this.Controls.Add(this.flMasalar);
            this.Controls.Add(this.flKatlar);
            this.Name = "AnaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkranForm";
            this.Load += new System.EventHandler(this.AnaEkranForm_Load);
            this.tblUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flKatlar;
        private FlowLayoutPanel flMasalar;
        private TableLayoutPanel tblUrun;
        private ComboBox cmbUrun;
        private ComboBox cmbKategori;
        private PictureBox pbResim;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnSil;
        private Button btnEkle;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lstHesap;
    }
}