﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Financial_Manager.Interfaces
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }


    }
}
