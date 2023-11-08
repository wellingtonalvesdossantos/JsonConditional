using Newtonsoft.Json;

namespace JsonConditional.Core.Repository
{
    public abstract class FileRepository<T> : IRepository<T> where T : class
    {
        private List<T> _list = new List<T>();
        protected abstract string FilePath { get; }

        public FileRepository()
        {
            ReadFile();
        }

        private void ReadFile()
        {
            try
            {
                if (!File.Exists(FilePath)) return;
                using (StreamReader file = File.OpenText(FilePath))
                {
                    var json = file.ReadToEnd();
                    _list = JsonConvert.DeserializeObject<List<T>>(json, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                    }) ?? new List<T>();
                }
            }
            catch { }
        }

        private void PersistInFile()
        {
            try
            {
                using (StreamWriter file = File.CreateText(FilePath))
                {
                    var json = JsonConvert.SerializeObject(_list, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                    });
                    file.Write(json);
                }
            }
            catch { }
        }

        public void Add(T entity)
        {
            _list.Add(entity);
            PersistInFile();
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
                PersistInFile();
        }
    }
}
