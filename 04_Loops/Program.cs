using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            //int i;
            //for(i=1; i<=5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı "+i +".ci döngü");
            //}

            //for(int i=1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz:");
            //int finishValue = int.Parse(Console.ReadLine());
            //for(int i = 1; i<=finishValue; i++)
            //{
            //    Console.WriteLine(i+"nci"+"Yaşasın cumhuriyet");
            //}


            #endregion

            #region For döngüsü ile karar yapıları
            //for(int i=1; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue=0;

            //for(int i=1; i<=10; i++)
            //{

            //    totalValue = totalValue+i;


            //}
            //Console.WriteLine("Toplam deger: " +totalValue);

            //int total = 0;

            //for(int i=1; i<20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total = total + i;
            //    }
            //}

            //Console.WriteLine("1-20 arasındaki çift sayıların toplamı:" +total);

            //int j = 0;
            //for(int i=1; i<50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        j++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Toplam " +j + " Sayi bölünür");

            //int bacterium = 1;

            //for(int i=1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + " .Saat sonunda "+bacterium);
            //}



            #endregion

            #region While Döngüsü
            //While(şart)
            //{
            //işlemler
            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba while döngüsü");
            //    i++;
            //}

            //int i = 1;
            //while (i < 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamaklarını topla

            //Console.WriteLine("3 basamaklı bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int basamakToplami=0;
            
            //for(int i=1; i<=3; i++)
            //{
            //    basamakToplami = sayi % 10 + basamakToplami;
            //    sayi = sayi / 10;
                
            //}
            //Console.WriteLine(basamakToplami);
            


            #endregion
        }
    }
}
