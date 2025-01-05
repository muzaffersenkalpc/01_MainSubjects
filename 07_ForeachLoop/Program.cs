using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach

            //Foreeach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon,Dizi

            //string[] cities = { "milano", "rome", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total = total + number;

            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** c# eğitim kampı sınav uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma.
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var?");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler.
            //string[] studentNames = new string[studentCount];
            //double[] studenttExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)

            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. Sınav notunu giriniz:");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult = totalExamResult + value; //notları topluyoruz.

            //    }
            //    studenttExamAvg[i] = totalExamResult / 3;
            //}
            //    //Sınav ortalamaları

            //    for (int i = 0; i < studentCount; i++)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studenttExamAvg[i]}");

            //    Console.WriteLine("------------------------------");
            //    //Öğrencinin ortalaması ve geçip kalma durumları
            //    if (studenttExamAvg[i] >= 50)
            //        {
            //            Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //        }

            //        else
            //        {
            //            Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //        }
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("------------------------------");
            //}


            //}





            #endregion

        }
    }
}

