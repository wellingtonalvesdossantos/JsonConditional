using MongoDB.Driver;

namespace JsonConditional.Core.Repository
{
    public abstract class MongoRepository<T> : MongoRepository<T, T> where T : class
    {
    }

    public abstract class MongoRepository<T, U> : IRepository<T> where  U : T where T : class
    {
        private List<T> _list = new List<T>();
        protected abstract string CollectionName { get; }
        private readonly string ConnectionString = @"mongodb://localhost:27017";
        private readonly string DatabaseName = @"default";

        public MongoRepository()
        {
            ReadCollection();
        }

        private void ReadCollection()
        {
            try
            {
                var collection = GetCollection();
                _list = collection.AsQueryable().ToList().Cast<T>().ToList();
            }
            catch { }
        }

        private void Persist()
        {
            try
            {
                var collection = GetCollection();
                if (collection.CountDocuments(FilterDefinition<U>.Empty) == 0)
                {
                    collection.InsertMany(_list.Cast<U>());
                }
                else
                {
                    collection.InsertOne((U)_list.Last());
                }
            }
            catch { }
        }

        protected IMongoCollection<U> GetCollection()
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);
            return database.GetCollection<U>(CollectionName);
        }

        public void Add(T entity)
        {
            _list.Add(entity);
            Persist();
        }

        public long Count()
        {
            return _list.Count;
        }

        public IReadOnlyList<T> GetAll()
        {
            return _list;
        }

        public void Delete(T entity)
        {
            var count = _list.RemoveAll((x) => x.Equals(entity));
            if (count > 0)
                Persist();
        }
    }
}
