using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //() - Bir yapıyı metot yapan şey sonunda mutlaka parantez açılıp kapanmalı, ve mouse üzerindeyken sol tarafında mor renkte bir küp vardır 
            // - Geriye değer döndürmeyen metotlar; Void
            // Customer ---> Listele, ekle, sil, güncelle

            //örnek 1
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList(); //customerlist i çağıracak, bu olmadan yukarıdaki kod bize bir şey getirmez.

            //örnek 2
            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard (string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Atlas", "Arslan");
            //CustomerCard("Astrid", "Brand");



            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName(); //ekrana yazdırmadık, buse yıldız sadece değer olarak döndü

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string CountryName, string capital, string flagColor)
            //{
            //    string CountryInfo = "Ülke: " + CountryName + " | Başkent: " + capital + " | Bayrak Rengi: " + flagColor;
            //    return CountryInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke ismini giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent ismini giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z)); //bilgileri biz girdik
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı ve Beyaz")); //birden fazla veriyi de bu şekilde verebiliyor


            #endregion

            #region  #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(15,96));
            //Console.WriteLine(Sum(65,6));
            //Console.WriteLine(Sum(18,32));
            //Console.WriteLine(Sum(74,1));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti." + " Ortama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavdan kaldı." + " Ortama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Atlas Arslan", 33, 59, 36));
            //Console.WriteLine(ExamResult("Astrid Brand", 90, 76, 100));

            #endregion

            Console.Read();
        }
    }
}
