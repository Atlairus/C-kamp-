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
            #region Double Degiskenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //    Console.WriteLine();

            //double applePrice, strawberryPrice, potatoPrice, tomatoPrice, orangePrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice +" TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice +" TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice+ " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice +" TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");
            //Console.WriteLine();

            //double appleWeight, strawberryWeight, potatoWeight, tomatoWeight, orangeWeight;

            //appleWeight = 1.245;
            //strawberryWeight = 0.750;
            //potatoWeight = 4.859;
            //tomatoWeight = 3.745;
            //orangeWeight = 2.650;

            //double appleTotalPrice = applePrice * appleWeight;
            //double orangeTotalPrice = orangePrice * orangeWeight;
            //double strawberryTotalPrice = strawberryPrice * strawberryWeight;
            //double tomatoTotalPrice = tomatoPrice * tomatoWeight;
            //double potatoTotalPrice = potatoPrice * potatoWeight;

            //Console.WriteLine("Alınan ürün: Elma - " + " Birim fiyat:" + applePrice + " - Gramaj: " + appleWeight + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal - " + " Birim fiyat:" + orangePrice + " - Gramaj: " + orangeWeight + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek - " + " Birim fiyat:" + strawberryPrice + " - Gramaj: " + strawberryWeight + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates - " + " Birim fiyat:" + potatoPrice + " - Gramaj: " + potatoWeight + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates - " + " Birim fiyat:" + tomatoPrice + " - Gramaj: " + tomatoWeight + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");





            #endregion

            #region Char Degiskenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("***** C# Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerAge, passangerCity, passangerID;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passangerID = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC no: " + passangerID + " - Yolcu Bilgisi: " + passangerName +" "+ passangerSurname +" " +passangerAge +" - İkametgah: "+passangerDistrict+"/"+passangerCity);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 10;
            //computerPrice = 200;
            //chairPrice = 50;
            //tvPrice = 120;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız pc sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam ödemeniz gereken tutar: "+ totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Tek Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            #region Personal Tries (calculator)

            double number1, number2, result = 0;
            string symbol; 

            Console.Write("Enter first number: ");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            number2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the symbol of procedure: "); 
            symbol = Console.ReadLine();

            if (symbol == "+") {
                result = number1 + number2;
                Console.WriteLine("Result: " + result);
            }
            else if (symbol == "-") {
                result = number1 - number2;
                Console.WriteLine("Result: " + result);
            }
            else if (symbol == "*") {
                result = number1 * number2;
                Console.WriteLine("Result: " + result);
            }
            else if (symbol == "/") {
                if (number2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by 0");           
                }
                else
                    
                result = number1 / number2;
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("You entered an invalid procedure.");
               
            }      
           

            #endregion

            Console.Read();
        }
    }
}
