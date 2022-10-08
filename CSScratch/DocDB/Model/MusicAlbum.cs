namespace Model.Media
{
    public class MusicAlbum : MediaItem
    {
        public string Artist { get; }

        public int ReleaseYear { get; }

        public string AmazonLink { get; }

        public MusicAlbum(
            string id,
            string name,
            string description,
            string artist,
            int releaseYear,
            string amazonLink)
            : base(id, name, description)
        {
            this.Artist = artist;
            this.ReleaseYear = releaseYear;
            this.AmazonLink = amazonLink;
        }

        public override string ToString()
        {
            return $"MusicAlbum: Name={Name}, Artist={Artist}, ReleaseYear={ReleaseYear}";
        }
    }
}
