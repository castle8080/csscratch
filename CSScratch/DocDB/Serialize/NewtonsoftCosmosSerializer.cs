using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Serialization;
using Newtonsoft.Json;

namespace DocDB.Serialize
{
    public class NewtonsoftCosmosSerializer : CosmosSerializer
    {
        public JsonSerializer JsonSerializer { get; }

        public NewtonsoftCosmosSerializer(JsonSerializer serializer)
        {
            this.JsonSerializer = serializer;
        }

        public NewtonsoftCosmosSerializer() : this(new JsonSerializer())
        {
        }

        public override T FromStream<T>(Stream stream)
        {
            using (var reader = new JsonTextReader(new StreamReader(stream)))
            {
                return JsonSerializer.Deserialize<T>(reader);
            }
        }

        public override Stream ToStream<T>(T input)
        {
            var stream = new MemoryStream();
            var jsonWriter = new JsonTextWriter(new StreamWriter(stream));
            JsonSerializer.Serialize(jsonWriter, input, typeof(T));
            jsonWriter.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
