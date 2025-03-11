using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Fiat", "Fiorino", 6.5m), 
            new Araba("Porsche", "Taycan", 7.2m),    
            new Araba("Ford", "Focus", 5.8m),     
            new Araba("BMW", "M3", 8.3m)    
        };

        
        decimal toplamTuketim = 0;
        decimal mesafe = 1000; 

        foreach (var araba in arabalar)
        {
            araba.BilgileriYazdir();  
            decimal tuketim = araba.ToplamTuketimHesapla(mesafe);
            Console.WriteLine($"Toplam Benzin Tüketimi ({mesafe} km): {tuketim} L");
            toplamTuketim += tuketim;  
        }

        Console.WriteLine($"\nToplam Benzin Tüketimi: {toplamTuketim} L");
    }
}
