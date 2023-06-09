﻿using CafeOtomasyonu.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu;

public class DataContext
{
    public List<Kat> Kats { get; set; } = new List<Kat>();
    public List<Masa> Masalar { get; set; } = new List<Masa>();
    public List<Kategori> Kategoriler { get; set; } = new List<Kategori>();
    public List<Urun> Urunler { get; set; } = new List<Urun>();
}
