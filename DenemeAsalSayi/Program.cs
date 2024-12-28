using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeAsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir sayi giriniz");
            sayi = int.Parse(Console.ReadLine());
            int kalan = 0;
            
            for (int i = sayi; i > 0; i--)
            {
                if(sayi%i == 0)
                {
                    kalan++;  //kalan 0 ve i başta sayıya eşit, o yüzden kalan 1 olacak.
                              // 0 dan büyükken, kalana bakacak. kalan 0 olursa kalan artacak
                }             //kalanın 2 olma durumunu kontrol edersek asal mı değil mi anlarız.
            

            }
            if (kalan == 2)
            {
                Console.WriteLine("Asal bir sayı" + sayi);
                Console.WriteLine("Kalan değeri: " + kalan);
            }

            else
            {
                Console.WriteLine("Asal bir sayi değil :" +sayi);
                Console.WriteLine("Kalan değeri: "+kalan);
            }


        }
    }
}
