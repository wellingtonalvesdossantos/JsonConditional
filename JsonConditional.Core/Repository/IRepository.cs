namespace JsonConditional.Core.Repository
{
    public interface IRepository<T> : IReadonlyRepository<T> where T : class
    {
        void Add(T entity);
        //void Update(T entity);
        void Delete(T entity);
    }

    public interface IReadonlyRepository<T> where T : class
    {
        IReadOnlyList<T> GetAll();
        long Count();
    }
}
