using JsonConditional.Core.Models;

namespace JsonConditional.Core.Repository
{
    public class FeedMongoRepository : MongoRepository<Feed>
    {
        protected override string CollectionName => "Feeds";
    }
}
