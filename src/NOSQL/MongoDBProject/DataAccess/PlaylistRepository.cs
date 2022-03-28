using MongoDBProject.Common.Concrete;
using MongoDBProject.Common.Context;
using MongoDBProject.Entities;

namespace MongoDBProject.DataAccess
{
    public class PlaylistRepository:Repository<Playlist>,IPlaylistRepository
    {
        public PlaylistRepository(IMongoContext context) : base(context) { }
    }
}
