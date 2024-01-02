// Kullanıcıdan kilo ve cinsiyet bilgileri alınıyor.
Console.WriteLine("Kilonuzu girin: ");
double kilo = Convert.ToDouble(Console.ReadLine());

 

Console.WriteLine("Cinsiyetinizi girin (Erkek veya Kadın): ");
string cinsiyet = Console.ReadLine();

 

// Kullanıcıdan boy bilgisini cm cinsinden alıyoruz.
Console.WriteLine("Boyunuzu girin (cm): ");
double boyCm = Convert.ToDouble(Console.ReadLine());

 

// Boy bilgisini inçe dönüştürüyoruz.
double boyInch = boyCm / 2.54;

 

// İdeal kiloyu hesaplamak için farklı formüller kullanılıyor.
double idealKilo = 0;

 

if (cinsiyet.ToLower() == "kadın")
{
    idealKilo = 45.5 + 2.3 * (boyInch - 60);
}
else if (cinsiyet.ToLower() == "erkek")
{
    idealKilo = 50 + 2.3 * (boyInch - 60);
}
else
{
    Console.WriteLine("Geçersiz cinsiyet bilgisi girdiniz.");
    return;
}

 

// Kullanıcının ideal kilosunu kontrol edip ekrana yazdırıyoruz.
if (kilo == idealKilo)
{
    Console.WriteLine("Kilonuz idealdir.");
}
else if (kilo > idealKilo)
{
    Console.WriteLine("Kilonuz ideal kilodan daha fazladır.");
}
else
{
    Console.WriteLine("Kilonuz ideal kilodan daha azdır.");
}