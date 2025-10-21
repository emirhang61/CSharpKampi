using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //1; Değişken türü
            //2; Değişken adı
            //3; In
            //4; Liste ,Koleksiyon, Dizi adı

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 }; 

            //foreach(int number in numbers)            
            //    {
            //        Console.WriteLine(number);
            //    }
            //    

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach(int number in numbers)
            //    {
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine("Çift Sayı: " + number);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tek Sayı: " + number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //    foreach(char c in word)
            //    {
            //        Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma

            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var?: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------"); 
           

            //Öğrenci İsimlerini ve Sınav Notlarını Tutmak İçin Diziler 
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i=0 ; i<studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: "); //•	$ — süslü parantez içindeki ifadeyi değerlendirip string içine yerleştirir.
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                //Her Öğrenci İçin 3 Sınav Notu Alma

                for (int j=0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}. Sınav Notunu Giriniz: ");
                    double value= double.Parse(Console.ReadLine());
                    totalExamResult += value;//notlar toplanır.

                }
                studentExamAvg[i] = totalExamResult / 3; //ortalama hesaplanır.  
            }

            Console.WriteLine();

            //Öğrencilerin ortalması ve geçip kalma durumları
            for (int i =0; i<studentCount; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencinin geçip kalma durumu

                if(studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]}Adlı öğrenci geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]}Adlı öğrenci kaldı");
                }

                Console.WriteLine("---------------------------------");
            }




            #endregion

            Console.Read();
        }
    }
}
