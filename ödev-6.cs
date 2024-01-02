/*//b değerinin asal sayı olup olmadığını bulan program!
using System;
namespace or094
{
class Program
{
public static void Main(string[] args)
{
int a, b =11;
String s = "b Sayısı Asal Sayı";
if (b == 1) { Console.WriteLine("ASAL DEĞİL!"); goto bitir;}
for (a = 2; a <= b / 2; a++)
 {
if (b % a == 0)
 {
 s = "b Sayısı Asal Sayı Değil!";
break;
 }
 }
Console.WriteLine(s);
bitir:Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
Console.ReadKey(true);
}
} }
 Yukarıdaki örneği b değeri kullanıcı tarafından girilecek şekilde düzenleyiniz
 */




using System;

namespace AsalSayiKontrolu
{
    class Program
    {
        public static void Main(string[] args)
        {
            int b;

            Console.Write("Bir sayı girin: ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Geçersiz giriş! Pozitif bir tam sayı girin.");
                Console.Write("Bir sayı girin: ");
            }

            string s = "b Sayısı Asal Sayı";

            if (b == 1)
            {
                Console.WriteLine("ASAL DEĞİL!");
                goto bitir;
            }

            for (int a = 2; a <= b / 2; a++)
            {
                if (b % a == 0)
                {
                    s = "b Sayısı Asal Sayı Değil!";
                    break;
                }
            }

            Console.WriteLine(s);

        bitir:
            Console.Write("her hangi bir tuşa basınız....");
            Console.ReadKey(true);
        }
    }
}
