using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Writer.Api.Repositories;

namespace Writer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly IWriterRepository _writerRepository;

        public WritersController(IWriterRepository writerRepository)
        {
            _writerRepository = writerRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_writerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var writer = _writerRepository.Get(id);
            return Ok(writer);
        }

        [HttpPost]
        public IActionResult Create(Models.Writer writer) 
        {
            _writerRepository.Insert(writer);
            return Ok(_writerRepository.Get(writer.Id));
        }
    }
}
