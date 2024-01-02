/*
Örnek (YAŞAR, 2011, 259): Dışarıdan girilen kelimenin küçük harflerini büyük yazan program. (C# için ToUpper 
kullanmadan)
İpucu: Küçük harfler ASCII kodu olarak 97’den, büyük harfler ise 65’ten başlar. Küçük harfin ASCII kodu büyük 
harfinkinden 32 büyüktür. Buna göre bir karakterin önce ASCII kodunu bulup, daha sonra ASCII kodu eğer 97’den 
büyük ise o karakterin küçük harf olduğuna karar verip, daha sonra ASCII kodundan 32 çıkarmak gerekir ki büyük harfe 
dönüşsün. En son olarak ta ASCII kodu yeniden karaktere dönüştürmek gerekecektir.
using System;
namespace or259
{
 class Program
 {
 public static void Main(string[] args)
 {
 string s, ys="";
 int a;
 byte c;
 Console.Write("Bir cümle giriniz:");
 s=Console.ReadLine();
 for(a=0;a<s.Length;a++)
 {
 c=(byte)s[a];//s stringinin sıradaki karakterinin ASCII kodu elde ediliyor!
 if(c>=97 && c<=122) //küçük harf ise
 ys=ys+(char)(c-32);//ASCII kodu tekrar karaktere dönüştürülüyor!
 else ys=ys+s[a];
 }
 Console.WriteLine(ys);
 Console.WriteLine("\n\nPress any key to continue . . . ");
 Console.ReadKey(true);
 }
 }
}
ÖDEV: ToLower() metodunu kullanmadan büyük harfleri küçük harfe dönüştüren C# progamını kodlayınız
*/

using System;

namespace Ornek
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s, ys = "";
            int a;
            byte c;
            
            Console.Write("Bir cümle veya kelime girin: ");
            s = Console.ReadLine();

            for (a = 0; a < s.Length; a++)
            {
                c = (byte)s[a]; // s stringinin sıradaki karakterinin ASCII kodu elde ediliyor!

                if (c >= 65 && c <= 90) // büyük harf ise
                {
                    // ASCII kodu tekrar karaktere dönüştürülüyor!
                    ys = ys + (char)(c + 32);
                }
                else
                {
                    ys = ys + s[a];
                }
            }

            Console.WriteLine(ys);
            Console.WriteLine("\n\nbir tuşa basın...");
            Console.ReadKey(true);
        }
    }
}
