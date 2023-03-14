using CafeOtomasyonu.Classes;
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
    public partial class MasaForm : Form
    {
        public DataContext Context { get; set; }
        public MasaForm()
        {
            InitializeComponent();
        }

        

        private void MasaForm_Load(object sender, EventArgs e)
        {
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


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Masa masa = new Masa();
            masa = Context.Masalar.Find(x => x.masa_id == masa.masa_id);

            //foto ekle
            Urun urun = new Urun();
            Urun seciliUrun = ((Urun)cmbUrun.SelectedItem);
            urun.UrunAdi = seciliUrun.UrunAdi;
            urun.Fiyat = seciliUrun.Fiyat;
            urun.Kategori = seciliUrun.Kategori;
            
        }
    }
}
