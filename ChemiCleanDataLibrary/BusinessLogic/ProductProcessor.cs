using ChemiCleanDataLibrary.DataAccess;
using ChemiCleanDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChemiCleanDataLibrary.BusinessLogic
{
    public static class ProductProcessor
    {
        public static int CreateProduct
            (int id, string productName,string supplierName,
            string url,string username, string password)
        {
            ProductModel product = new ProductModel
            {
                Id = id,
                ProductName = productName,
                SupplierName = supplierName,
                URL = url,
                Username = username,
                Password = password
            };

            string sql = @"insert into dbo.tblProduct (Id, ProductName, SupplierName, URL, Username, Password)
                            values (@Id, @ProductName, @SupplierName, @URL, @Username, @Password);";

            return SQLDataAccess.SaveData(sql, product);
        }

        public static List<ProductModel> LoadProducts()
        {
            string sql = @"select Id, ProductName, SupplierName, URL, Username, Password from dbo.tblProduct;";

            return SQLDataAccess.LoadData<ProductModel>(sql);
        }

    }
}
