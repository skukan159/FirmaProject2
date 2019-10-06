using ChemiCleanDataLibrary.DataAccess;
using ChemiCleanDataLibrary.Models;
using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string sql = @"select Id, ProductName, SupplierName, URL, Username, Password from dbo.tblProduct;";
            Console.WriteLine("Hello");
            string connString = @"Data Source = DESKTOP - 6II6HH2\MSSQLSERVER01; Initial Catalog = ChemiCleanDB; Integrated Security = True; Connect Timeout = 60; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string connString2 = @"Data Source =localhost; Initial Catalog = ChemiCleanDB; Integrated Security = True; Connect Timeout = 60; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";


            List<ProductModel> data = SQLDataAccess.TestLoadData<ProductModel>(sql, connString2);

            Console.WriteLine("Hello");

            Console.ReadLine();
        }
    }
}
