/*
// 1-99 arasındaki sayıları yazı ile yazdırır.
using System;
namespace or214
{
 class Program
 {
 public static void Main(string[] args)
 {
 byte a;
 string s=" ";
 string [] Birler={"Bir","İki","Üç","Dört","Beş","Altı","Yedi","Sekiz","Dokuz"};
 string [] Onlar={"On","Yirmi","Otuz","Kırk","Elli","Altmış","Yetmiş","Seksen","Doksan"};
 Console.Write("Bir Sayı Giriniz: ");//72 – 80 – 6 
 a=Byte.Parse(Console.ReadLine());
 if(a/10>=1){ //Sayı iki veya daha fazla basamaklı mı?
 s=Onlar[(a/10)-1];}//s= yetmiş – seksen -
 if (a%10!=0){ //Sayının son basamağı sıfır değilse yaz
 s=s+Birler[(a%10)-1];}//s= yetmiş+iki – “ altı”
 
 Console.WriteLine(s);//yetmişiki – seksen – “ altı”
 Console.Write("Press any key to continue . . . ");
 Console.ReadKey(true);
 } } }
0 1 2 3 4 5 6 7 8 9
78 56 23 95 68 87 61 77 45 33
23 56 78 95 68 87 61 77 45 33
23 33 78 95 68 87 61 77 45 56
23 33 45 95 68 87 61 77 78 56
23 33 45 56 68 87 61 77 78 95
23 33 45 56 61 87 68 77 78 95
23 33 45 56 61 68 87 77 78 95
23 33 45 56 61 68 77 87 78 95
23 33 45 56 61 68 77 78 87 95

ÖDEV: Programda önce girilen sayının en çok iki basamaklı ve 1 – 99 arasında pozitif sayı olduğunu kontrol ettiriniz. 
Eğer girilen sayı gerekli şartı sağlamıyor ise programın “Uygun değer girmediniz” mesajı ile sonlanmasını sağlayınız.
*/











public static void Main(string[] args)
{
    byte a;
    string s = " ";
    string[] Birler = {"Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz"};
    string[] Onlar = {"On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan"};

    Console.Write("Bir Sayı Giriniz (1-99 arası): ");
    if (!byte.TryParse(Console.ReadLine(), out a) || a < 1 || a > 99)
    {
        Console.WriteLine("Uygun değer girmedin.");
        Console.Write("Program sonlandı. Çıkış için bir tuşa basın.");
        Console.ReadKey(true);
        return;
    }
