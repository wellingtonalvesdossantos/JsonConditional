using JsonConditional.Core.Models.Enums;

namespace JsonConditional.Core.Models.Audio
{
    public class Music : AudioWork
    {
        public override EWorkType Type => EWorkType.Music;
     
        public Music()
        {
        }

        public Music(string title) : base(title)
        {
        }

        public Music(string title, TimeSpan duration) : base(title, duration)
        {
        }

    }
}
