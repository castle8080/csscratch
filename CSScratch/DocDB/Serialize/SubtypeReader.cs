using Model.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace DocDB.Serialize
{
    public class SubtypeReader<BT> : JsonConverter
    {

        public string DiscriminatorField { get; }

        public Type[] SupportedTypes { get; }

        public SubtypeReader(string discriminatorField, params Type[] supportedTypes)
        {
            this.DiscriminatorField = discriminatorField;
            this.SupportedTypes = supportedTypes;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(BT);
        }

        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var obj = JObject.Load(reader);
            var typeName = obj.Value<string>(DiscriminatorField);

            if (typeName == null)
            {
                throw new InvalidOperationException($"Can not get typeName from object using field {DiscriminatorField}.");
            }

            var concreteType = SupportedTypes.FirstOrDefault(t => t.Name == typeName);
            if (concreteType == null)
            {
                throw new InvalidOperationException($"Can not determine type for {typeName}.");
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
