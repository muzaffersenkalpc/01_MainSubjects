using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("x");
            //}

            #endregion

            #region Yan yana 10 tane yıldız

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("x");
            //}

            #endregion

            #region Alt Alta 10 tane yıldız oluşturma her satırda 10 yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("x");
            //    for (int j= 1; j <=9 ; j++)
            //        {
            //            Console.Write("x");
            //        }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Dik üçgen

            //for (int i = 1; i <= 20; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Ters Dik Üçgen

            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 10; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Dik ve Ters Üçgen Beraber

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine("");
            //}
            //for (int i = 1; i <= 10; i++)
            //{ 
            //    for (int j = 10; j >= i; j--)
            //{
            //    Console.Write("*");
            //}
            //    Console.WriteLine("");

            //}

            #endregion

            #region Baklava dilimi

            // int n = 5;
            // //üst kısım
            // for (int i = 1; i < n; i++)
            // {
            //     for (int j = n-1; j > 0 ; j--)
            //     {
            //         Console.Write(" ");
            //     }
            //     for (int k = 1; k <= 2*i-1; k++)    
            //     {
            //         Console.Write("*");
            //     }

            //     Console.WriteLine();


            // }
            ////alt kısım
            // for (int i = n - 1; i >= 1; i--)
            // {
            //     for (int j = n - 1; j > 0; j--)
            //     {
            //         Console.Write(" ");
            //     }
            //     for (int k = 1; k <= 2 * i - 1; k++) //sağ alt
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }


            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for(int j=n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("x");
            //    }
            //    Console.WriteLine(" ");
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //bşluklar

            //    for(int j=n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar

            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("x");
            //    }
            //    Console.WriteLine();
            //}
            

            #endregion

        }
    }
}
