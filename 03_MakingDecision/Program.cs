using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if(capital == "ankara" && country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı.");
            //}

            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //    Console.Read();

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("1. notu giriniz : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. notu giriniz:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. notu giriniz:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması : " + average);

            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "Sonuc Orta";
            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok iyi";
            //}


            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız");
            //city = Console.ReadLine();
            //if (city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz : ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz admin");
            //}




            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan sayı : "+result);

            //Tek mi çiftmi ---------------
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int number = int.Parse(Console.ReadLine());

            //if(number %2 != 0)
            //{
            //    Console.WriteLine("Sayınız tek sayı");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız çift");
            //}
            #endregion

            #region Char değişkenler ile Karar yapıları
            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if(team == 'g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("****** C# eğitim kampı restoran *******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("1- Ana yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav ");
            //    Console.WriteLine("4-Fırında somon ");
            //    Console.WriteLine("5-Patlıcan Musakka ");
            //    Console.WriteLine("----------Ana yemekler-----------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Tavuk Çorbası");
            //    Console.WriteLine("3-Ezogelin Çorba ");               
            //    Console.WriteLine("----------Çorbalar-----------");

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Karışık Pizza");
            //    Console.WriteLine("2-Akdeniz Pizza");
            //    Console.WriteLine("3-margarita ");
            //    Console.WriteLine("----------Pizzalar-----------");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Gazoz ");
            //    Console.WriteLine("----------İçecekler-----------");

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilece");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç ");
            //    Console.WriteLine("----------Tatlılar-----------");

            //}
            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişi yapınız :");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat");break;
            //    case 3: Console.WriteLine("Mart");break;
            //    case 4: Console.WriteLine("Nisan");break;
            //    case 5: Console.WriteLine("Mayıs");break;
            //    case 6: Console.WriteLine("Haziran");break;
            //    case 7: Console.WriteLine("Temmuz");break;
            //    case 8: Console.WriteLine("Ağustos");break;
            //    case 9: Console.WriteLine("Eylül");break;
            //    case 10: Console.WriteLine("Ekim");break;
            //    case 11: Console.WriteLine("Kasım");break;
            //    case 12: Console.WriteLine("Aralık");break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;

            //}

            #endregion

            #region Calculator with Switch-Case
            //int number1, number2, result;

            //char symbol;
            //Console.Write("1.sayiyi giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " +result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark:" + result);
            //        break;
            //    case '/':
            //        result = number1 - number2;
            //        Console.WriteLine("Bölüm:" + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım:" + result);
            //        break;

            //    default: Console.WriteLine("Hatalı giriş.");
            //        break;

            }

            #endregion

        }
    }
}
