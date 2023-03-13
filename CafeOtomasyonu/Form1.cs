using CafeOtomasyonu.Forms;
using CafeOtomasyonu.Helpers;

namespace CafeOtomasyonu
{
    public partial class Form1 : Form
    {
        KatOlusturucuForm _katOlusturucuForm;
        Anaform _anaform;
        DataContext _datacontext = new DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void katEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_katOlusturucuForm == null || _katOlusturucuForm.IsDisposed)
            {
                _katOlusturucuForm = new KatOlusturucuForm();
                //_katOlusturucuForm.MdiParent = this;
                _katOlusturucuForm.Text = "Kat Formu";
                _katOlusturucuForm.Context = _datacontext;
                _katOlusturucuForm.Show();
            }
        }
        //anasayfa
        private void katlariGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_anaform == null || _anaform.IsDisposed)
            {
                _anaform = new Anaform();
                _anaform.Context = _datacontext;
                _anaform.Text = "Katlar";
                _anaform.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = DataHelpers.Load();
            _datacontext = data ?? new DataContext();
        }
    }
}