using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Demir");
            //    Console.WriteLine("Mehmet Kaya");
            //    Console.WriteLine("Merve Çınar");

            //}

            //CustomerList();

            //void Sum()

            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine("Toplam: " + z);
            //}
            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen Paremetreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine("Müşteri Adı: " + customerName);
            //}
            //WriteMethod("Ali Yıldız");

            //void CustomerCard(string Name, string Surname)
            //{
            //    Console.WriteLine("Müşteri :" + Name + " " + Surname);

            //}
            //CustomerCard("Ayşe", "Demir");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum (int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //sum(2, 3, 4);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CostumerName()
            //{
            //    return "Mehmet Kaya";
            //}
            //CostumerName();

            //string StudendCard()
            //{   
            //    string name = "Merve";
            //    string surname = "Çınar";

            //    return name + " " + surname;
            //}
            //Console.WriteLine("Öğrenci Adı Soyadı: " + StudendCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke Adı: " + countryName + " - " + "Başkent: " + capital + " - " +
            //        "Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adı giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent adı giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengi giriniz: ");  
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));


            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " adlı öğrenci sınavdan " + result + " ortalama ile geçti.";
                }
                else
                {
                    return student + " adlı öğrenci sınavdan " + result + " ortalama ile kaldı.";
                }
            }

            Console.WriteLine(ExamResult("Ali ", 25,41,55));
            Console.WriteLine(ExamResult("Ayşe ", 36,88,58));

            #endregion

            Console.Read();  
        }
    }
}
