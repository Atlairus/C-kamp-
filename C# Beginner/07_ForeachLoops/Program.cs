using System;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizilerde Foreach Dönügüsü

            //Foreach (1;2;3;4)
            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            // foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //İkiye tam bölünen (çift) sayıları yazdırmak
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int i in numbers)
            //{
            //    if (i % 2 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //dizi içindeki tüm sayıları toplamak
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //kelimeyi harflerine ayıran kod 
            //string word = "Merhaba";

            //foreach (char i in word) //word ismindeki değişkenin her bir parçasını char şeklinde "i" değişkenine atar ve yazdırır
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Listelerde Foreach Döngüsü

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------");

            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;

            //    //her öğrenci için 3 sınav notu girişi
            //    for (int j=0; j< 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz
            //    }
            //    Console.WriteLine() ;
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //Console.WriteLine("-------------------------------");

            ////sınav ortalamaları
            //for (int i=0;i<studentCount;i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinini ortalaması: {studentExamAvg[i]}");
            //    Console.WriteLine("-------------------------------");
            //}


            ////öğrencilerin geçip kalma durumları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-------------------------------");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("-------------------------------");
            //}

            #endregion

            #region Örnekler 2

            //1- 5 elemanlı bir int dizisi oluşturun ve içine 10, 20, 30, 40, 50 değerlerini atayın
            //Dizideki tüm elemanları foreach döngüsü ile ekrana yazdırın.

            //int[] numbers = { 10, 20, 30, 40, 50 };
            // foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //2- Kullanıcıdan 5 tane sayı girmesini isteyin ve bu sayıları bir diziye kaydedin.
            //Daha sonra dizideki en büyük ve en küçük sayıyı bulup ekrana yazdırın.

            //int[] numbers = new int[5];

            //int maxNumber = int.MinValue;   // Başlangıç için en küçük mümkün değer
            //int minNumber = int.MaxValue;   // Başlangıç için en büyük mümkün değer

            //// Kullanıcıdan 5 sayıyı al
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"{i + 1}. sayıyı giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\n----- Dizi içindeki sayılar -----");
            //foreach (int sayi in numbers)
            //{
            //    Console.Write(sayi + ", ");
            //}

            //// Tek bir döngü ile hem max hem min bulalım
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }

            //    if (numbers[i] < minNumber)
            //    {
            //        minNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine("\n---------------------------------"); //\n burada bir satır alta geçmek için var
            //Console.WriteLine("En büyük sayı: " + maxNumber);
            //Console.WriteLine("En küçük sayı: " + minNumber);

            //3- Kullanıcıdan 10 tane sayı alın ve bir diziye kaydedin.
            //*Dizideki pozitif sayıların sayısını,
            //*Negatif sayıların sayısını,
            //*Sıfırların sayısını ayrı ayrı bulup ekrana yazdırın.

            //10 tane sayı aldığımız ve dizine eklediğimiz kod
            //int[] numbers = new int[10];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{i + 1}. sayıyı giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            ////sayılar pozitif mi, negatif mi, yoksa sıfır mı kontrolü gerçekleşen kod
            //int poztf = 0, negatf = 0, sifir = 0;
            //foreach (int number in numbers)
            //{
            //    if (number > 0)
            //    {
            //        poztf = poztf + 1;
            //    }
            //    else if (number < 0)
            //    {
            //        negatf = negatf + 1;
            //    }
            //    else if (number == 0)
            //    {
            //        sifir = sifir + 1;
            //    }
            //}
            //Console.WriteLine("Girdiğiniz sayılardan " + poztf + " tanesi pozitif sayıdır.");
            //Console.WriteLine("Girdiğiniz sayılardan " + negatf + " tanesi negatif sayıdır.");
            //Console.WriteLine("Girdiğiniz sayılardan " + sifir + " tanesi sıfırdır.");

            //4- Bir string dizisi oluşturun ve içine 8 tane öğrenci adı yazın.
            //Kullanıcıdan bir harf girmesini isteyin. Bu harfle başlayan öğrenci isimlerini ekrana yazdırın.
            //(Büyük / küçük harf duyarlı olmasın)

            //string[] studentNames = new string[8];
            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //}
            //Console.Write("Bir harf giriniz: ");
            //string harf = Console.ReadLine();
            //Console.WriteLine("---- Bulunan öğrenciler -----");
            //foreach (string isim in studentNames)
            //{
            //    //ismin ilk harfini alıyor
            //    char ilkHarf = isim[0];

            //    if (ilkHarf == harf[0])
            //    {
            //        Console.WriteLine(isim);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
