using JsonConditional.Core.Models.Enums;

namespace JsonConditional.Core.Models.Audiovisual
{
    public class Movie : AudiovisualWork
    {
        public override EWorkType Type => EWorkType.Movie;

        public Movie()
        {
        }

        public Movie(string title) : base(title)
        {
        }

        public Movie(string title, TimeSpan duration) : base(title, duration)
        {
        }
    }
}
