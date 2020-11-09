using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Api_Project.Models
{
    public class Games
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Distributor { get; set; }
        public DateTime Release { get; set; }
    }
}
