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
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }
        public DataContext Context { get; set; }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            
            cmbKategori.DataSource = Context.Kategoriler;
            lstListe.DataSource = Context.Urunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun()
                {
                    UrunAdi = txtAd.Text,
                    Kategori = (Kategori)cmbKategori.SelectedItem
                };
                Context.Urunler.Add(urun);

                lstListe.DataSource = null;
                lstListe.DataSource = Context.Urunler;
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
            if (lstListe.SelectedItem == null) return;
            Urun urun = (Urun)lstListe.SelectedItem;
            txtAd.Text = urun.UrunAdi;
            cmbKategori.SelectedItem = Context.Kategoriler.Find(x => x.Id == urun.Kategori.Id);

        }
    }
}
