/*
10 Elemanlı A dizisinde isimler, B dizisinde de bilgisayar sınav notları vardır. A'nın sıfırıncı elemanındaki ismin bilgisayar 
notu B dizisinin sıfırıncı elemanındadır. En yüksek notu alan kişinin adını ekrana yazdırınız.
/* B dizisinde en büyük notun sırası A dizisindeki isme karşılık geleceğinden amaç
* B dizisindeki en yüksek notun sırasını öğrenmektir. */
/*
using System;
namespace or211
{ class Program
 { public static void Main(string[] args)
 { int c, EnBuyuk=-1500, yer=0;
 String [] A={"Emin", "Emir","İclal","Bekir","Cem","Arda","Kaan","Metin","Can","Ramiz"};
 int [] B={56,78,95,23,95,87,61,77,45,33};
 for (c=0;c<=B.Length-1;c++){
 if(B[c]>= EnBuyuk){
 EnBuyuk=B[c];
 yer=c; }
 }
 Console.WriteLine("En Yüksek Notu Alan Kişi: "+A[yer]);
 Console.Write("Press any key to continue . . . ");
 Console.ReadKey(true);
 } } }
ÖDEV: en yüksek ve en düşük notu alan birden fazla kişi varsa onların da isimlerini yazdırınız.

*/

using System;

namespace or211
{
    class Program
    {
        public static void Main(string[] args)
        {
            int c, EnBuyuk = -1500, EnKucuk = 1500;
            String[] A = {"Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz"};
            int[] B = {56, 78, 95, 23, 95, 87, 61, 77, 45, 33};
            
            // En yüksek ve en düşük notları bulma
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] >= EnBuyuk)
                {
                    EnBuyuk = B[c];
                }

                if (B[c] <= EnKucuk)
                {
                    EnKucuk = B[c];
                }
            }

            Console.WriteLine("En Yüksek Notu Alan Kişi(ler): ");
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] == EnBuyuk)
                {
                    Console.WriteLine(A[c]);
                }
            }

            Console.WriteLine("\nEn Düşük Notu Alan Kişi(ler): ");
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] == EnKucuk)
                {
                    Console.WriteLine(A[c]);
                }
            }

            Console.Write("\nher hangi bir tuşa basınız . . . ");
            Console.ReadKey(true);
        }
    }
}
