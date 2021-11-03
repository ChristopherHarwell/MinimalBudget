using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MinimalBudget.Models
{

    public record ItemPurchased()
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; init; }
        public string Name { get; init; }
        public Decimal Price { get; init; }
        public DateTimeOffset CreatedDate{ get; init; }


    }
}

