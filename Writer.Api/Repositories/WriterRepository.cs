
namespace Writer.Api.Repositories
{
    public class WriterRepository : List<Models.Writer>, IWriterRepository
    {
        private readonly static List<Models.Writer> _writers = Populate();

        private static List<Models.Writer> Populate()
        {
            return new List<Models.Writer>
            {
                new Models.Writer
                {
                    Id = 1,
                    Name = "Robert Greene"
                },
                new Models.Writer
                {
                    Id = 2,
                    Name = "Daniel Kahneman"
                },
                new Models.Writer 
                {
                    Id = 3,
                    Name = "Robert Bly"
                }
            };
        }

        public List<Models.Writer> GetAll() 
        {
            return _writers;
        }

        public Models.Writer Get(int id) 
        {
            return _writers.FirstOrDefault(x=> x.Id == id);
        }

        public Models.Writer Insert(Models.Writer writer)
        {
            _writers.Add(writer);
            return _writers.FirstOrDefault(x => x.Id == writer.Id);
        }
    }
}
