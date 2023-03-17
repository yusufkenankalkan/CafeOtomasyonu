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
        private Masa _seciliMasa;
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
            pbResim.Image = null;
            lstSepet.DataSource = null;

            foreach (var item in Context.Masalar)
            {
                if (item.BulunduguKat.KatIsmi == (sender as Button).Text)
                {
                    Button btn = new Button();
                    btn.Name = item.Id.ToString();
                    btn.Text = item.MasaIsmi;
                    btn.Size = new Size(80, 80);
                    flMasalar.Controls.Add(btn);
                    btn.Click += Btn_Click;
                    if (item.DoluMu)
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }

                }
            }

        }
        private void Btn_Click(object sender, EventArgs e)
        {

            foreach (var item in Context.Kategoriler)
            {
                Button btnKategori = new Button();
                btnKategori.Text = item.KategoriIsmi;
                btnKategori.Size = new Size(125, 50);

            }

            _seciliMasa = Context.Masalar.Find(x => x.Id.ToString() == (sender as Button).Name);
            if (_seciliMasa.Sepet != null)
            {
                lblFiyat.Text = _seciliMasa.Sepet.ToplamFiyat.ToString("C");
            }
            cmbKategori.DataSource = Context.Kategoriler;


            lstSepet.DataSource = null;
            if (_seciliMasa.Sepet != null)
            {
                lstSepet.DataSource = _seciliMasa.Sepet.Urunler;
            }
            //cmbKategori.SelectedIndex = 0;
            //cmbUrun.SelectedIndex = 0;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex == -1) return;
            Kategori seciliKategori = (Kategori)cmbKategori.SelectedItem;
            cmbUrun.DataSource = Context.Urunler
                .Where(x => x.Kategori.KategoriIsmi == seciliKategori.KategoriIsmi)
                .ToList();
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex == -1) return;
            Urun urun = (Urun)cmbUrun.SelectedItem;

            if (urun.Foto != null)
            {
                pbResim.Image = (Image)(new ImageConverter().ConvertFrom(urun.Foto));
            }

        }


        Urun seciliUrun = new Urun();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (_seciliMasa.Sepet == null)
            {
                _seciliMasa.Sepet = new Sepet();
            }
            seciliUrun = _seciliMasa.Sepet.Urunler.Find(x => x.UrunAdi == (cmbUrun.SelectedItem as Urun).UrunAdi);

            decimal seciliUrunFiyat = (cmbUrun.SelectedItem as Urun).Fiyat;
            _seciliMasa.Sepet.ToplamFiyat = seciliUrunFiyat;
            foreach (var item in _seciliMasa.Sepet.Urunler)
            {
                _seciliMasa.Sepet.ToplamFiyat += item.Fiyat;
            }
            if (_seciliMasa.Sepet.Urunler.Contains(seciliUrun))
            {
                seciliUrun.Fiyat += seciliUrunFiyat;
                seciliUrun.SepetAdet++;
            }
            else
            {
                Urun urunOzellik = cmbUrun.SelectedItem as Urun;
                seciliUrun = new Urun()
                {
                    UrunAdi = urunOzellik.UrunAdi,
                    Fiyat = urunOzellik.Fiyat,
                    Kategori = urunOzellik.Kategori,
                    SepetAdet = 1

                };

                _seciliMasa.Sepet.Urunler.Add(seciliUrun);
                MasaRengiBoya(_seciliMasa, Color.Red);
                _seciliMasa.DoluMu = true;

            }
            lblFiyat.Text = _seciliMasa.Sepet.ToplamFiyat.ToString("C");
            lstSepet.DataSource = null;
            lstSepet.DataSource = _seciliMasa.Sepet.Urunler;
            DataHelpers.Save(Context);
        }

        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null)
            {
                return;
            }
            else
            {
                seciliUrun = (Urun)lstSepet.SelectedItem;
                if (seciliUrun.Foto != null)
                {
                    pbResim.Image = (Image)(new ImageConverter().ConvertFrom(seciliUrun.Foto));
                }
                cmbKategori.SelectedItem = Context.Kategoriler.Find(x => x.Id == seciliUrun.Kategori.Id);
                cmbUrun.SelectedItem = Context.Urunler.Find(x => x.UrunAdi == seciliUrun.UrunAdi);
            }


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            seciliUrun = (Urun)lstSepet.SelectedItem;
            _seciliMasa.Sepet.Urunler.Remove(seciliUrun);
            lstSepet.DataSource = null;
            lstSepet.DataSource = _seciliMasa.Sepet.Urunler;
            if (_seciliMasa.Sepet.Urunler.Count == 0)
            {
                MasaRengiBoya(_seciliMasa, Color.Green);
                _seciliMasa.DoluMu = false;
                
            }
            DataHelpers.Save(Context);
            cmbKategori.SelectedIndex = -1;
            cmbUrun.SelectedIndex = -1;
            pbResim.Image = null;
            //lstSepet.SelectedIndex = 0;

        }
        private void MasaRengiBoya(Masa masa, Color color)
        {
            foreach (var item in flMasalar.Controls)
            {

                if (item is Button btn)
                {
                    if (btn.Name == masa.Id.ToString())
                    {
                        btn.BackColor = color;
                    }
                }
            }
        }

        private void btnHesapAl_Click(object sender, EventArgs e)
        {
            _seciliMasa.Sepet.Urunler.Clear();
            _seciliMasa.Sepet.ToplamFiyat = 0;
            lstSepet.DataSource = null;
            lstSepet.DataSource = _seciliMasa.Sepet.Urunler;
            lblFiyat.Text = _seciliMasa.Sepet.ToplamFiyat.ToString("C");
            MasaRengiBoya(_seciliMasa, Color.Green);
            _seciliMasa.DoluMu = false;
            DataHelpers.Save(Context);
        }
    }
}
