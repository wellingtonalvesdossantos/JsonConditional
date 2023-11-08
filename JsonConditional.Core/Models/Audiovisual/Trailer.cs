using JsonConditional.Core.Models.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace JsonConditional.Core.Models.Audiovisual
{
    [BsonKnownTypes(typeof(Trailer))]
    public class Trailer : AudiovisualWork
    {
        public override EWorkType Type => EWorkType.Trailer;

        public Trailer()
        {
        }

        public Trailer(string title) : base(title)
        {
        }

        public Trailer(string title, TimeSpan duration) : base(title, duration)
        {
        }
    }
}
