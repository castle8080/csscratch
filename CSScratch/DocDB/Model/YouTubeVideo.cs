namespace Model.Media
{
    public class YouTubeVideo : MediaItem
    {
        public string URI { get; }

        public int Views { get; }

        public YouTubeVideo(
            string id,
            string name,
            string description,
            string uri,
            int views)
            : base(id, name, description)
        {
            this.URI = uri;
            this.Views = views;
        }
        public override string ToString()
        {
            return $"YouTubeVideo: Name={Name}, URI={URI}, Views={Views}";
        }
    }
}
