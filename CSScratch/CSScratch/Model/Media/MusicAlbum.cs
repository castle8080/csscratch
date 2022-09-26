namespace CSScratch.Model.Media
{
    public class MusicAlbum : MediaItem
    {
        public string Artist { get; }

        public int ReleaseYear { get; }

        public string AmazonLink { get; }

        public MusicAlbum(
            string name,
            string description,
            string artist,
            int releaseYear,
            string amazonLink)
            : base(name, description)
        {
            this.Artist = artist;
            this.ReleaseYear = releaseYear;
            this.AmazonLink = amazonLink;
        }
    }
}
