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
            this.FormCleaner(this.Controls);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (AynisiVarMi(txtAd.Text))
                {
                    MessageBox.Show("Ürün İsimleri Aynı Olamaz");
                    txtAd.Clear();
                    return;
                }

                Urun urun = new Urun()
                {
                    UrunAdi = txtAd.Text,
                    Fiyat = decimal.Parse(txtFiyat.Text),
                    Kategori = (Kategori)cmbKategori.SelectedItem
                };
                if (pbResim.Image != null)
                {
                    urun.Foto = (byte[])(new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[])));
                }
                if (urun.Foto == null)
                {
                    MessageBox.Show("Lütfen ürün fotoğrafı ekleyiniz");
                    return;
                }
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
            txtFiyat.Text = urun.Fiyat.ToString();
            if (urun.Foto != null)
            {
                pbResim.Image = (Image)(new ImageConverter().ConvertFrom(urun.Foto));
            }
            cmbKategori.SelectedItem = Context.Kategoriler.Find(x => x.Id == urun.Kategori.Id);
            
        }




        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Title = "Resim Seçiniz";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Multiselect = false;
            dosyaAc.Filter = "Resim Dosyası |*.jpg;*.png;*.jpeg;";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(dosyaAc.FileName);
            }
            DataHelpers.Save(Context);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                return;
            }
            Urun seciliUrun = (Urun)lstListe.SelectedItem;
            Context.Urunler.Remove(seciliUrun);
            DataHelpers.Save(Context);
            lstListe.DataSource = null;
            lstListe.DataSource = Context.Urunler;
            this.FormCleaner(Controls);
            btnEkle.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            Urun seciliUrun = (Urun)lstListe.SelectedItem;
            if (seciliUrun.UrunAdi != txtAd.Text)
            {
                if (AynisiVarMi(txtAd.Text))
                {
                    MessageBox.Show("Ürün İsimleri Aynı Olamaz");
                    txtAd.Clear();
                    return;
                }
            }
            seciliUrun.UrunAdi = txtAd.Text;
            seciliUrun.Fiyat = decimal.Parse(txtFiyat.Text);
            seciliUrun.Kategori = (Kategori)cmbKategori.SelectedItem;
            seciliUrun.Foto = (byte[])(new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[])));

            lstListe.DataSource = null;
            lstListe.DataSource = Context.Urunler;
            DataHelpers.Save(Context);
            btnEkle.Enabled = true;
        }

        private void UrunEkleForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.FormCleaner(Controls);
            
        }
        private bool AynisiVarMi(string urunAdi)
        {
            foreach (var item in Context.Urunler)
            {
                if (urunAdi.ToLower() == item.UrunAdi.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
