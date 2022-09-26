using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace CSScratch.Json
{
    public class PolymorphicJsonTypeReadConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            var convertible = objectType.GetCustomAttribute<PolymorphicJsonType>(false);
            return convertible != null;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            var convertible = objectType.GetCustomAttribute<PolymorphicJsonType>(false)!;

            var obj = JObject.Load(reader);
            var typeName = obj.Value<string>(convertible.DiscriminatorPropertyName);

            if (typeName == null)
            {
                throw new InvalidOperationException($"Can not get typeName from object using field {convertible.DiscriminatorPropertyName}");
            }

            var concreteType = convertible.BaseTypes.FirstOrDefault(t => t.Name == typeName);
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

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
