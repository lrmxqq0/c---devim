using System;

public class Program
{
    public static string KategoriBelirle(int yas)
    {
        if (yas < 0 || yas > 99)
        {
            return "Ya hiç doğmadınız ya da çoktan öldünüz...";
        }
        else if (yas <= 18)
        {
            return "Küçüksünüz";
        }
        else if (yas <= 35)
        {
            return "Gençsiniz";
        }
        else if (yas <= 55)
        {
            return "Yetişkinsiniz";
        }
        else if (yas <= 75)
        {
            return "Yaşlısınız";
        }
        else
        {
            return "Çok yaşlısınız";
        }
    }

    public static void Main()
    { 
        
        Console.WriteLine(KategoriBelirle(5));  
        Console.WriteLine(KategoriBelirle(40));  
        Console.WriteLine(KategoriBelirle(80));  
        Console.WriteLine(KategoriBelirle(120));
        Console.WriteLine(KategoriBelirle(33));
        Console.WriteLine(KategoriBelirle(90));

    }
}

