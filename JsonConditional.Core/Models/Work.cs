using JsonConditional.Core.Models.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace JsonConditional.Core.Models
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(AudioWork), typeof(AudiovisualWork))]
    public abstract class Work : IWork
    {
        [BsonElement]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [BsonElement]
        public string? Title { get; set; }
        [BsonElement]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [BsonElement, BsonIgnoreIfNull]
        public DateTime? ModificationDate { get; set; }
        [BsonElement, BsonIgnoreIfNull]
        public IWork? Father { get; set; }
        [BsonElement]
        public bool IsRatingEnable { get; set; } = true;
        [BsonElement]
        public bool IsLeadFlagEnable { get; set; } = false;
        [BsonElement]
        public bool IsResponseEnable { get; set; } = true;
        [BsonElement]
        public abstract EWorkType Type { get; }

        public Work()
        {
        }

        public Work(string title)
        {
            Title = title;
        }
    }
}
