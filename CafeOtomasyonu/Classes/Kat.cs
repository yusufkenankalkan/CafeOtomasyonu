using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Classes;

public class Kat
{
    public string KatIsmi { get; set; }
    public int KatSirasi { get; set; }
    public int MasaSayisi { get; set; }

    public override string ToString()
    {
        return $"{this.KatSirasi}-{this.KatIsmi}";
    }
}
