using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBProject.DataAccess;
using MongoDBProject.Entities;

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

        [HttpGet("{id}")]
        public IActionResult GetById(string id) => Ok(_repository.GetById(id));

        [HttpPost]
        public IActionResult Create(Playlist playlist)
        {
            _repository.Create(playlist);
            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
         }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var playlist = _repository.GetById(id);
            _repository.Delete(playlist);
            return Ok();
        }

    }
}
