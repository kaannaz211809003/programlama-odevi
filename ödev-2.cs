/* Öyle bir program yazın ki kullanıcıdan bir sayı istesin. Daha sonra bu sayı ile 1 arasındaki TEK veya ÇİFT 
tamsayıların toplamını hesaplayarak sonucu ekrana yazsın. Kullanıcıya TEK veya ÇİFT tamsayılar ile ilgili işlem 
yapılacağını sorsun?
Bir sayı girin:
TEK’leri mi ÇİFT’leri mi toplamak istersiniz? */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı girin:");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("TEK'leri mi ÇİFT'leri mi toplamak istersiniz? (TEK/ÇİFT)");
        string tercih = Console.ReadLine().ToUpper();

        int toplam = 0;

        if (tercih == "TEK")
        {
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 != 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("1 ile " + sayi + " arasındaki TEK sayıların toplamı: " + toplam);
        }
        else if (tercih == "ÇİFT")
        {
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("1 ile " + sayi + " arasındaki ÇİFT sayıların toplamı: " + toplam);
        }
        else
        {
            Console.WriteLine("Geçersiz tercih.");
        }
    }
}
