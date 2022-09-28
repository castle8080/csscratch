using CSScratch.Json;
using Newtonsoft.Json;

namespace CSScratch.Model.MediaV2
{
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
