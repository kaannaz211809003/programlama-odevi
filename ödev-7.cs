/* //aldığı burs 500TL altında olanlara %10 ve +50 TL sabit artış yapan program!
//burs miktarları a dizi değişkeninde saklanıyor!
using System;
namespace or096
{
 class Program
 {
 public static void Main(string[] args)
 {
 double[] a={150,600,700,450,850,275,950,1500,210,368};
 int b;
 for (b=0;b<=9;b++){ //foreach(double d in a){
 if(a[b]>=500)
{//burs miktarı 500 ve üzeri olanlara artış yapılmıyor!
 Console.WriteLine(a[b]); //a[1]=600, a[2]=700, a[4]=850, a[6]=950, a[7]=1500,
 continue;//döngünün aşağıdaki satırları çalışmadan yeni çevrime gider!
 }
 a[b]=(a[b]*0.1)+a[b]; 
 a[b]=a[b]+50; //a[0]=215, a[3]=545, a[5]=352,5, a[8]=281, a[9]=454,8
 Console.WriteLine(a[b]); //215,545,352.5,281,454.8
 }
 Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
 Console.ReadKey(true);
 } } }Örnek096’yı foreach ile yeniden yazınız.
ÖDEV: for/while/do-while ile yaptığınız tüm örnekleri bu kelimeleri kullanmadan goto-label kelimelerini kullanarak 
yapmaya çalışınız.*/

using System;

namespace or096
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

            foreach (double burs in a)
            {
                if (burs < 500)
                {
                    burs = burs * 1.1 + 50;
                    Console.WriteLine(burs);
                }
                else
                {
                    Console.WriteLine(burs);
                }
            }

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}


using System;

namespace GotoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };
            int b = 0;

        startLoop:
            if (b < a.Length)
            {
                if (a[b] < 500)
                {
                    a[b] = a[b] * 1.1 + 50;
                    Console.WriteLine(a[b]);
                }
                else
                {
                    Console.WriteLine(a[b]);
                }
                b++;
                goto startLoop;
            }

            Console.Write("her hangi bir tuşa basınız... ");
            Console.ReadKey(true);
        }
    }
}
