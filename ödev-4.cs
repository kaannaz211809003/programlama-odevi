*/
//İkili sayı sistemindeki bir değeri onlu sayı sistemine dönüştüren program.
//static void Main(string[] args)
 {
 //int sayi, ikiliDeger, onluDeger = 0, tabanDeger = 1, basamakDeger;
 //sayi = 1010111001;
 //ikiliDeger = sayi;
// while (sayi > 0)
 {
 //basamakDeger = sayi % 10;
 //onluDeger = onluDeger + basamakDeger * tabanDeger;
 //sayi = sayi / 10;
 //tabanDeger = tabanDeger * 2;
 }
 //Console.Write("İkili (Binary) Sayı: " + ikiliDeger);
 //Console.Write("\nOnlu (Decimal) Sayı: " + onluDeger);
 //Console.ReadLine();
 }
 //Yukarıdaki örneği ikili sayı sistemindeki değeri klavyeden girilecek şekilde yeniden düzenleyiniz. 
 */




using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir ikili sayı girin: ");
        string ikiliSayiStr = Console.ReadLine();

        int onluDeger = Convert.ToInt32(ikiliSayiStr, 2);

        Console.Write("İkili (Binary) Sayı: " + ikiliSayiStr);
        Console.Write("\nOnlu (Decimal) Sayı: " + onluDeger);
        Console.ReadLine();
    }
}
