using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace HW6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbTest = new Dbtest();
            Console.WriteLine("connect");
            dbTest.connect();
            Console.WriteLine("insert data");
            dbTest.insertData("11-21-31", "company1", 100);
            dbTest.insertData("12-22-32", "company2", 200);
            dbTest.insertData("13-23-33", "company3", 300);
            dbTest.insertData("14-24-34", "company4", 340);
            Console.WriteLine("select data");
            dbTest.selectAndPrint();
            Console.WriteLine("wipe data");
            dbTest.wipeData();
            Console.ReadKey();
        }

    }
    class Dbtest
    {
        SqlConnection _connection;

        public void connect()
        {
/*
            string connectionString = @"Data Source=USER-PC\MSSQL2019; 
                Initial Catalog = Test;
                User Id=sa; Password=sql;
                ";
*/
            string connectionString = ConfigurationManager.ConnectionStrings["testDB"].ConnectionString;

            _connection = new SqlConnection(connectionString);
 
            _connection.Open();
        }

        public void insertData(string title, string company, double price)
        {
            string sql = $"insert into phones(title, company, price) values ('{title}', '{company}', {price})";
            SqlCommand command = new SqlCommand(sql, _connection);
            var rowsAffected = command.ExecuteNonQuery();
        }

        public void selectAndPrint()
        {
            string sql = "select * from Phones";
            SqlCommand command = new SqlCommand(sql, _connection);
            SqlDataReader sqlReader = command.ExecuteReader();
            Console.WriteLine($"Title \tCompany \tPrice");
            Console.WriteLine("====================================");

            while (sqlReader.Read())
            {
                Console.WriteLine($"{sqlReader["Title"]} \t{sqlReader["Company"]} \t{sqlReader["Price"]}");
            }
            sqlReader.Close();
        }
        public void wipeData()
        {
            string sql = $"delete from phones";
            SqlCommand command = new SqlCommand(sql, _connection);
            var rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"deleted records count:{rowsAffected}");
        }
    }

}
