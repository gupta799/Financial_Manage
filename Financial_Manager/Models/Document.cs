using Financial_Manager.Interfaces;
using MongoDB.Bson;

namespace Financial_Manager.Models
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
