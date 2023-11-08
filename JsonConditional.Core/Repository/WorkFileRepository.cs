using JsonConditional.Core.Models;

namespace JsonConditional.Core.Repository
{
    public class WorkFileRepository : FileRepository<IWork>
    {
        protected override string FilePath => @"c:\trabalhos.json";
    }
}
