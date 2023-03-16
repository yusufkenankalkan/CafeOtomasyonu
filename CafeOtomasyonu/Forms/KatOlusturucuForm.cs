using CafeOtomasyonu.Classes;
using CafeOtomasyonu.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.Forms;

public partial class KatOlusturucuForm : Form
{
    public DataContext Context { get; set; }
    public KatOlusturucuForm()
    {
        InitializeComponent();
    }

    private void KatOlusturucuForm_Load(object sender, EventArgs e)
    {
        lstKatlar.DataSource = Context.Kats;

    }
    private void lstKatlar_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstKatlar.SelectedItem == null)
        {
            return;
        }
        Kat seciliKat = (Kat)lstKatlar.SelectedItem;
        txtKatIsmi.Text = seciliKat.KatIsmi;
        txtKatSirasi.Text = seciliKat.KatSirasi.ToString();
        txtMasaSayisi.Text = seciliKat.MasaSayisi.ToString();
    }
    private void btnEkle_Click(object sender, EventArgs e)
    {
        Kat yeniKat = new Kat()
        {
            KatIsmi = txtKatIsmi.Text,
            KatSirasi = Convert.ToInt32(txtKatSirasi.Text),
            MasaSayisi = Convert.ToInt32(txtMasaSayisi.Text)

        };

        for (int i = 1; i <= yeniKat.MasaSayisi; i++)
        {
            Masa masa = new Masa();
            masa.MasaIsmi = "M" + i.ToString();
            masa.BulunduguKat = yeniKat;
            Context.Masalar.Add(masa);
        }

        Context.Kats.Add(yeniKat);
        lstKatlar.DataSource = null;
        lstKatlar.DataSource = Context.Kats;
        DataHelpers.Save(Context);
        this.FormCleaner(Controls);

    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (lstKatlar.SelectedItem == null) return;
        Kat kat = (Kat)lstKatlar.SelectedItem;
        kat.KatIsmi = txtKatIsmi.Text;
        kat.KatSirasi = int.Parse(txtKatSirasi.Text);
        kat.MasaSayisi = int.Parse(txtMasaSayisi.Text);
        lstKatlar.DataSource = null;
        lstKatlar.DataSource = Context.Kats;
        DataHelpers.Save(Context);
        
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstKatlar.SelectedItem == null)
        {
            return;
        }
        Kat secilikat = (Kat)lstKatlar.SelectedItem;
        Context.Kats.Remove(secilikat);
        DataHelpers.Save(Context);
        lstKatlar.DataSource = null;
        lstKatlar.DataSource = Context.Kats;
        this.FormCleaner(Controls);
    }
}
