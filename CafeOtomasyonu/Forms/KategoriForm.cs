using CafeOtomasyonu.Classes;
using CafeOtomasyonu.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.Forms
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        public DataContext Context { get; set; }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori()
                {
                    KategoriIsmi = txtAd.Text
                };

                Context.Kategoriler.Add(kategori);
                lstListe.DataSource = null;
                lstListe.DataSource = Context.Kategoriler;
                DataHelpers.Save(Context);
                this.FormCleaner(Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                return;
            }
            Kategori seciliKategori = (Kategori)lstListe.SelectedItem;
            txtAd.Text = seciliKategori.KategoriIsmi;

        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            lstListe.DataSource = Context.Kategoriler;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                return;
            }

            Kategori seciliKategori = (Kategori)lstListe.SelectedItem;
            Context.Kategoriler.Remove(seciliKategori);
            for (int i = 0; i < Context.Urunler.Count; i++)
            {
                if (seciliKategori.KategoriIsmi == Context.Urunler[i].Kategori.KategoriIsmi)
                {
                    Context.Urunler.Remove(Context.Urunler[i]);
                    i--;
                }
            }
            lstListe.DataSource = null;
            lstListe.DataSource = Context.Kategoriler;
            DataHelpers.Save(Context);
        }
    }
}
