using System;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı] 

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[2]); (beyaz ı vericek)


            //string[] cities = new string[5];
            //cities[0] = "istanbul";
            //cities[1] = "ankara";
            //cities[2] = "antalya";
            //cities[3] = "izmir";
            //cities[4] = "bursa";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 45;
            //numbers[4] = 8;
            //numbers[6] = 96;
            //numbers[7] = 13;
            //numbers[9] = 79;

            //Console.WriteLine(numbers[6]);


            //string[] countries = { "greece", "germany", "türkiye", "sweden", "italy" };
            //Console.WriteLine(countries[3]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i <= colors.Length ; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0;  i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            #endregion

            #region Örnekler

            //dizideki en büyük sayı
            //int[] myArray = { 10, 65, 23, 49, 756, 842, 165, 32, 94 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //dizideki çift sayılar
            //int[] secondArray = { 15, 36, 86, 95, 41, 52, 72, 100 };
            //for (int i = 0; i < secondArray.Length; i++)
            //{
            //    if (secondArray[i] % 2 == 0)
            //    {
            //        Console.WriteLine(secondArray[i]);
            //    }
            //}

            //dizideki en küçük sayı
            //int[] numbers = { 54, 85, 945, 32, 123, 658, 9547, 854, 69654, 3, 1 };
            //int minNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < minNumber)
            //    {
            //        minNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(minNumber);

            #endregion

            #region Dizi Metotları

            //Length: dizinin uzunluğunu verir
            //string[] persons = { "ayşe", "buse", "ali", "cenk", "mehmet", "deniz" };
            //Console.WriteLine(persons.Length);

            //Sort: metodundan dolayı küçükten büyüğe sıraladı
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Reverse: metodundan dolayı sondan başa doğru sıraladı
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //istenen dizi üyesinin kaçıncı sırada olduğunu veriyor
            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //min ve max metotları
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizini En Büyük Elemanı; " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //girileni ekrana yazdırma ve $ {} kullanımı
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //dizi içindekileri toplama
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //     sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //dizi içindeki sayıları tek ve çift olarak ayırma
            //int[] numbers = { 85, 44, 953, 256, 845, 7412, 36, 985, 159 };
            //Console.WriteLine("Çift sayılar:");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar:");

            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            #region Örnek sorular

            //Kullanıcıdan 8 tane sayı alınsın ve bir diziye kaydedilsin.
            //Dizideki çift sayıların ortalamasını ve tek sayıların ortalamasını ayrı ayrı hesapla ve ekrana yazdır.
            //(Eğer tek veya çift sayı yoksa o ortalama için “Hiç tek/çift sayı yok” mesajı versin.)

            //int[] numbers = new int[8];
            //int evenTotal = 0, oddTotal = 0;
            //int oddCount = 0, evenCount = 0; // İsimleri karışıklık olmasın diye Count yaptık

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{i + 1}. sayıyı giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evenTotal += number;
            //        evenCount++;
            //    }
            //    else
            //    {
            //        oddTotal += number;
            //        oddCount++;
            //    }
            //}
            //Console.WriteLine("------------------------------");
            //// Çift sayıların kontrolü ve ortalaması
            //if (evenCount > 0)
            //{
            //    // (double) yazarak sonucun küsuratlı çıkmasını sağlıyoruz
            //    double evenAverage = (double)evenTotal / evenCount;
            //    Console.WriteLine($"Çift sayıların ortalaması: {evenAverage}");
            //}
            //else
            //{
            //    Console.WriteLine("Hiç çift sayı yok.");
            //}
            //// Tek sayıların kontrolü ve ortalaması
            //if (oddCount > 0)
            //{
            //    double oddAverage = (double)oddTotal / oddCount;
            //    Console.WriteLine($"Tek sayıların ortalaması: {oddAverage}");
            //}
            //else
            //{
            //    Console.WriteLine("Hiç tek sayı yok.");
            //}

            //Kullanıcıdan 10 tane kelime alınsın(string dizi).
            //Dizideki kelimeleri alfabetik sıraya göre sıralayıp ekrana yazdır.
            //Ayrıca en kısa ve en uzun kelimeyi de belirt.

            //string[] words = new string[10];
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write($"{i + 1}. Kelimeyi giriniz: ");
            //    words[i] = Console.ReadLine();
            //}
            //Console.WriteLine("--- Girilen Kelimeler (alfabetik) ---");
            //Array.Sort(words);
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //string wordLongest = words[0];
            //string wordShortest = words[0];
            //foreach (string word in words)
            //{
            //    if (word.Length > wordLongest.Length)
            //    {
            //        wordLongest = word;
            //    }
            //    if (word.Length < wordShortest.Length)
            //    {
            //        wordShortest = word;
            //    }
            //}
            //Console.WriteLine("En kısa kelime (" + wordShortest.Length + " harf) " + wordShortest);
            //Console.WriteLine("En uzun kelime (" + wordLongest.Length + " harf) " + wordLongest);


            #endregion

            Console.Read();

        }
    }
}
