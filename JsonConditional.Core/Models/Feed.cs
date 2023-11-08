using MongoDB.Bson.Serialization.Attributes;

namespace JsonConditional.Core.Models
{
    public class Feed
    {
        [BsonElement]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [BsonElement]
        public string? Name { get; set; }
        [BsonElement]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [BsonElement, BsonIgnoreIfNull]
        public DateTime? DeletionDate { get; set; }
        [BsonElement, BsonIgnoreIfNull]
        public DateTime? ModificationDate { get; set; }

        [BsonElement]
        public bool HideReadMessages { get; set; } = false;
        [BsonElement, BsonIgnoreIfNull]
        public DateTime? CutDate { get; set; }

        public Feed()
        {
        }

        public Feed(string name)
        {
            Name = name;
        }
    }
}
