using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Classes
{
    public class Urun
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UrunAdi { get; set; }
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
