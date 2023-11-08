using MongoDB.Bson.Serialization.Attributes;

namespace JsonConditional.Core.Models
{
    public abstract class AudiovisualWork : Work
    {
        [BsonElement, BsonIgnoreIfNull]
        public TimeSpan? Duration { get; set; }

        public AudiovisualWork()
        {
        }

        public AudiovisualWork(string title) : base(title)
        {
        }

        public AudiovisualWork(string title, TimeSpan duration) : this(title)
        {
            Duration = duration;
        }
    }
}
