namespace CSScratch.Model.MediaV2
{
    public class OnlineArticle : MediaItem
    {
        public string URI { get; }

        public OnlineArticle(
            string name,
            string description,
            string uri)
            : base(name, description)
        {
            this.URI = uri;
        }
    }
}
