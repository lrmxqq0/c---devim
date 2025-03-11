using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stajyer : Calisan
{
    public Stajyer(string ad, string soyad, decimal maas, string departman)
        : base(ad, soyad, "Stajyer", maas, departman) { }
}
