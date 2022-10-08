using Newtonsoft.Json;

namespace Model.Media
{
    public abstract class MediaItem
    {
        [JsonProperty("id")]
        public string Id { get; }

        [JsonProperty("type$")]
        public string Type { get => this.GetType().Name; }

        public string Name { get; }

        public string Description { get; }


        public MediaItem(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
