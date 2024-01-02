/*
// 5 elemanlı bir X dizisi içinde son rakamı sıfır olan kaç tane sayı olduğunu hesaplar
using System;
namespace or202
{
 class Program
 {
 public static void Main(string[] args)
 {
 int [] B=new int[5];
 int a=0,say=0;
 foreach(int al in B)//for (a=0; a<=B.Length-1;a++)
 {
 Console.Write(a+". Elemanı Gir: ");
 B[a]=Int32.Parse(Console.ReadLine());
 if(B[a]%10==0) say++;
 a++; //döngü for ile olsaydı a++ satırına gerek kalmayacaktı!
 }
 Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: "+say);
 Console.Write("Press any key to continue . . . ");
 Console.ReadKey(true);
 }
 }
}
ÖDEV: Yukarıdaki örneği son rakamı sıfır olan değerlerin toplamı ve ortalamasını da verecek şekilde yeniden yaz
*/



using System;

namespace or202
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] B = new int[5];
            int a = 0, say = 0, toplam = 0;
            foreach (int al in B)
            {
                Console.Write((a + 1) + ". Elemanı Gir: ");
                B[a] = Int32.Parse(Console.ReadLine());
                if (B[a] % 10 == 0)
                {
                    say++;
                    toplam += B[a];
                }
                a++;
            }

            Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: " + say);

            if (say > 0)
            {
                double ortalama = (double)toplam / say;
                Console.WriteLine("Son Rakamı Sıfır Olan Sayıların Toplamı: " + toplam);
                Console.WriteLine("Son Rakamı Sıfır Olan Sayıların Ortalaması: " + ortalama);
            }
            else
            {
                Console.WriteLine("Girilen sayılardan son rakamı sıfır olan sayı bulunmamaktadır.");
            }

            Console.Write("her hangi bir tuşa basınız . . . ");
            Console.ReadKey(true);
        }
    }
}
