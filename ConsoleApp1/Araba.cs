using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public decimal YakitTuketimi { get; set; } 

    public Araba(string marka, string model, decimal yakitTuketimi)
    {
        Marka = marka;
        Model = model;
        YakitTuketimi = yakitTuketimi;
    }

    public decimal ToplamTuketimHesapla(decimal mesafe)
    {
        
        return (mesafe * YakitTuketimi) / 100;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Marka: {Marka} | Model: {Model} | Yakıt Tüketimi: {YakitTuketimi} L/100km");
    }
}
