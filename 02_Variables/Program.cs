﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            ////double number;
            ////number = 4.85;

            ////Console.WriteLine(number);


            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL ");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL ");

            //Console.WriteLine(); 
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan ürün : Elma - " + "Birim Fiyat: " + applePrice + " Gramaj: " + appleGram + " Toplam tutar: " + appleTotalPrice); ;
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün : Portakal - " + "Birim Fiyat: " + orangePrice + " Gramaj: " + orangePrice + " Toplam tutar: " + orangeTotalPrice); ;
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün : Çilek - " + "Birim Fiyat: " + strawberryPrice + " Gramaj: " + strawberryPrice + " Toplam tutar: " + strawberryTotalPrice); ;
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün : Patates - " + "Birim Fiyat: " + potatoPrice + " Gramaj: " + potatoPrice + " Toplam tutar: " + potatoTotalPrice); ;
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün : Domates - " + "Birim Fiyat: " + tomatoPrice + " Gramaj: " + tomatoGram + " Toplam tutar: " + tomatoTotalPrice); ;
            //Console.WriteLine();


            //double shoppingTotalPrice;

            //shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();

            //Console.WriteLine("Ödeyeceğini toplam miktar : " + shoppingTotalPrice + "TL'dir.");
            #endregion

            #region Char Değişkenler



            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");

            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı :");

            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soy Adı :");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir bilgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Yolcu: " + passengerName +" "+ passengerSurname);
            //Console.WriteLine("Şehir^/ İlçe : " + passengerCity + " " + passengerDistrict);
            //Console.WriteLine("Yaş : " + passengerAge);
            //Console.WriteLine("TC Kimlik: " + passengerIdentityNumber);
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu : " + passengerName + " " + passengerSurname + " TC : " + passengerIdentityNumber
            //    + " / " + passengerAge + " / " + passengerCity + " / " + passengerDistrict);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar :" + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalaması : " + result);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.WriteLine("Lütfen cinsiyet seçiniz :");

            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet : " + gender);
            //Console.WriteLine("Seçtiğiniz cinsiyet : " + gender);
            #endregion
            Console.Read();

        }
    }
}
