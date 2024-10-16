namespace Writer.Api.Repositories
{
    public interface IWriterRepository
    {
        public List<Models.Writer> GetAll();
        public Models.Writer Get(int id);
        public Models.Writer Insert(Models.Writer writer);
    }
}
