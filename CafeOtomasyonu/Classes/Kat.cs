using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Classes;

public class Kat
{
    private string _katIsmi;
    public string KatIsmi
    {
        set
        {
            foreach (char harf in value)
            {
                if (char.IsSymbol(harf) || char.IsPunctuation(harf))
                    throw new Exception("Kat alanınıza özel karakter girişi yapılamaz");

            }
            _katIsmi = value;
        }
        get
        {
            return _katIsmi.ToUpper();
        }
    }
    public int KatSirasi { get; set; }
    public int MasaSayisi { get; set; }

    public override string ToString()
    {
        return $"{this.KatSirasi}-{this.KatIsmi}";
    }
}
