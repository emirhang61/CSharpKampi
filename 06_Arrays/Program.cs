using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2.4.6.8
            //sarı,kırmızı,mavi
            //adana,ankara,istanbul,Trabzon

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //string[]cities = new string[5];

            //cities[0]="Milano";
            //cities[1] = "Roma";
            //cities[2] = "Budapeşte"
            //    ;
            //cities[3] = "Moskova";
            //cities[4] = "Los Angeles";

            //Console.WriteLine(cities[1]);

            //int[] numbers = new int[10];

            //numbers[0] = 1;
            //numbers[1] = 2; 
            //numbers[2] = 46;
            //numbers[3] = 555;
            //numbers[4] = 15;
            //    numbers[5] = 13;
            //    numbers[6] = 351;
            //    numbers[7] = 53;
            //    numbers[8] = 61;
            //    numbers[9] = 81;

            //Console.WriteLine(numbers[2]);


            //string[] cities = { "İstanbul", "Moskova", "Pekin", "Bakü"};
            //Console.WriteLine(cities[2]);   



            #endregion

            #region Listedeki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i=0; i<colors.Length; i++)

            //{
            //    Console.WriteLine(colors[i]);

            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] %3 ==0 ) 

            //}

            //int[] myArray = { 47, 55, 95, 635, 786, 100 };
            //int maxNumber = myArray[0];

            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }


            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "emirhan", "ayşe", "cem", "deniz" };
            //  Console.WriteLine(persons.Length);     

            //int[] number = { 45, 67, 61, 34, 43, 86, 07 };
            //Array.Sort(number);
            //for(int i= 0; i< number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //int[] number = { 45, 67, 61, 34, 43, 86, 07 };
            //Array.Reverse(number);
            //for(int i = 0; i<number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}




            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse", "zeynep", "çınar", "emir", "kaya" };
            //int index = Array.IndexOf(customers, "emir");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 67, 61, 34, 43, 86, 07 };
            //Console.WriteLine("Dizinin En Büyük Elamanı: " + numbers.Max());
            //Console.WriteLine();
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());


            #endregion

            #region Kullanıcılardan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)

            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");

            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}   

            //int[] numbers = {21, 42, 33, 54, 55, 66, 897, 748, 39, 220};
            //Console.WriteLine("Çift Sayılar: ");
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Tek Sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }  }

