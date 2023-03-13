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

    private void lbKatlar_SelectedIndexChanged(object sender, EventArgs e)
    {


    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        Kat yeniKat = new Kat()
        {
            KatIsmi = tbKatIsmi.Text,
            KatSirasi = Convert.ToInt32(tbKatSirasi.Text),
            MasaSayisi = Convert.ToInt32(tbMasaSayisi.Text)

        };

        for (int i = 1; i <= yeniKat.MasaSayisi; i++)
        {
            Masa masa = new Masa();
            masa.MasaIsmi = "M" + i.ToString();
            masa.BulunduguKat = yeniKat;
            Context.Masalar.Add(masa);
        }

        Context.Kats.Add(yeniKat);
        lbKatlar.DataSource = null;
        lbKatlar.DataSource = Context.Kats;
        DataHelpers.Save(Context);

    }

    private void KatOlusturucuForm_Load(object sender, EventArgs e)
    {
        lbKatlar.DataSource = Context.Kats;

    }
}
