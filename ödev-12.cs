/*
// 1-99 arasındaki sayıları yazı ile yazdırır.
using System;
namespace or214
{
 class Program
 {
 public static void Main(string[] args)
 {
 byte a;
 string s=" ";
 string [] Birler={"Bir","İki","Üç","Dört","Beş","Altı","Yedi","Sekiz","Dokuz"};
 string [] Onlar={"On","Yirmi","Otuz","Kırk","Elli","Altmış","Yetmiş","Seksen","Doksan"};
 Console.Write("Bir Sayı Giriniz: ");//72 – 80 – 6 
 a=Byte.Parse(Console.ReadLine());
 if(a/10>=1){ //Sayı iki veya daha fazla basamaklı mı?
 s=Onlar[(a/10)-1];}//s= yetmiş – seksen -
 if (a%10!=0){ //Sayının son basamağı sıfır değilse yaz
 s=s+Birler[(a%10)-1];}//s= yetmiş+iki – “ altı”
 
 Console.WriteLine(s);//yetmişiki – seksen – “ altı”
 Console.Write("Press any key to continue . . . ");
 Console.ReadKey(true);
 } } }
0 1 2 3 4 5 6 7 8 9
78 56 23 95 68 87 61 77 45 33
23 56 78 95 68 87 61 77 45 33
23 33 78 95 68 87 61 77 45 56
23 33 45 95 68 87 61 77 78 56
23 33 45 56 68 87 61 77 78 95
23 33 45 56 61 87 68 77 78 95
23 33 45 56 61 68 87 77 78 95
23 33 45 56 61 68 77 87 78 95
23 33 45 56 61 68 77 78 87 95
PROGRAMLAMA TEMELLERİ DERSİ NOTLARI – Öğr. Grv. Murat ALBAYRAK
Sayfa 90 / 143
ÖDEV: Yukarıdaki programı 3 basamaklı sayıları da ekrana yazıyla yazacak şekilde düzenleyiniz.*/

using System;

namespace SayiYazi
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sayi;
            string s = "";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yuzler = { "", "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };

            Console.Write("Bir Sayı Giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi >= 100 && sayi <= 999)
            {
                s = Yuzler[sayi / 100]; // Yüzler basamağı
                sayi %= 100; // Yüzler basamağını çıkart

                if (sayi / 10 >= 1)
                {
                    s += Onlar[(sayi / 10) - 1]; // Onlar basamağı
                    sayi %= 10; // Onlar basamağını çıkart

                    if (sayi % 10 != 0)
                    {
                        s += Birler[sayi - 1]; // Birler basamağı
                    }
                }
                else if (sayi % 10 != 0)
                {
                    s += Birler[sayi - 1]; // Sadece birler basamağı varsa
                }
            }
            else if (sayi >= 10 && sayi <= 99)
            {
                s = Onlar[(sayi / 10) - 1]; // Onlar basamağı
                sayi %= 10; // Onlar basamağını çıkart

                if (sayi != 0)
                {
                    s += Birler[sayi - 1]; // Birler basamağı
                }
            }
            else if (sayi >= 1 && sayi <= 9)
            {
                s = Birler[sayi - 1]; // Sadece birler basamağı
            }

            Console.WriteLine(s);

            Console.Write("her hangi bir tuşa bas");
            Console.ReadKey(true);
        }
    }
}
