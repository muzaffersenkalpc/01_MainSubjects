using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customar->Listele,ekle,sil,güncelle
            //Void metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("X");
            //    Console.WriteLine("Y");
            //    Console.WriteLine("Z");
            //    Console.WriteLine("T");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye değer döndürmeyen parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("XXX YYY");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri : "+ name +" " + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");
            #endregion

            #region Geriye değer döndürmeyen parametreli Metotlar

            //void Sum(int number1,int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 2, 3);



            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    //string name = "Ali";
            //    //string surName = "Kaya";
            //    //return name + " " + surName;
            //    //return "Ali Kaya"; Aynı şeyi burada da yapabiliyoruz.
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke : " + countryName + "-Başkent " + capital + "-Bayrak rengi " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ulke Adını giriniz: ");
            //x = Console.ReadLine();

            //Console.WriteLine("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Turkiye","Ankara","Kırmızı"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(45, 25));
            //Console.WriteLine(Sum(45, 999));
            //Console.WriteLine(Sum(45, 20));
            #endregion

            #region Ornek uygulama

            //string ExamResult(string student, int exam1, int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result >= 50)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine();
            //        return student + " sınavı geçti";

                    
            //    }
            //    else
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine();
            //        return student + " basarısız oldu";
                    
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali",25,41,30));
            //Console.WriteLine(ExamResult("İsmail", 25, 41, 80));

            #endregion
        }
    }
}
