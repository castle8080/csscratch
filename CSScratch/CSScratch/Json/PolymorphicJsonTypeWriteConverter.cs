using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace CSScratch.Json
{
    public class PolymorphicJsonTypeWriteConverter : JsonConverter
    {
        public override bool CanRead => false;

        public override bool CanConvert(Type objectType)
        {
            var convertible = objectType.GetCustomAttribute<PolymorphicJsonType>();
            return convertible != null && convertible.BaseTypes.Contains(objectType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            var concreteType = value.GetType();
            var convertible = concreteType.GetCustomAttribute<PolymorphicJsonType>(true)!;
            var contract = (JsonObjectContract)serializer.ContractResolver.ResolveContract(concreteType);

            writer.WriteStartObject();
            writer.WritePropertyName(convertible.DiscriminatorPropertyName);
            writer.WriteValue(concreteType.Name);

            foreach (var prop in contract.Properties)
            {
                WriteProperty(writer, prop, contract, value, serializer);
            }

            writer.WriteEndObject();
        }

        private void WriteProperty(JsonWriter writer, JsonProperty prop, JsonObjectContract contract, object value, JsonSerializer serializer)
        {
            if (ShouldSerialize(prop, value))
            {
                var propValue = prop.ValueProvider!.GetValue(value);
                if (propValue == null)
                {
                    var nvHandling = prop.NullValueHandling ?? contract.ItemNullValueHandling ?? serializer.NullValueHandling;
                    if (NullValueHandling.Include == nvHandling)
                    {
                        writer.WritePropertyName(prop.PropertyName!);
                        writer.WriteNull();
                    }
                }
                else
                {
                    writer.WritePropertyName(prop.PropertyName!);
                    serializer.Serialize(writer, propValue, prop.PropertyType!);
                }
            }
        }

        private bool ShouldSerialize(JsonProperty prop, object value)
        {
            return (
                !prop.Ignored &&
                prop.Readable &&
                (prop.ShouldSerialize == null || prop.ShouldSerialize!(value))
            );
        }
    }
}
