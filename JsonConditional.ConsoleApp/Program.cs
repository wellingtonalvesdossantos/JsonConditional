// See https://aka.ms/new-console-template for more information
using JsonConditional.Core.Extensions;
using JsonConditional.Core.Models;
using JsonConditional.Core.Models.Audio;
using JsonConditional.Core.Models.Audiovisual;
using JsonConditional.Core.Repository;

/*
IRepository<IWork> repository = null;
var work = new Music("Times Like These") { Duration = new TimeSpan(0, 4, 25) };

repository = new WorkFileRepository();
Process(repository);

repository = new WorkMongoRepository();
Process(repository);

void Process(IRepository<IWork> repository)
{
    if (repository.IsEmpty())
    {
        repository.Add(work);
    }
    var works = repository.GetAll();
}*/

IRepository<IWork> workRepository = null;
workRepository = new WorkMongoRepository();
/*workRepository.Add(new Trailer("Avengers: Infinity War - Trailer 1") { Duration = new TimeSpan(0, 2, 25) });
workRepository.Add(new Movie("Avengers: Infinity War"));*/
var works = workRepository.GetAll();

IRepository<Feed> repository = null;
var feed = new Feed("Audio");
repository = new FeedFileRepository();
Process(repository);

repository = new FeedMongoRepository();
Process(repository);

void Process(IRepository<Feed> repository)
{
    if (repository.IsEmpty())
    {
        repository.Add(feed);
    }
    var feeds = repository.GetAll();
}