/*
Elemanları dışarıdan girilen 10 elemanlı bir B dizisinin ilk elemanına değer olarak en yakın ikinci elemanı ekrana 
yazdıran program.
İpucu: En yakın elemanı bulmak için ilk eleman ile diğer tüm elemanlar sıra ile birbirinden çıkarılır ve sonucun mutlak 
değeri alınarak en küçük sonucun bulunduğu noktadaki indis değeri en yakın elemanın indis değeri olarak 
değerlendirilir.
using System;
namespace or220
{ class Program
 { public static void Main(string[] args) {
 int sayi, a, e=1;
 int []B={36,78,18,41,165,75,55,40,125,91};
 for(a=2;a<B.Length;a++)
 {
 if(Math.Abs(B[0]-B[a])<Math.Abs(B[0]-B[e])) e=a;
 }
 Console.WriteLine("İlk Sayıya En Yakın Sayı = "+B[e]);
 Console.Write("Press any key to continue . . . ");
 Console.ReadKey(true); } } }
Ödev: Yukarıdaki programı, dizi değerleri dışarıdan girilecek şekilde düzenleyiniz.
*/

using System;

namespace EnYakinEleman
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] B = new int[10];

            // Kullanıcıdan dizinin elemanlarını alma
            Console.WriteLine("Lütfen 10 adet sayı girin:");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"Sayı-{i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out B[i]))
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
                    i--; // Hatalı girişi düzeltmek için dizideki bu elemanı tekrar iste
                }
            }

            int enYakinIndex = EnYakinElemanIndexiniBul(B);

            Console.WriteLine($"İlk Sayıya En Yakın Sayı = {B[enYakinIndex]}");
            Console.Write("bir tuşa basın...");
            Console.ReadKey();
        }

        // Verilen dizide, ilk elemana en yakın olan ikinci elemanın indisini bulan fonksiyon
        static int EnYakinElemanIndexiniBul(int[] dizi)
        {
            int enYakinIndex = 1; // İlk elemana en yakın elemanın dizideki indisini saklayacak değişken
            for (int i = 2; i < dizi.Length; i++)
            {
                if (Math.Abs(dizi[0] - dizi[i]) < Math.Abs(dizi[0] - dizi[enYakinIndex]))
                {
                    enYakinIndex = i;
                }
            }
            return enYakinIndex;
        }
    }
}
