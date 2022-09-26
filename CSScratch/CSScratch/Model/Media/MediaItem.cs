using CSScratch.Json;
using Newtonsoft.Json;

namespace CSScratch.Model.Media
{
    [PolymorphicJsonType("$type", typeof(MusicAlbum), typeof(OnlineArticle), typeof(YouTubeVideo))]
    public abstract class MediaItem
    {
        public string Name { get; }

        public string Description { get; }


        public MediaItem(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
