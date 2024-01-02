/* 
Örnek (YAŞAR, 2011, 213): (Sıralama algoritması)
// 10 Elemanlı bir dizinin elemanlarını küçükten büyüğe doğru sıralayınız.
using System;
namespace or213
{
 class Program
 {
 public static void Main(string[] args)
 {
 int i,j,gecici,EnKucukYer;
 int []A={78, 56, 23, 95 ,68,87,61,77,45,33};
 for(i=0; i<=A.Length-1;i++)
 {
 EnKucukYer=i;//1-1. EnKucukYer=0, EnKucukYer=1
 for(j=i+1;j<=A.Length-1;j++){//2-1. J=1, j=2, j=3, j=4, j=5, j=6, j=7, j=8, j=9—2-2 j=2
 if(A[j]<A[EnKucukYer]) EnKucukYer=j;//2-1 enkucukyer=1, enkucukyer=2, 
 }
 gecici=A[i];//1.1. gecici=78
 A[i]=A[EnKucukYer];//1-1 A[0]=23
 A[EnKucukYer]=gecici;//1-1 A[2]=78 //{23,56,78,95,68,87,61,77,45,33}
 Console.WriteLine(A[i]);// 23
 }
 Console.Write("Press any key to continue . . . ");
 Console.ReadKey(true); 
 } } }
ÖDEV: Programı, diziyi büyükten küçüğe yerleştirecek şekilde yeniden yazınız.
*/


using System;

namespace or213
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, j, gecici, EnBuyukYer;
            int[] A = { 78, 56, 23, 95, 68, 87, 61, 77, 45, 33 };
            
            for (i = 0; i < A.Length - 1; i++)
            {
                EnBuyukYer = i;
                for (j = i + 1; j < A.Length; j++)
                {
                    if (A[j] > A[EnBuyukYer]) // Büyükten küçüğe doğru sıralama yapması sağlanır.
                        EnBuyukYer = j;
                }
                gecici = A[i];
                A[i] = A[EnBuyukYer];
                A[EnBuyukYer] = gecici;
            }

            Console.WriteLine("Büyükten küçüğe sıralanmış dizi:");
            for (i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.Write("her hangi bir tuşa basınız . . . ");
            Console.ReadKey(true);
        }
    }
}
