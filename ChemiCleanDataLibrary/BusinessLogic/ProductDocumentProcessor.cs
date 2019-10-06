using ChemiCleanDataLibrary.DataAccess;
using ChemiCleanDataLibrary.Models;
using System.Collections.Generic;
using System.Xml;

namespace ChemiCleanDataLibrary.BusinessLogic
{
    class ProductDocumentProcessor
    {
        public static int CreateProduct
            (int id, int productId, XmlDocument document)
        {
            ProductDocumentModel productdocument = new ProductDocumentModel
            {
                Id = id,
                ProductId = productId,
                Document = document
            };

            string sql = @"insert into dbo.ProductDocument (Id, ProductId, Document)
                            values (@Id, @ProductId, @Document);";

            return SQLDataAccess.SaveData(sql, productdocument);
        }

        public static List<ProductDocumentModel> LoadProducts()
        {
            string sql = @"select Id, ProductId, Document from dbo.ProductDocument;";

            return SQLDataAccess.LoadData<ProductDocumentModel>(sql);
        }
    }
}
