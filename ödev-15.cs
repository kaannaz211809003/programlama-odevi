/*
Örnek (Yaşar, 2011, 224): Bir otomobil fabrikasının ürettiği Molo, Metta ve Massat modellerinin sedan, station ve 
hatchback tipleri bulunmaktadır. Ayrıca her model ve tipin kırmızı, beyaz ve mavi renkleri de bulunmaktadır. Bu yapı 
için uygun bir dizi tanımlayarak her bir model, tip ve renge ait 0 – 10 arasında rastgele adet miktarı üreterek en yüksek 
adede sahip arabanın modelini, tipini ve rengini ekrana yazdırınız.
İpucu: Örneğe göre model, tip ve renk olmak üzere her bir model için toplam 9 ayrı çeşit otomobil vardır. 3 boyutlu ve 
her bir boyutu 3 elemanlı Araba isminde bir dizi tanımlayarak araba çeşitleri bellekte tutulabilir. Dizi model, tip ve renk
olmak üzere üç boyutlu olacaktır. Her bir boyutun da üç farklı değeri olacaktır. Dizi üç boyutlu olduğu için diziye eleman 
atarken ve elemanlarını işlerken iç içe üç adet for döngüsü kullanılmalıdır. Araba[model][tip][renk]
using System;
namespace or224
{class Program
 {public static void Main(string[] args)
 {
 int m,t,r,enbuyuk=-1500;
 String s="";
 int[,,]Araba=new int[3,3,3];//tüm boyutlar int o yüzden sitringleri tutacak bir dizi daha gerek
 String []isim={"Molo","Metta","Massat","Sedan","Station","Hatchback","Kırmızı","Beyaz","Mavi"};
 Random rastgele=new Random();
 for(m=0;m<=2;m++)
 {
 for(t=0;t<=2;t++)
 {
 for(r=0;r<=2;r++)
 {
 Araba[m,t,r]=rastgele.Next(11); } } }
 for(m=0;m<=2;m++) //en çok hangi üründen üretildiğini bulur!
 {
 for(t=0;t<=2;t++)
 {
 for(r=0;r<=2;r++)
 {
 if(Araba[m,t,r]> enbuyuk)
 {
 enbuyuk=Araba[m,t,r];// 5 – 8 - 9
 s=isim[m+0]+" "+isim[t+3]+" "+isim[r+6]+" "+enbuyuk+" Adet";//Molo Station Beyaz
//s=model[m]+” “+tip[t]+” “+renk[r]+” “+enbuyuk+” adet üretilmiştir”;
 } } } }
 Console.Write("En yüksek adete sahip araba: ");
 Console.WriteLine(s);
 Console.Write(" Press any key to continue . . . ");
 Console.ReadKey(true); } } }
Ödev: Yukarıdaki programı, en yüksek adete sahip birden fazla ürün olduğunda bunların tamamını da ekrana yazacak 
şekilde yeniden düzenleyiniz. İpucu: önce en çok üretim adedi değer olarak üçlü for döngü grubunun en içteki 
döngüsünde if ile bulunur. Daha sonra yeni bir üçlü for döngüsü grubu içinde en yüksek üretim adedi tüm üretim 
adetleriyle karşılaştırılır. Eşit olan yerde if kapsamından çıkmadan isimler dizisinden m, t, r değişkenlerinin işaret ettiği
isimler s stringinde birleştirilerek veya doğrudan Console.WriteLine() metodu içinde birleştirilerek ekrana yazılır.
*/





using System;

namespace or224
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m, t, r, maxCount = -1;
            string s = "";
            int[,,] Araba = new int[3, 3, 3];
            string[] isim = { "Molo", "Metta", "Massat", "Sedan", "Station", "Hatchback", "Kırmızı", "Beyaz", "Mavi" };
            Random rastgele = new Random();

            for (m = 0; m <= 2; m++)
            {
                for (t = 0; t <= 2; t++)
                {
                    for (r = 0; r <= 2; r++)
                    {
                        Araba[m, t, r] = rastgele.Next(11);
                    }
                }
            }

            for (m = 0; m <= 2; m++)
            {
                for (t = 0; t <= 2; t++)
                {
                    for (r = 0; r <= 2; r++)
                    {
                        if (Araba[m, t, r] > maxCount)
                        {
                            maxCount = Araba[m, t, r];
                        }
                    }
                }
            }

            Console.WriteLine("En yüksek adete sahip arabalar:");

            for (m = 0; m <= 2; m++)
            {
                for (t = 0; t <= 2; t++)
                {
                    for (r = 0; r <= 2; r++)
                    {
                        if (Araba[m, t, r] == maxCount)
                        {
                            s = isim[m] + " " + isim[t + 3] + " " + isim[r + 6] + " " + maxCount + " Adet";
                            Console.WriteLine(s);
                        }
                    }
                }
            }

            Console.Write("bir tuşa bas . . . ");
            Console.ReadKey(true);
        }
    }
}
