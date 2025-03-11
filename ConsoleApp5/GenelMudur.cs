using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GenelMudur : Calisan
{
    public GenelMudur(string ad, string soyad, decimal maas, string departman)
        : base(ad, soyad, "Genel Müdür", maas, departman) { }
}