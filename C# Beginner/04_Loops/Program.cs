using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // For (x;y;z)
            //x: başlangıç
            //y: bitiş
            //z: artış azalış

            //int i; 

            //for (i = 1; i<= 5; i++)
            //{
            //    Console.WriteLine("C# eğitim");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i<=50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine(i+ "." +" Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile karar yapıları 

            // 0-100 arası 5e tam bölünen sayıları veriyor
            //for (int i = 5; i <=100; i++)
            //{
            //    if (i% 5 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }         
            //}


            //1-10 arası sayıların toplamını veriyor
            //int totalValue = 0;

            //for (int i = 1; i<= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);
            //#endregion

            //1-20 arası çift sayıların toplamını veren döngü

            //int totalValue = 0;

            //Console.WriteLine("1-20 arasında, 2'ye tam bölünen sayılar:");
            //Console.WriteLine("------"); 
            //for (int i= 1; i<= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i; //durum sağlanıyorsa totalValue üzerine i yi ekle.

            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            //1-50 arası 7ye tam bölünen sayılar döngüsü
            //Console.WriteLine("1-50 arası 7ye tam bölünen sayılar:");
            //Console.WriteLine("------------------------------------");

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 ==0 )
            //    {
            //        count ++;
            //        Console.WriteLine(count + ". sayı: " +i);
            //    }
            //}
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("7'ye bölünenlerin sayısı: " + count);


            //bir bakteri türü 1 saatin sonunda kendini ikiye bölerek çoğaltmaktadır. 24 saat sonunda bakteri sayısı kaçtır?

            //int bakteri = 1;
            //for (int time = 1; time <= 24; time++)
            //{
            //    bakteri *= 2; //bakteri sayısı 2 ile çarpılıyor her döngüde
            //    Console.WriteLine( time + ". saat sonunda: " + bakteri);
            //}
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Toplam bakteri sayısı: " + bakteri);

            #endregion

            #region While Döngüsü

            //While (şart) 
            //{
            //  işlemler
            //}

            //int i = 1 ;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i + ". Merhaba döngüler");
            //    i++;
            //}

            //1-10 arası 3e bölünen sayılar
            //int i = 1;
            //while ( i <= 10)
            //{
            //    if (i %3 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++; 
            //}

            //1-10 arası sayıların toplamı
            //int i = 1;
            //int totalValue = 0;

            //while (i <=10)
            //{
            //    totalValue += i;
            //    i++;
            //}

            //Console.WriteLine(totalValue);


            #endregion

            #region Örnek soru

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            Console.Write("Sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds, sum;

            ones = number % 10;
            hundreds = number / 100;
            tens = (number % 100) / 10;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sayının yüzler basamağı: " + hundreds);
            Console.WriteLine("Sayının onlar basamağı: " + tens);
            Console.WriteLine("Sayının birler basamağı: " + ones);
            Console.WriteLine("Toplanacak değerler: " + hundreds + "-" + tens + "-" + ones);
            Console.WriteLine("-----------------------------");
            sum = ones + tens + hundreds;
            Console.WriteLine("Toplam Sonuç: " + sum);

            #endregion

            Console.Read();
        }
    }
}
