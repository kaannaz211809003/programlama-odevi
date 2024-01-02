
using System;

namespace OtoparkUcretiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otoparka gelen aracin türünü girin (1: Otomobil, 2: Kamyon, 3: İş Makinasi):");
            int aracTuru = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Otoparka gelen aracin kalma süresini girin (saat cinsinden):");
            int kalmaSuresi = Convert.ToInt32(Console.ReadLine());

            double toplamUcret = 0;

            if (aracTuru == 1) // Otomobil
            {
                if (kalmaSuresi <= 2)
                {
                    toplamUcret = 5;
                }
                else if (kalmaSuresi > 2 && kalmaSuresi <= 10)
                {
                    toplamUcret = 5 + (kalmaSuresi - 2);
                }
                else if (kalmaSuresi > 10)
                {
                    int gunSayisi = kalmaSuresi / 24;
                    int saatSayisi = kalmaSuresi % 24;

                    if (saatSayisi <= 2)
                    {
                        toplamUcret = (gunSayisi * 13) + 5;
                    }
                    else
                    {
                        toplamUcret = (gunSayisi * 13) + 5 + (saatSayisi - 2);
                    }
                }
            }
            else if (aracTuru == 2) // Kamyon
            {
                if (kalmaSuresi <= 2)
                {
                    toplamUcret = 8;
                }
                else if (kalmaSuresi > 2 && kalmaSuresi <= 8)
                {
                    toplamUcret = 8 + ((kalmaSuresi - 2) * 2);
                }
                else if (kalmaSuresi > 8)
                {
                    int gunSayisi = kalmaSuresi / 24;
                    int saatSayisi = kalmaSuresi % 24;

                    if (saatSayisi <= 2)
                    {
                        toplamUcret = (gunSayisi * 17) + 8;
                    }
                    else
                    {
                        toplamUcret = (gunSayisi * 17) + 8 + ((saatSayisi - 2) * 2);
                    }
                }
            }
            else if (aracTuru == 3) // İş Makinası
            {
                if (kalmaSuresi <= 2)
                {
                    toplamUcret = 12;
                }
                else if (kalmaSuresi > 2 && kalmaSuresi <= 8)
                {
                    toplamUcret = 12 + ((kalmaSuresi - 2) * 3);
                }
                else if (kalmaSuresi > 8)
                {
                    int gunSayisi = kalmaSuresi / 24;
                    int saatSayisi = kalmaSuresi % 24;

                    if (saatSayisi <= 2)
                    {
                        toplamUcret = (gunSayisi * 25) + 12;
                    }
                    else
                    {
                        toplamUcret = (gunSayisi * 25) + 12 + ((saatSayisi - 2) * 3);
                    }
                }
            }

            Console.WriteLine("Çikiş ücreti: " + toplamUcret + " TL.");

            Console.ReadLine();
        }
    }
}

