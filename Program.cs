namespace GaziNotHesaplamaProje_01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int ogrSayisi = 0;
            const double VizeKatsayisi = 0.4;
            const double FinalKatsayisi = 0.6;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------GAZİ TUSAŞ MYO NOT SİSTEMİ Proje Ödevi-----------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();


            while (true)
            {
                try
                {
                    Console.Write("Sınıf mevcudunu giriniz: ");
                    ogrSayisi = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Beep(1500, 500);
                    Console.WriteLine("Lütfen rakam kullanınız.");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Beep(1500, 500);
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                    Console.ResetColor();
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Beep(1500, 500);
                    Console.WriteLine("Bilinmeyen bir hata oluştu.");
                    Console.ResetColor();
                }
            }

            string[] ogrAdSoyad = new string[ogrSayisi];
            string[] harf = new string[ogrSayisi];

            long[] ogrNumara = new long[ogrSayisi];
            double[] vize = new double[ogrSayisi];
            double[] final = new double[ogrSayisi];
            double[] ortalama = new double[ogrSayisi];

            string template = "| {0,-12} | {1,-29} | {2,-5} | {3,-5} | {4,-10:F2} | {5,-4} |";

            double enYuksekNot = 0.0;
            double enDusukNot = 100;
            double sinifOrtalamasi = 0.0;
            const double gecmeNotu = 40.0;

            int gecenOgrenciSayisi = 0;

            for (int i = 0; i < ogrSayisi; i++)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"-----{i + 1}. Öğrencinin Veri Girişi----- ");
                    Console.ResetColor();
                    Console.Write("Öğrenci Numarası: ");
                    try
                    {
                        ogrNumara[i] = long.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Lütfen rakam kullanınız.");
                        Console.ResetColor();
                    }
                    catch (OverflowException)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                        Console.ResetColor();
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Bilinmeyen bir hata oluştu!!!");
                        Console.ResetColor();
                    }
                }
                Console.Write("Ad-Soyad: ");
                ogrAdSoyad[i] = Console.ReadLine();
                while (true)
                {
                    Console.Write("Vize Notu (0-100): ");
                    try
                    {
                        vize[i] = double.Parse(Console.ReadLine());
                        if (vize[i] > 100 || vize[i] < 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Beep(1500, 500);
                            Console.WriteLine("Lütfen Notu 0-100 Arasında giriniz. ");
                            Console.ResetColor();
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Lütfen rakam kullanınız.");
                        Console.ResetColor();
                    }
                    catch (OverflowException)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                        Console.ResetColor();
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Bilinmeyen bir hata oluştu!!!");
                        Console.ResetColor();
                    }
                }
                while (true)
                {
                    Console.Write("Final Notu (0-100): ");
                    try
                    {
                        final[i] = double.Parse(Console.ReadLine());
                        if (final[i] > 100 || final[i] < 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Beep(1500, 500);
                            Console.WriteLine("Lütfen Notu 0-100 Arasında giriniz. ");
                            Console.ResetColor();
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Lütfen rakam kullanınız.");
                        Console.ResetColor();
                    }
                    catch (OverflowException)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                        Console.ResetColor();
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep(1500, 500);
                        Console.WriteLine("Bilinmeyen bir hata oluştu!!!");
                        Console.ResetColor();
                    }
                }

                ortalama[i] = (vize[i] * VizeKatsayisi) + (final[i] * FinalKatsayisi);
                harf[i] = "";

                if (ortalama[i] >= 85) harf[i] = "AA";
                else if (ortalama[i] >= 70) harf[i] = "BA";
                else if (ortalama[i] >= 60) harf[i] = "BB";
                else if (ortalama[i] >= 50) harf[i] = "CB";
                else if (ortalama[i] >= 40) harf[i] = "CC";
                else if (ortalama[i] >= 30) harf[i] = "DC";
                else if (ortalama[i] >= 20) harf[i] = "DD";
                else if (ortalama[i] >= 10) harf[i] = "FD";
                else harf[i] = "FF";

                if (ortalama[i] < enDusukNot) enDusukNot = ortalama[i];
                if (ortalama[i] > enYuksekNot) enYuksekNot = ortalama[i];
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{i + 1}.Öğrenci Kaydı Alındı. \n");
                Console.ResetColor();

            }
            Console.Clear();
            sinifOrtalamasi = ortalama.Sum() / ogrSayisi;
            for (int i = 0; i < ogrSayisi; i++)
            {
                if (ortalama[i] > gecmeNotu) gecenOgrenciSayisi++;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------GAZİ TUSAŞ MYO NOT SİSTEMİ Proje Ödevi-----------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("====================================================================================");
            Console.ResetColor();
            Console.WriteLine(template,
                "NUMARA", "AD SOYAD ", "VİZE", "FİNAL", "ORTALAMA", "HARF");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("====================================================================================");
            Console.ResetColor();

            for (int i = 0; i < ogrSayisi; i++)
            {
                Console.WriteLine(template,
                    ogrNumara[i],
                    ogrAdSoyad[i],
                    vize[i],
                    final[i],
                    ortalama[i],
                    harf[i]
                    );
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("************************************SINAV RAPORU************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Sınıf mevcudu: " + ogrSayisi);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Sınıf ortalaması: {sinifOrtalamasi:F2}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"En yüksek not: {enYuksekNot:F2}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"En düşük not: {enDusukNot:F2}");
            Console.ResetColor();
            double dersiGecmeYuzdesi = (gecenOgrenciSayisi * 100) / ogrSayisi;

            if (dersiGecmeYuzdesi >= 70.0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (dersiGecmeYuzdesi >= 40.0 && dersiGecmeYuzdesi < 70.0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (dersiGecmeYuzdesi >= 0.0 && dersiGecmeYuzdesi < 40.0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"Dersi geçme yüzdesi: %{dersiGecmeYuzdesi:F2}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("************************************************************************************");
            Console.ResetColor();
        }
    }
}
