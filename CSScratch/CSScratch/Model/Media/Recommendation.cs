namespace CSScratch.Model.Media
{
    public class Recommendation
    {
        public OnlineArticle? OnlineArticle { get; }
        
        public MusicAlbum? MusicAlbum { get; }

        public YouTubeVideo? YouTubeVideo { get; }

        public Recommendation(OnlineArticle onlineArticle)
        {
            this.OnlineArticle = onlineArticle;
        }

        public Recommendation(MusicAlbum musicAlbum)
        {
            this.MusicAlbum = musicAlbum;
        }

        public Recommendation(YouTubeVideo youTubeVideo)
        {
            this.YouTubeVideo = youTubeVideo;
        }
    }
}
