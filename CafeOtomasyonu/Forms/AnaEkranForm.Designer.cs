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
            flKatlar = new FlowLayoutPanel();
            flMasalar = new FlowLayoutPanel();
            tblUrun = new TableLayoutPanel();
            cmbUrun = new ComboBox();
            cmbKategori = new ComboBox();
            pbResim = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnSil = new Button();
            btnEkle = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lstHesap = new ListBox();
            tblUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flKatlar
            // 
            flKatlar.Dock = DockStyle.Left;
            flKatlar.Location = new Point(0, 0);
            flKatlar.Name = "flKatlar";
            flKatlar.Size = new Size(171, 453);
            flKatlar.TabIndex = 0;
            // 
            // flMasalar
            // 
            flMasalar.Dock = DockStyle.Left;
            flMasalar.Location = new Point(171, 0);
            flMasalar.Name = "flMasalar";
            flMasalar.Size = new Size(384, 453);
            flMasalar.TabIndex = 1;
            // 
            // tblUrun
            // 
            tblUrun.ColumnCount = 1;
            tblUrun.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblUrun.Controls.Add(cmbUrun, 0, 1);
            tblUrun.Controls.Add(cmbKategori, 0, 0);
            tblUrun.Controls.Add(pbResim, 0, 2);
            tblUrun.Controls.Add(tableLayoutPanel2, 0, 3);
            tblUrun.Controls.Add(tableLayoutPanel1, 0, 4);
            tblUrun.Dock = DockStyle.Fill;
            tblUrun.Location = new Point(555, 0);
            tblUrun.Name = "tblUrun";
            tblUrun.RowCount = 5;
            tblUrun.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblUrun.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblUrun.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblUrun.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblUrun.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblUrun.Size = new Size(252, 453);
            tblUrun.TabIndex = 2;
            // 
            // cmbUrun
            // 
            cmbUrun.Dock = DockStyle.Fill;
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(3, 57);
            cmbUrun.Margin = new Padding(3, 12, 3, 3);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(246, 23);
            cmbUrun.TabIndex = 2;
            cmbUrun.SelectedIndexChanged += cmbUrun_SelectedIndexChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.Dock = DockStyle.Fill;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(3, 12);
            cmbKategori.Margin = new Padding(3, 12, 3, 3);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(246, 23);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // pbResim
            // 
            pbResim.Location = new Point(33, 110);
            pbResim.Margin = new Padding(33, 20, 3, 3);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(181, 143);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 3;
            pbResim.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(BtnSil, 1, 0);
            tableLayoutPanel2.Controls.Add(btnEkle, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 274);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(246, 61);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(140, 12);
            BtnSil.Margin = new Padding(17, 12, 3, 3);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(86, 35);
            BtnSil.TabIndex = 1;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(17, 12);
            btnEkle.Margin = new Padding(17, 12, 3, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 35);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lstHesap, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 341);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(246, 109);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // lstHesap
            // 
            lstHesap.Dock = DockStyle.Fill;
            lstHesap.ItemHeight = 15;
            lstHesap.Location = new Point(3, 3);
            lstHesap.Name = "lstHesap";
            lstHesap.Size = new Size(117, 103);
            lstHesap.TabIndex = 0;
            // 
            // AnaEkranForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(807, 453);
            Controls.Add(tblUrun);
            Controls.Add(flMasalar);
            Controls.Add(flKatlar);
            Name = "AnaEkranForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaEkranForm";
            Load += AnaEkranForm_Load;
            tblUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
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