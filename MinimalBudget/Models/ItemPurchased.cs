using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MinimalBudget.Models
{

    public record AddItemPurchased()
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; init; }
        public string Name { get; init; }
        public Decimal Price { get; init; }
        public DateTimeOffset CreatedDate{ get; init; }


    }
}

