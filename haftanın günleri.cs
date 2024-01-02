using System;
namespace haftanin gunleri
{
class Program
 {
static void Main(string[] args)
 {
byte x = 2;
switch (x)
 {
case 1: Console.WriteLine("Pazartesi"); break;
case 2: Console.WriteLine("Salı"); break;
case 3: Console.WriteLine("Çarşamba"); break;
case 4: Console.WriteLine("Perşembe"); break;
case 5: Console.WriteLine("Cuma"); break;
case 6: Console.WriteLine("Cumartesi"); break;
case 7: Console.WriteLine("Pazar"); break;
default: Console.WriteLine("Yanlış Giriş Yaptınız..!"); break;
 }
Console.WriteLine("ÇIKIŞ İÇİN ENTER TUŞLA");
Console.ReadLine();
 }
 }
}