namespace EmlakciUygulamasiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool appcontrol = true;
            do
            {
                Console.WriteLine("HOŞGELDİNİZ.");
                Console.WriteLine("Lütfen Bir Seçim Yapınız:");
                Console.WriteLine("1-Satılık Ev");
                Console.WriteLine("2-Kiralık Ev");
                string secim = Console.ReadLine();

                KiralikEv1 kiralik = new KiralikEv1();
                SatilikEv1 satilik = new SatilikEv1();
                bool kontrol = true;

                if (secim == "1")
                {
                    Console.WriteLine("1- Satılık Ev Bilgileri:");
                    Console.WriteLine("2- Yeni Satılık Ev Kayıt Formu:");
                    string satiliksecim = Console.ReadLine();

                    if (satiliksecim == "1")
                    {
                        Console.WriteLine(satilik.EvBilgileriGetir());
                    }
                    else if (satiliksecim == "2")
                    {
                        List<string> satilikkayit = new List<string>();
                        do
                        {
                            Console.WriteLine("Yeni Satılık Ev Kayıdı Giriniz:");
                            Console.WriteLine("Oda Sayısı:");
                            satilik.Odasayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kat No:");
                            satilik.Katno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Alan");
                            satilik.Alan = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Satış Fiyatı:");
                            satilik.Satisfiyat = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Kayıta Devam Etmek İster misiniz?   (EVET/HAYIR)");
                            string sorgu = Console.ReadLine().ToUpper();
                            if (sorgu == "HAYIR")
                            {
                                kontrol = false;
                                Console.WriteLine("Girilen Evlerin Bilgileri Dosyaya Başarıyla Kaydedildi.");
                            }
                            satilikkayit.Add(satilik.EvBilgileri());
                        } while (kontrol);
                        satilik.EvKayit(satilikkayit);
                    }
                }

                else if (secim == "2")
                {
                    Console.WriteLine("1- Kayıtlı Kiralık Evleri Görüntüle: ");
                    Console.WriteLine("2-  Yeni Kiralık Ev Kaydı:");
                    string kiraliksecim = Console.ReadLine();
                    if (kiraliksecim == "1")
                    {
                        Console.WriteLine(kiralik.EvBilgileriGetir());
                    }
                    else if (kiraliksecim == "2")
                    {
                        List<string> kiralikkayit = new List<string>();
                        do
                        {
                            Console.WriteLine("Yeni Kiralık Ev Kayıdı Giriniz:");
                            Console.WriteLine("Oda Sayısı:");
                            kiralik.Odasayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kat No:");
                            kiralik.Katno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Alan");
                            kiralik.Alan = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Kira Fiyatı: ");
                            kiralik.Kira = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Depozito Ücreti:");
                            kiralik.Depozito = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Kayıta Devam Etmek İster misiniz?");
                            string sorgu = Console.ReadLine().ToUpper();
                            if (sorgu == "HAYIR") ;
                            {
                                kontrol = false;
                                Console.WriteLine("Girilen Evlerin Bilgileri Dosyaya Başarıyla Kaydedildi.");
                            }
                            kiralikkayit.Add(kiralik.EvBilgileri());
                        } while (kontrol);
                    }
                }

                else
                {
                    Console.WriteLine("Bir Hata Oluştu!");
                }
                Console.WriteLine("Başka Bir İşlem Yapmak İster Misiniz? E/H");
                string tercih = Console.ReadLine().ToUpper();
                if( tercih =="H")
                {
                    appcontrol = false;
                }

            } while (appcontrol);

        }
    }
}