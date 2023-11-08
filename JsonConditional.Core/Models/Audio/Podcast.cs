using JsonConditional.Core.Models.Enums;

namespace JsonConditional.Core.Models.Audio
{
    public class Podcast : AudioWork
    {
        public override EWorkType Type => EWorkType.Podcast;

        public Podcast()
        {
        }

        public Podcast(string title) : base(title)
        {
        }

        public Podcast(string title, TimeSpan duration) : base(title, duration)
        {
        }
    }
}
