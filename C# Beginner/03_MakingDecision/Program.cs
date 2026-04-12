using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //ÖRNEK 1
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış.");
            //}

            //ÖRNEK 2
            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız.");
            //}


            // ÖRNEK 3
            //double exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3 ;
            //Console.WriteLine("Ortalamanız: " + average);

            //if (average <= 50)
            //{
            //    result = "Sonuç vasat.";

            //}

            //else if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta.";
            //}

            //else if (average > 70 & average <=84 )
            //{
            //    result = "Sonuç iyi.";
            //}
            //else if (average > 85)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //ÖRNEK 4    | işareti veya demek, & işareti ve demek

            //string city;

            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa") {

            //    Console.WriteLine("Şehir mevcut"); }
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //ÖRNEK 5 != eşit değil demek
            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı kabul edilemez ");
            //}
            //else
            //{
            //    Console.WriteLine("hoşgeldiniz");

            //}
            #endregion

            #region Mod İşlemleri

            //örnek 1
            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan: " + result);


            //örnek 2
            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Degiskenler ile Karar Yapıları
            //örnek 3
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if ( team =='g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray.");
            //}
            //if (team =='f' | team =='F')
            //{
            //    Console.WriteLine("Fenerbahçe.");
            //}
            //if (team == 'b' | team =='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje (menü)

            //Console.WriteLine("***** C# Kampı Menü *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.WriteLine("Lütfen detayını görmek istediğiniz menüyü seçin.");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Körü Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorba");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Pepperoni Pizza");
            //    Console.WriteLine("2- Kebap Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");               
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Su");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kazandibi");
            //    Console.WriteLine("2- Çikolatalı Pasta");
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");


            //}



            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());


            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break; 
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            double number1, number2, result;
            char symbol;

            Console.Write("Birinci sayıyı giriniz: ");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            number2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+': 
                    result = number1 + number2;
                    Console.WriteLine("Sayıların Toplamı: "+ result); break;

                case '-': 
                    result = number1 - number2;
                    Console.WriteLine("Sayıların Eksilimi: " + result); break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Sayıların Çarpımı: " + result); break;

                case '/': 
                    result = number1 / number2;
                    Console.WriteLine("Sayıların Bölümü: " + result); break;

                default: Console.WriteLine("Hatalı işlem girdiniz."); break;
            }   

            #endregion

            Console.ReadLine();
        }
    }
}
