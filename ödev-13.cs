/*,
7 öğretmenin adı “isim” dizisinde ve 7 şehir adı “il” dizisinde bulunmaktadır. Bu 7 öğretmeni rastgele her bir şehre bir 
öğretmen olmak üzere atayan programı yazınız.
using System;
namespace or218
{
 class Program
 {
 public static void Main(string[] args)
 {
 int sayi,a;
 string[]il={"Muş","Ağrı","Bolu","Mersin","Ankara","Sivas","Kayseri"};
 string[]isim={"Asuman","İclal","Emin","Bekir","Ahmet","Can","Esma"};
 bool[]D=new bool[7];
 for(a=0;a<=6;a++) Console.WriteLine("Bool D dizisinin "+a+". elemanı= "+D[a]);
 Random rastgele=new Random();
 for(a=0;a<=6;a++){
 do{ //bu döngü ve d[sayi]=true satırı ile bir şehire birden fazla öğretmen atanması engelleniyor.
 sayi=rastgele.Next(0,7);//sıfır dahil, 7 dahil değil.
 }while(D[sayi]==true);
 D[sayi]=true;
 Console.WriteLine(isim[a]+"\t= "+il[sayi]);
 }
 for(a=0;a<=6;a++) Console.WriteLine("Bool D dizisinin "+a+". elemanı= "+D[a]);
 Console.Write("Press any key to continue . . . ");
 Console.ReadKey(true);
 }
 }
}
ÖDEV: Yukarıdaki programı öğretmenlerin de sırayla değil, rastgele seçileceği şekilde yeniden düzenleyiniz.
*/

using System;

namespace TeacherCityAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
            string[] teachers = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };

            Random random = new Random();

            // Öğretmenlerin rastgele sıralanmış bir dizisi
            string[] shuffledTeachers = ShuffleArray(teachers, random);

            // Şehirlerin rastgele sıralanmış bir dizisi
            string[] shuffledCities = ShuffleArray(cities, random);

            Console.WriteLine("Öğretmenlerin Şehir Atamaları:");
            for (int i = 0; i < shuffledTeachers.Length; i++)
            {
                Console.WriteLine($"{shuffledTeachers[i]}\t= {shuffledCities[i]}");
            }

            Console.Write("tuşa basın . . . ");
            Console.ReadKey(true);
        }

        // Diziyi rastgele sıralamak için bir yardımcı metot
        static T[] ShuffleArray<T>(T[] array, Random random)
        {
            T[] shuffledArray = new T[array.Length];
            Array.Copy(array, shuffledArray, array.Length);

            int n = shuffledArray.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = shuffledArray[k];
                shuffledArray[k] = shuffledArray[n];
                shuffledArray[n] = value;
            }

            return shuffledArray;
        }
    }
}
