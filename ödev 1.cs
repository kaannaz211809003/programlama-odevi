// Öyle bir program yazın ki kullanıcının klavyeden girdiği sayıları toplasın, kullanıcı klavyeden 83 girerse toplama 
 //işlemini bitirsin ve sonucu ekrana yazsın.





using System;


class Program
{
    static void Main()
    {
        int toplam = 0;
        int sayi;

        do
        {
            Console.Write("Bir sayı girin (Çıkış için 83 girin): ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi != 83)
            {
                toplam += sayi;
            }

        } while (sayi != 83);

        Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
    }
}
