using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Classes
{
    public class Urun
    {
        private string _urunAdi = "";
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UrunAdi
        {
            set
            {
                foreach (char harf in value)
                {
                    if (char.IsSymbol(harf) || char.IsPunctuation(harf))
                        throw new Exception("Ürün alanınıza özel karakter girişi yapılamaz");

                }
                _urunAdi = value;
            }
            get
            {
                return _urunAdi.ToUpper();
            }
        }
        public decimal Fiyat { get; set; }
        public Kategori Kategori { get; set; }
        public int SepetAdet { get; set; } = 0;
        public byte[]? Foto { get; set; } = null;
        public override string ToString()
        {
            return $"{this.UrunAdi} - {this.Fiyat} ₺ ";
        }
    }
}
