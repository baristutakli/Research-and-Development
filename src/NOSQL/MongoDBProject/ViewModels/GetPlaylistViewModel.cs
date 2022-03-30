namespace MongoDBProject.ViewModels
{
    public class GetPlaylistViewModel
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; }
        public List<string> MovieIds { get; set; }
    }
}
