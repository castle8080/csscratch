using Model.Media;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocDB.Serialize
{
    // This is an example of a JsonConverter for reads
    // which doesn't use the type$ field.
    // It looks at other attributes of the object structure.
    public class MediaItemJsonConverterReader : DynamicTypeJsonConverterReader<MediaItem>
    {
        public override Type? ResolveConcreteType(JObject obj)
        {
            if (obj["Artist"] != null && obj["ReleaseYear"] != null)
            {
                return typeof(MusicAlbum);
            }
            else if (obj["Views"] != null && obj["URI"] != null)
            {
                return typeof(YouTubeVideo);
            }
            else if (obj["URI"] != null)
            {
                return typeof(OnlineArticle);
            }
            else
            {
                return null;
            }
        }
    }
}
