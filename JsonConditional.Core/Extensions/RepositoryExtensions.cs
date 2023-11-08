using JsonConditional.Core.Repository;

namespace JsonConditional.Core.Extensions
{
    public static class RepositoryExtensions
    {
        public static bool IsEmpty<T>(this IRepository<T> repository) where T : class
        {
            return repository.Count() == 0;
        }
    }
}
