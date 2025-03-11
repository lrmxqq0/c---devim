

public class Program
{
    public static void Main()
    {
        
        List<Calisan> calisanlar = new List<Calisan>
        {
            new GenelMudur("Ayşe", "Yıldırım", 15000, "Yönetim"),
            new Mudur("Veli", "Yaşar", 10000, "Pazarlama"),
            new Programci("Murat", "Demir", 7000, "Yazılım"),
            new Stajyer("İlayda", "Kaya", 2500, "Yazılım")
        };

        
        decimal toplamMaas = 0;
        foreach (var calisan in calisanlar)
        {
            calisan.BilgileriYazdir();  
            toplamMaas += calisan.Maas; 
        }

        
        Console.WriteLine($"\nToplam Maaş: {toplamMaas}");
    }
}
