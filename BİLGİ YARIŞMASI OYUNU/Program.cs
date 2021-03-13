using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ_YARIŞMASI_OYUNU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("BİLGİ YARIŞMASINA HOŞGELDİNİZ");
            Console.Title = "BİLGİ YARIŞMASI";
            string isim, soyisim;
            Console.WriteLine("İsim:");
            isim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyisim:");
            soyisim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lütfen cevapları büyük harfle yazınız.");
            Console.WriteLine("soru geldikten sonra şıkları görmek için enter tuşuna basınız.");
            Console.WriteLine("Her sorudan sonra devam etmek için enter tuşuna basınız.");
            Console.WriteLine("Yarışmamız Başlıyor....");
            Console.WriteLine();
            int dogru = 0;
            int yanlis = 0;
            int para = 0;

           Console.WriteLine("Osmanlı devletinin kurucusu kimdir?");
           string c1;
            Console.Write(" A)Osman Bey\n B)Uluğ Bey\n C)Melikşah\n D)Fatih Sultan Mehmet\n Cevabınız:");
            c1 = Console.ReadLine();
            if (c1=="A")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevap girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Almanya'nın Başkenti neresidir?");
            string c2;
            Console.Write(" A)washington\n B)Paris\n C)Londra\n D)Berlin\n Cevabınız:\n");
            c2 = Console.ReadLine();
            if (c2=="D")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevabı girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }
            Console.WriteLine();

            Console.WriteLine("En uzun gecenin yaşandığı tarih?");
            string c3;
            Console.Write(" A)21 Aralık\n B)22 Aralık\n C)21 Haziran\n D)21 Kasım\n Cevabınız:");
            c3 = Console.ReadLine();
            if (c3 == "C")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevap girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Osmanlıda doğuya ilk sefer yapan Padişah?");
            string c4;
            Console.Write(" A)Kanuni Sultan Süleyman\n B)Yavuz Sultan Selim\n C)Fatih Sultan Mehmet\n D)4.Murat\n Cevabınız:\n");
            c4 = Console.ReadLine();
            if (c4 == "B")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevabı girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }
            Console.WriteLine("Osmanlı Devleti'nde ilk nüfus sayımı hangi padişah zamanında yapılmıştır?");
            string c5;
            Console.Write(" A)2.Mahmut\n B)1.Murat\n C)Yavuz Sultan Selim\n D)Fatih Sultan Mehmet\n Cevabınız:");
            c5 = Console.ReadLine();
            if (c5 == "A")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevap girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }

            Console.WriteLine();
            Console.WriteLine("İstiklal Marşının bestecisi kimdir?");
            string c6;
            Console.Write(" A)Mehmet Akif Ersoy\n B)Osman Zeki Öngör\n C)Can Yücel\n D)Eşref Altuğ\n Cevabınız:\n");
            c6 = Console.ReadLine();
            if (c6 == "B")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevabı girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }
            Console.WriteLine("Aşağıdakilerden Hangisi Güney Doğu Anadolu Bölgesinde değildir");
            string c7;
            Console.Write(" A)Mardin\n B)Adıyaman\n C)Batman\n D)Elazığ\n Cevabınız:");
            c7 = Console.ReadLine();
            if (c7 == "D")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevap girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Türkiye'de yüz ölçümü en büyük il?");
            string c8;
            Console.Write(" A)İstanbul\n B)Ankara\n C)Konya\n D)İzmir\n Cevabınız:\n");
            c8 = Console.ReadLine();
            if (c8 == "C")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevabı girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }
            Console.WriteLine("Müslüm Gürses'in gerçek soyadı?");
            string c9;
            Console.Write(" A)Tatlı\n B)Gürses\n C)Açıkgöz\n D)Akbaş\n Cevabınız:");
            c9 = Console.ReadLine();
            if (c9 == "D")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevap girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Atatür'ün boyu kaçtır?");
            string c10;
            Console.Write(" A)1.73\n B)1.74\n C)1.75\n D)1.72\n Cevabınız:\n");
            c10 = Console.ReadLine();
            if (c10 == "B")
            {
                Console.WriteLine("Tebrikler doğru cevabı girdin.");
                dogru = dogru + 1;
                para = para + 100;
            }
            else
            {
                Console.WriteLine("Yanlış cevabı girdiniz.Devam etmek için enter tuşuna basınız.");
                yanlis = yanlis + 1;
            }
            Console.WriteLine("Yarışmanız Bitti");
            Console.WriteLine("Sayın{0} {1}",isim,soyisim);
            Console.WriteLine("Toplam doğru: "+dogru);
            Console.WriteLine("Toplam yanlış: "+yanlis);
            Console.WriteLine("Toplam kazandığınız para: "+para+"TL");
            Console.ReadLine();
        }
    }
}
