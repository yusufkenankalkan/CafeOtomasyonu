using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Classes;
using CafeOtomasyonu.Helpers;

namespace CafeOtomasyonu.Forms
{
    public partial class AnaEkranForm : Form
    {
        public AnaEkranForm()
        {
            InitializeComponent();
        }
        public DataContext Context { get; set; }
        private void AnaEkranForm_Load(object sender, EventArgs e)
        {
            

            foreach (var item in Context.Kats)
            {
                Button btn = new Button();

                btn.Click += KatButon_Click;
                btn.Text = item.KatIsmi;
                btn.Size = new Size(150, 100);
                flKatlar.Controls.Add(btn);
            }
        }
        private void KatButon_Click(object sender, EventArgs e)
        {
            flMasalar.Controls.Clear();
            cmbKategori.DataSource = null;
            cmbUrun.DataSource = null;
            

            foreach (var item in Context.Masalar)
            {
                if (item.BulunduguKat.KatIsmi == (sender as Button).Text)
                {
                    Button btn = new Button();
                    btn.Text = item.MasaIsmi;
                    btn.Size = new Size(80, 80);
                    flMasalar.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            cmbKategori.DataSource = Context.Kategoriler;

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex == -1) return;
            Kategori seciliKategori = (Kategori)cmbKategori.SelectedItem;
            cmbUrun.DataSource = Context.Urunler
                .Where(x => x.Kategori.KategoriIsmi == seciliKategori.KategoriIsmi)
                .ToList();
        }

    }
}
