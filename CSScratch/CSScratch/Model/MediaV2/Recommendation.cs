using Newtonsoft.Json;

namespace CSScratch.Model.MediaV2
{
    public class Recommendation
    {
        public OnlineArticle? OnlineArticle { get; }
        
        public MusicAlbum? MusicAlbum { get; }

        public YouTubeVideo? YouTubeVideo { get; }

        /// <summary>
        /// This constructor is used by a deserializer and left private to keep normal
        /// instantiation from having more than 1 value.
        /// </summary>
        [JsonConstructor]
        private Recommendation(OnlineArticle? onlineArticle, MusicAlbum? musicAlbum, YouTubeVideo? youTubeVideo) 
        {
            OnlineArticle = onlineArticle;
            MusicAlbum = musicAlbum;
            YouTubeVideo = youTubeVideo;

            int nonNullCount = (new MediaItem[] { onlineArticle, musicAlbum, youTubeVideo }).Count(i => i != null);
            if (nonNullCount > 1)
            {
                throw new ArgumentException("More than 1 item was specified.");
            }
            else if (nonNullCount == 0)
            {
                throw new ArgumentException("No item specified.");
            }
        }

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
