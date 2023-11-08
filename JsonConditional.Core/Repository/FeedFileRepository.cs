using JsonConditional.Core.Models;

namespace JsonConditional.Core.Repository
{
    public class FeedFileRepository : FileRepository<Feed>
    {
        protected override string FilePath => @"c:\feeds.json";
    }
}
