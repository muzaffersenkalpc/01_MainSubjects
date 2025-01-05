using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnmekleri

            //2.4.6.8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü[] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kirmizi";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);








            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 46;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]); //def value 0,


            //string[] cities = { "Prag", "Roma", "Istanbul", "Barcelona" };

            //Console.WriteLine(cities[3]);

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) {

            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 88, 520, 756, 2365, 1120 };
            //int temp=0;
            //for (int i = 0;i < numbers.Length; i++) {

            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //        temp++;
            //    }


            //}
            //Console.WriteLine("3e bölünen toplam sayı : "+ " " + temp);


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++) {

            //    Console.WriteLine(symbols[i,]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 860, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "ahmet", "ayşe" };
            //Console.WriteLine(persons.Length);
            //int[] numbers = { 45, 85, 52, 41, 76, 10, 22, 35 };
            //{ 
            //    Array.Sort(numbers);
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "deniz" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 86, 97, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("dizinin en büyük elemenaı : " + numbers.Max()+ "Dizinin en küçük elemanı : "+numbers.Min());

            #endregion

            #region Kullanıcıdan Değer almaa

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. Şehri Giriniz ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum = sum + numbers[i];
            //}
            //Console.WriteLine(sum);



            #endregion


            Console.Read();

        }

       
    }
}
