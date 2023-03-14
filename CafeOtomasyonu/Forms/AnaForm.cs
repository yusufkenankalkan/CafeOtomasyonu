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

namespace CafeOtomasyonu.Forms;

public partial class Anaform : Form
{

    public Anaform()
    {
        InitializeComponent();
    }
    public DataContext Context { get; set; }

    
    private void Anaform_Load(object sender, EventArgs e)
    {
        foreach (var item in Context.Kats)
        {
            Button btn = new Button();

            btn.Click += KatButon_Click;
            btn.Text = item.KatIsmi;
            btn.Size = new Size(300, 100);
            flKatlar.Controls.Add(btn);
        }
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void flKatlar_Paint(object sender, PaintEventArgs e)
    {

    }

    private void KatButon_Click(object sender, EventArgs e)
    {
        flMasalar.Controls.Clear();


        foreach (var item in Context.Masalar)
        {
            if (item.BulunduguKat.KatIsmi == (sender as Button).Text)
            {
                Button btn = new Button();
                btn.Text = item.MasaIsmi;
                btn.Size = new Size(80, 80);
                flMasalar.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
        }

    }
    private void Btn_Click(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        MasaForm masaForm = new();
        masaForm.Context = Context;
        masaForm.Show();

    }
}
