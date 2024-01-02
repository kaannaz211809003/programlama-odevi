/*Öyle bir program yazın ki, önce kullanıcıya kaç adet sayı girmek istediğini sorsun. Daha sonra kullanıcıdan sayı 
girmesini istesin. Kullanıcı fark etse de etmese de baştan girdiği adet kadar sayı tamamlandığında bu sayıların toplamını 
ve ortalamasını hesaplayarak ekrana yazsın.*/


using System;

namespace SayiToplamOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı girmek istiyorsunuz?: ");
            int adet;
            
            // Kullanıcıdan adet bilgisini alınana kadar döngü devam eder
            while (!int.TryParse(Console.ReadLine(), out adet) || adet <= 0)
            {
                Console.Write("Geçerli bir sayı giriniz: ");
            }

            int toplam = 0;

            for (int i = 1; i <= adet; i++)
            {
                Console.Write($"{i}. sayıyı giriniz: ");
                int sayi;
                
                // Kullanıcıdan sayı girişi isteme
                while (!int.TryParse(Console.ReadLine(), out sayi))
                {
                    Console.Write("Geçerli bir sayı giriniz: ");
                }
                
                toplam += sayi;
            }

            double ortalama = (double)toplam / adet;

            Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
            Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");

            Console.ReadLine();
        }
    }
}
