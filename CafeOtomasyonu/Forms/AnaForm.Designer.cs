namespace CafeOtomasyonu.Forms
{
    partial class Anaform
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flKatlar = new System.Windows.Forms.FlowLayoutPanel();
            this.flMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.8115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.1885F));
            this.tableLayoutPanel1.Controls.Add(this.flKatlar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flMasalar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flKatlar
            // 
            this.flKatlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flKatlar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flKatlar.Location = new System.Drawing.Point(3, 2);
            this.flKatlar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.flKatlar.Name = "flKatlar";
            this.flKatlar.Size = new System.Drawing.Size(195, 459);
            this.flKatlar.TabIndex = 0;
            // 
            // flMasalar
            // 
            this.flMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flMasalar.Location = new System.Drawing.Point(203, 2);
            this.flMasalar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.flMasalar.Name = "flMasalar";
            this.flMasalar.Size = new System.Drawing.Size(671, 459);
            this.flMasalar.TabIndex = 1;
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flKatlar;
        private FlowLayoutPanel flMasalar;
    }
}