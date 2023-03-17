using CafeOtomasyonu.Forms;
using CafeOtomasyonu.Helpers;

namespace CafeOtomasyonu
{
    public partial class Form1 : Form
    {
        KatOlusturucuForm _katOlusturucuForm;
        AnaEkranForm _anaEkranForm;
        KategoriForm _kategoriForm;
        UrunEkleForm _urunEkleForm;
        
        DataContext _datacontext = new DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = DataHelpers.Load();
            _datacontext = data ?? new DataContext();
        }

        private void katEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_katOlusturucuForm == null || _katOlusturucuForm.IsDisposed)
            {
                _katOlusturucuForm = new KatOlusturucuForm();
                _katOlusturucuForm.MdiParent = this;
                _katOlusturucuForm.Text = "Kat Formu";
                _katOlusturucuForm.Context = _datacontext;
                _katOlusturucuForm.Show();
            }
        }

        private void katlariGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_anaEkranForm == null || _anaEkranForm.IsDisposed)
            {
                _anaEkranForm = new AnaEkranForm();
                _anaEkranForm.Context = _datacontext;
                _anaEkranForm.MdiParent = this;
                _anaEkranForm.Text = "Kat ve Masalar";
                _anaEkranForm.Show();
            }

        }

        private void urunKategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_kategoriForm == null || _kategoriForm.IsDisposed)
            {
                _kategoriForm = new KategoriForm();
                _kategoriForm.Context = _datacontext;
                _kategoriForm.MdiParent = this;
                _kategoriForm.Text = "Kategoriler";
                _kategoriForm.Show();
            }
        }

        private void urunDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _urunEkleForm = new UrunEkleForm();
            _urunEkleForm.Context = _datacontext;
            _urunEkleForm.MdiParent = this;
            _urunEkleForm.Text = "Kategoriler";
            _urunEkleForm.Show();
        }
    }
}