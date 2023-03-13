using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Classes
{
    public class Kategori : Urun
    {
        public string KategoriIsmi { get; set; }

        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public Urun Urun { get; set; }
        public override string ToString()
        {
            return this.KategoriIsmi;
        }
    }
    
}
