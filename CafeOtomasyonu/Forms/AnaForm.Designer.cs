﻿namespace CafeOtomasyonu.Forms
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flKatlar = new FlowLayoutPanel();
            flMasalar = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8115025F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.1885F));
            tableLayoutPanel1.Controls.Add(flKatlar, 0, 0);
            tableLayoutPanel1.Controls.Add(flMasalar, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1565, 1162);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flKatlar
            // 
            flKatlar.Dock = DockStyle.Fill;
            flKatlar.FlowDirection = FlowDirection.TopDown;
            flKatlar.Location = new Point(4, 4);
            flKatlar.Name = "flKatlar";
            flKatlar.Size = new Size(350, 1154);
            flKatlar.TabIndex = 0;
            flKatlar.Paint += flKatlar_Paint;
            // 
            // flMasalar
            // 
            flMasalar.Dock = DockStyle.Fill;
            flMasalar.Location = new Point(361, 4);
            flMasalar.Name = "flMasalar";
            flMasalar.Size = new Size(1200, 1154);
            flMasalar.TabIndex = 1;
            // 
            // Anaform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 1162);
            Controls.Add(tableLayoutPanel1);
            Name = "Anaform";
            Text = "Anaform";
            Load += Anaform_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flKatlar;
        private FlowLayoutPanel flMasalar;
    }
}