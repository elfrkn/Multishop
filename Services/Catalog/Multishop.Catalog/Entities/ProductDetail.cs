using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Multishop.Catalog.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public  string ProductDetailID { get; set; }
        public  string ProductDescription { get; set; }
        public  string ProductInfo { get; set; }
    }
}
