using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lürfen şifereyi giriniz: ");
            //string password;
            //password = Console.ReadLine();  
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");

            //}
            //else 

            //          {
            //    Console.WriteLine("Şifre yanlış");
            //}   

            //string capital, country;
            //Console.Write("Lütfen bir başkent ismi giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Lütfen bir ülke ismi giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="İstanbul" & country == "Türkiye") 

            //    {
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());   
            //if (number == 5)

            //{                 Console.WriteLine("Sayı doğru");
            //}           
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //double exam1, exam2, exam3, average;
            //string result= "hata!";

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average= (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız: " + average);

            //if (average > 0 & average <= 50)
            //{ 
            //    result = "Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "İyi";
            //}
            //if (average > 70 & average <= 100)
            //{
            //    result = "Afferin sanaa";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen bir şehir ismi giriniz: ");
            //city = Console.ReadLine();

            //if(city=="istanbul" | city=="Ankara" | city=="Bursa" | city== "Trabzon")
            //    {
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            // string username = Console.ReadLine();

            // if(username == "admin")
            // {
            //     Console.Write("Lütfen şifrenizi giriniz: ");
            //     string password = Console.ReadLine();
            //     if (password == "1234")
            //     {
            //         Console.WriteLine("Giriş başarılı.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Şifre yanlış.");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Kullanıcı adı yanlış.");
            // }




            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine()); 

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("İki sayının mod işlemi sonucu: " + result);


            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen bir takım ismi giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='F' | team=='f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'T' | team == 't')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir takım yok.");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restorantı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("-------------------------");

            //string menuItem;

            //Console.WriteLine("Lütfen detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //                    { Console.WriteLine();
            //                    Console.WriteLine("-------Ana Yemekler-------");
            //                    Console.WriteLine();
            //                    Console.WriteLine("1-Köri Soslu Tavuk");
            //                    Console.WriteLine("2-Kızartma Tava");
            //                    Console.WriteLine("3-Fasulye Pilav");
            //                    Console.WriteLine("4-Fırında Somon");
            //                    Console.WriteLine("5-Patlıcan Musakka");
            //                    Console.WriteLine("-------Ana Yemekler-------");

            //                }

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Çorbalar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mecimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("-------Çorbalar-------");
            //    Console.WriteLine();
            //}                        

            //if (menuItem == "3")
            //{

            //    Console.WriteLine("-------Pizzalar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margeritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-------Pizzalar-------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{

            //    Console.WriteLine("-------İçecekler-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-------İçecekler-------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{

            //    Console.WriteLine("-------Tatlılar-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");

            //    Console.WriteLine("-------Tatlılar-------");
            //    Console.WriteLine();
            //}


            #endregion

            #region Swict Case

            //Console.Write("Lütfen bir ay girişi yapınız: ");
            //int monterNumber=int.Parse(Console.ReadLine());


            //switch (monterNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız.");
            //        break;
            //}



            #endregion

            #region Switch Case Hesap Makinesi 

            //int number1, number2, result;

            //char symbol;
            //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz (+, -, *, /): ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuç: " + result);
            //        break;
            //    case '/':
            //        if (number2 != 0)
            //        {
            //            result = number1 / number2;
            //            Console.WriteLine("Sonuç: " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bir sayı sıfıra bölünemez.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı işlem simgesi girdiniz.");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
