using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yıldız oluşturma, her satırda da 10 yıldız

            //for (int i = 1; i <= 10; i++)
            //{             
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Yıldızlarla Dik Üçgen

            //for (int i =1; i<= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Yıldızlarla Ters Dik Üçgen 

            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region  Yıldızlarla Yarım Elmas (Dik ve Ters Üçgen beraber)

            //for (int a = 1; a <= 5; a++)
            //{
            //    for (int b = 1; b <= a; b++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int c = 4; c>= 1; c--)
            //{
            //    for(int d = 1; d<= c; d++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yarım Baklava Dilimi

            ////üst taraf

            //int n = 5;
            //for (int i = 1; i <=n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //} 

            ////alt taraf

            //for (int i =n -1; i>= 1; i--)
            //{
            //    for ( int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for ( int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5; 

            //for (int i = 1; i <=n; i++)
            //{
            //    //boşluklar için

            //    for (int j = n - i; j> 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar için
            //    for (int k = 1; k <= 2*i - 1 ; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;

            //for (int i = n; i >= 1; i--) 
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for ( int k= 1; k <= 2* i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region



            #endregion

            Console.Read();
        }
    }
}
