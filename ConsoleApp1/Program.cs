using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Giriş için Temel Kurs" };

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            //ŞART BLOKLARI
            string ePosta = "user";
            string parola = "parola";

            //string girilenKullaniciAdi = "user";
            //string girilenParola = "parola";

            string girilenKullaniciAdi = "users";
            string girilenParola = "parolaa";

            if (girilenKullaniciAdi == ePosta)
            {
                if (girilenParola == parola)
                {
                    Console.WriteLine("Giriş Başarılı!");
                }
            }
            else
            {
                Console.WriteLine("Hatalı e-posta veya parola.");
            }

            string[] kayitliKurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" };
            if (kayitliKurslar[0] == "Yazılım Geliştirici Yetiştirme Kampı")
            {
                Console.WriteLine("'Yazılım Geliştirici Yetiştirme Kampı' KURSUNA KAYITLISINIZ.");
            }

            //DÖNGÜLER
            string[] dersProgrami = new string[] { "1.gün", "2.gün", "3.gün", "4.gün", "5.gün", "6.gün", "7.gün", "8.gün", "9.gün", "10.gün", "11.gün", "12.gün", "13.gün", "14.gün", "15.gün", "16.gün" };

            for (int i = 0; i < dersProgrami.Length; i++)
            {
                Console.WriteLine(dersProgrami[i]);
            }

            //FONKSİYONLAR
            static void next()
            {
                Console.WriteLine("Bitir ve devam et");
            }
            next();

            static void back()
            {
                Console.WriteLine("Önceki ders");
            }
            back();

            static int dersBitirmeOrani(int bitenDersler)
            {
                int oran = (bitenDersler * 100) / 16;
                return oran;
            }
            Console.WriteLine(dersBitirmeOrani(4));


        }
    }
}
