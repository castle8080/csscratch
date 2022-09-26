using Newtonsoft.Json;

namespace CSScratch.Json
{
    public static class JsonSerializerSettingsExtensions
    {
        public static void AddPolymorphicJsonConverters(this JsonSerializerSettings settings)
        {
            settings.Converters.Add(new PolymorphicJsonTypeReadConverter());
            settings.Converters.Add(new PolymorphicJsonTypeWriteConverter());
        }
    }
}
