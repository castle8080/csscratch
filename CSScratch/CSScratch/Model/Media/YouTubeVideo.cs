namespace CSScratch.Model.Media
{
    public class YouTubeVideo : MediaItem
    {
        public string URI { get; }

        public int Views { get; }

        public YouTubeVideo(
            string name,
            string description,
            string uri,
            int views)
            : base(name, description)
        {
            this.URI = uri;
            this.Views = views;
        }
    }
}
