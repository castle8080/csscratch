namespace Model.Media
{
    public class OnlineArticle : MediaItem
    {
        public string URI { get; }

        public OnlineArticle(
            string id,
            string name,
            string description,
            string uri)
            : base(id,name, description)
        {
            this.URI = uri;
        }

        public override string ToString()
        {
            return $"OnlineArticle: Name={Name}, URI={URI}";
        }
    }
}
