using System;
using System.Data;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create, Read, Update, Delete

            Console.WriteLine("***** Menü Sayfası İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            ////sql ile bağlantı kurduk
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8HREKFC\\SQLEXPRESS; initial catalog=C#EgitimDb; integrated security=true");
            //connection.Open();
            ////string değişkenini sql tablosuna ekleme kodunu yazdık
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); //seçilen tablo bağlantıdaki veri tabanıyla çalıştığı için sonda connection dedik
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8HREKFC\\SQLEXPRESS; initial catalog=C#EgitimDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            ////Değişiklikleri kaydet ve bunu veri tabanına yazdır demek için bu kodu yazıyoruz
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-8HREKFC\\SQLEXPRESS;initial Catalog=C#EgitimDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //bizim için sql verilerini c# a çekecek olan köprümüz
            //DataTable dataTable = new DataTable(); //geçici verileri hafızaya almak için kullandığımız sınıf
            //adapter.Fill(dataTable); // adapter ın içini datatable dan gelen verilerle dolduracak
            ////buranın öncesinde veriler alındı ve hazır şekilde bellekte bekliyor, şimdi verileri yazdırmamız gerek ve bunun kodunu da aşağıda yazacağız

            ////datarow türünde değişken atadık, ve datatable ın her bir row unu tek tek okumamız lazım bu yüzden tüm satırı bir anda yazdırmak yerine, satır
            ////içindeki bilgileri de almak için döngü içerisine başka bir döngü koyacağız
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-8HREKFC\\SQLEXPRESS;initial Catalog=C#EgitimDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürün id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-8HREKFC\\SQLEXPRESS;initial Catalog=C#EgitimDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı.");

            #endregion

            Console.Read();


        }
    }
}
