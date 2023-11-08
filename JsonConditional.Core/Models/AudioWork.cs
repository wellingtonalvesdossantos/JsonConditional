using JsonConditional.Core.Models.Audio;
using MongoDB.Bson.Serialization.Attributes;

namespace JsonConditional.Core.Models
{
    [BsonKnownTypes(typeof(Music), typeof(Podcast))]
    public abstract class AudioWork : Work
    {
        [BsonElement, BsonIgnoreIfNull]
        public TimeSpan? Duration { get; set; }

        public AudioWork()
        {
        }

        public AudioWork(string title) : base(title)
        {
        }

        public AudioWork(string title, TimeSpan duration) : base(title)
        {
            Duration = duration;
        }
    }
}
