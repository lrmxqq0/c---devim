public class Program
{
    public static string ArabaDurumu(int arabaYasi)
    {
        if (arabaYasi < 0 || arabaYasi > 30)
        {
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
        else if (arabaYasi <= 10)
        {
            return "Arabanız yeni";
        }
        else if (arabaYasi <= 20)
        {
            return "Servise götürmeniz gerekebilir";
        }
        else
        {
            return "Arabanız hurdaya çıkabilir";
        }
    }

    public static void Main()
    {
        
        Console.WriteLine(ArabaDurumu(5));   
        Console.WriteLine(ArabaDurumu(15));  
        Console.WriteLine(ArabaDurumu(25));  
        Console.WriteLine(ArabaDurumu(35));  
    }
}

