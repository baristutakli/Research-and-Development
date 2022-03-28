using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBProject.DataAccess;

namespace MongoDBProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistRepository _repository;

        public PlaylistController(IPlaylistRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_repository.GetAll());

        // will be continued...
    }
}
