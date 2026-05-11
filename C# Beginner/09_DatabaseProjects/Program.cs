using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProjecets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net ( C# dilinde SQL yapılarını kullanmamıza olanak sağlıyor )
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            string TableNumber;
            TableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------");

            //bağlantıyı kurdugumuz kod
            SqlConnection connection = new SqlConnection("Data Source =DESKTOP-8HREKFC\\SQLEXPRESS;initial Catalog=C#EgitimDb;integrated security=true");
            connection.Open(); //bağlantıyı açtığımız kod
            //komudu istediğimiz kod
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //c# kodları ve sql arasındaki köprü
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
