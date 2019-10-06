using System.Xml;

namespace ChemiCleanDataLibrary.Models
{
    public class ProductDocumentModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public XmlDocument Document { get; set; }
    }
}
