using System;
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

            //    double number;

            //    number = 4.85;

            //    Console.WriteLine(number);



            //Console.WriteLine("****** Fiyat Listesi *****");
            //Console.WriteLine();


            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Fiyatı : " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.651;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine();


            //double appleToralPrice = applePrice * appleGram;    
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //Console.WriteLine();
            //Console.WriteLine("****** Alınan Ürünler *****");
            //Console.WriteLine();


            //Console.WriteLine(" Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj " + appleGram + " - Toplam Tutar: " + appleToralPrice);
            //Console.WriteLine(" Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine(" Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine(" Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine(" Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleToralPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine(" Alışveriş Toplam Tutarı : " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişi

            //Console.WriteLine("**** CSharp Havayolları Yolcu Bilgisi ****");

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("TC Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passangerIdentityNumber + " - Yolcu Adı Soyad:  " + passangerName + " " + passangerSurname + " " + passangerDistrict + " / " + passangerCity + " " + passangerAge + " ");




            #endregion

            #region Klavyeden Tam Sayı Girişi ve Dönüşümler 

            ////ABC12D 

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı Girişi ve Dönüşümler

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Sınav Not Ortalamanız: " + result);



            #endregion

            #region Klavyeden Karakter Girişi 

            //char gander;
            //Console.Write("Lütfen Cinsiyet Bilginizi Giriniz (E/K): ");
            //gander = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gander);



            #endregion

            Console.Read();
        }
    }
}
