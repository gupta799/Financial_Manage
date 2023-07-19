using Financial_Manager.Attributes;
using Financial_Manager.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Financial_Manager.Infrastructure.Models
{
    [BsonCollectionName("UserStockInfo")]
    public class UserStockInfo: Document
    {
        
        
        public string ? stock { get; set; }

        public string? description { get; set;}

    }
}
