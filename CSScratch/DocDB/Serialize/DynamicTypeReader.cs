using Model.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace DocDB.Serialize
{
    public abstract class DynamicTypeReader<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T);
        }

        public override bool CanWrite => false;

        public abstract Type? ResolveConcreteType(JObject obj);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var obj = JObject.Load(reader);
            var concreteType = ResolveConcreteType(obj);
            if (concreteType == null)
            {
                throw new InvalidOperationException($"Can not determine type.");
            }
            if (objectType == concreteType)
            {
                throw new InvalidOperationException($"Can not deserialize using {objectType} as the actual type target.");
            }

            var objReader = new JTokenReader(obj);
            return serializer.Deserialize(objReader, concreteType!);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
