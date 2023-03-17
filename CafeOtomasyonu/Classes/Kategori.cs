using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Classes
{
    public class Kategori : Urun
    {
        private string _kategoriIsim;
        public string KategoriIsmi
        {
            set
            {
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf) || char.IsSymbol(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kategori alanınıza özel karakter veya sayı girişi yapılamaz");

                }
                _kategoriIsim = value;
            }
            get
            {
                return _kategoriIsim.ToUpper();
            }
        }

        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public Urun Urun { get; set; }
        public override string ToString()
        {
            return this.KategoriIsmi;
        }
    }
    
}
