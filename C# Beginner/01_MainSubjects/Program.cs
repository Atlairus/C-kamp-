using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları 
            //Console.WriteLine("Hello World"); 
            //Console.Write("Test for next");

            //Console.WriteLine("*****Yemek Kategorileri * ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar;");
            //Console.WriteLine("2-Ana Yemekler;");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Soğuk Başlangıçlar;");
            //Console.WriteLine("5-Tatlılar;");
            //Console.WriteLine("6-İçecekler;");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorileri * ****");
            #endregion

            #region StringDeğişkenler

            //String name;
            //name = "Mustard";
            //Console.WriteLine(name);

            //string customerName, customerSurname, phone, district, city;
            //customerName = "Atlas";
            //customerSurname = "Arslan";
            //phone = "+90 852 852 85 85";
            //district = "Beylikdüzü";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezarvasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri Adı:" + " " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + " " +  phone);
            //Console.WriteLine("İkametgah:" + " " + district + ", " + city);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();

            //customerName = "Astrid";
            //customerSurname = "Brand";
            //phone = "+90 400 200 03 03";
            //district = "Brakne-Hoby";
            //city = "İsveç";
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri Adı:" + " " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + " " + phone);
            //Console.WriteLine("İkametgah:" + " " + district + ", " + city);
            //Console.WriteLine("---------------------------");

            #endregion

            #region IntDeğişkenler

            int number = 31;
            Console.WriteLine(number);

            int priceBurger = 300;
            int priceCoke = 50;
            int priceWater = 20;
            int priceFries = 80;
            int pricePizza = 350;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("--Hamburger: " + priceBurger);
            Console.WriteLine("--Kola: " + priceCoke);
            Console.WriteLine("--Su: " + priceWater);
            Console.WriteLine("--Pizza: " + pricePizza);
            Console.WriteLine("--Kızartmalar: " + priceFries);
            Console.WriteLine();

            int burgerCount = 5;
            int cokeCount = 2;
            int waterCount = 9;
            int pizzaCount = 0;
            int friesCount = 1;

            int totalBurger = burgerCount * priceBurger;
            int totalCoke = cokeCount * priceCoke;
            int totalWater = waterCount * priceWater;
            int totalPizza = pizzaCount * pricePizza;
            int totalFries = friesCount * priceFries;

            Console.WriteLine("Burger Fiyat; " + totalBurger);
            Console.WriteLine("Kola Fiyat; " + totalCoke);
            Console.WriteLine("Su Fiyat; " + totalWater);
            Console.WriteLine("Pizza Fiyat; " + totalPizza);
            Console.WriteLine("Kızartmalar Fiyat; " + totalFries);
            Console.WriteLine();

            int totalPrice = totalBurger + totalCoke + totalWater + totalPizza + totalFries;

            Console.WriteLine(totalPrice);

            #endregion

            Console.Read();
        }
    }
}
