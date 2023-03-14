using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Classes;

public class Masa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string MasaIsmi { get; set; }
    public Kat BulunduguKat { get; set; }
}