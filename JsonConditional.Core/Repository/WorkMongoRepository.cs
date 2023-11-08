using JsonConditional.Core.Models;

namespace JsonConditional.Core.Repository
{
    public class WorkMongoRepository : MongoRepository<IWork, Work>
    {
        protected override string CollectionName => "Works";
    }
}
