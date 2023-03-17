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
            this.components = new System.ComponentModel.Container();
            this.flKatlar = new System.Windows.Forms.FlowLayoutPanel();
            this.flMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.tblUrun = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnHesapAl = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.tblUrun.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsSil.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // flKatlar
            // 
            this.flKatlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flKatlar.Location = new System.Drawing.Point(0, 0);
            this.flKatlar.Name = "flKatlar";
            this.flKatlar.Size = new System.Drawing.Size(186, 418);
            this.flKatlar.TabIndex = 0;
            // 
            // flMasalar
            // 
            this.flMasalar.AutoScroll = true;
            this.flMasalar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flMasalar.Location = new System.Drawing.Point(186, 0);
            this.flMasalar.Name = "flMasalar";
            this.flMasalar.Size = new System.Drawing.Size(384, 418);
            this.flMasalar.TabIndex = 1;
            // 
            // tblUrun
            // 
            this.tblUrun.ColumnCount = 1;
            this.tblUrun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUrun.Controls.Add(this.cmbUrun, 0, 1);
            this.tblUrun.Controls.Add(this.cmbKategori, 0, 0);
            this.tblUrun.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tblUrun.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tblUrun.Controls.Add(this.pbResim, 0, 2);
            this.tblUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUrun.Location = new System.Drawing.Point(570, 0);
            this.tblUrun.Name = "tblUrun";
            this.tblUrun.RowCount = 5;
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.505519F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.26932F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.492273F));
            this.tblUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.24062F));
            this.tblUrun.Size = new System.Drawing.Size(331, 418);
            this.tblUrun.TabIndex = 2;
            // 
            // cmbUrun
            // 
            this.cmbUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(3, 53);
            this.cmbUrun.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(325, 23);
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
            this.cmbKategori.Size = new System.Drawing.Size(325, 23);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnEkle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 33);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(130, 5);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(130, 5, 3, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 25);
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
            this.tableLayoutPanel1.Controls.Add(this.lstSepet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 192);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.cmsSil;
            this.lstSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSepet.ItemHeight = 15;
            this.lstSepet.Location = new System.Drawing.Point(3, 3);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(156, 186);
            this.lstSepet.TabIndex = 0;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnHesapAl, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(165, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(157, 186);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.96689F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.03311F));
            this.tableLayoutPanel4.Controls.Add(this.lblToplam, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblFiyat, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(151, 127);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(10, 40);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(10, 40, 3, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(64, 42);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "Toplam  Fiyat";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat.Location = new System.Drawing.Point(108, 50);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(25, 50, 3, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(19, 21);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "0";
            this.lblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHesapAl
            // 
            this.btnHesapAl.Location = new System.Drawing.Point(25, 8);
            this.btnHesapAl.Margin = new System.Windows.Forms.Padding(25, 8, 3, 3);
            this.btnHesapAl.Name = "btnHesapAl";
            this.btnHesapAl.Size = new System.Drawing.Size(103, 42);
            this.btnHesapAl.TabIndex = 1;
            this.btnHesapAl.Text = "Hesap Al";
            this.btnHesapAl.UseVisualStyleBackColor = true;
            this.btnHesapAl.Click += new System.EventHandler(this.btnHesapAl_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(120, 87);
            this.pbResim.Margin = new System.Windows.Forms.Padding(120, 15, 3, 3);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(99, 86);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 3;
            this.pbResim.TabStop = false;
            // 
            // AnaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(901, 418);
            this.Controls.Add(this.tblUrun);
            this.Controls.Add(this.flMasalar);
            this.Controls.Add(this.flKatlar);
            this.Name = "AnaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaEkranForm";
            this.Load += new System.EventHandler(this.AnaEkranForm_Load);
            this.tblUrun.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cmsSil.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
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
        private Button btnEkle;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lstSepet;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblToplam;
        private Label lblFiyat;
        private Button btnHesapAl;
    }
}