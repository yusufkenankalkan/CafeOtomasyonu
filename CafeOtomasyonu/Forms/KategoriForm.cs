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
                if (AynisiVarMi(txtAd.Text))
                {
                    MessageBox.Show("Kategori İsimleri Aynı Olamaz");
                    txtAd.Clear();
                    return;
                }

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
            btnEkle.Enabled = true;
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            Kategori seciliKategori = (Kategori)lstListe.SelectedItem;
            if (seciliKategori.KategoriIsmi != txtAd.Text)
            {
                if (AynisiVarMi(txtAd.Text))
                {
                    MessageBox.Show("Kategori İsimleri Aynı Olamaz");
                    txtAd.Clear();
                    return;
                }
            }
            seciliKategori.UrunAdi = txtAd.Text;
            lstListe.DataSource = null;
            lstListe.DataSource = Context.Kategoriler;
            btnEkle.Enabled = true;
            DataHelpers.Save(Context);

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
            this.FormCleaner(Controls);
            btnEkle.Enabled = true;
        }
        private bool AynisiVarMi(string kategoriIsim)
        {
            foreach (var item in Context.Kategoriler)
            {
                if (kategoriIsim.ToLower() == item.KategoriIsmi.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void KategoriForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.FormCleaner(Controls);
        }
    }
}
