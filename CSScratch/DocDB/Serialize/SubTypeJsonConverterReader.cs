using Model.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace DocDB.Serialize
{
    public class SubTypeJsonConverterReader<BT> : DynamicTypeJsonConverterReader<BT>
    {
        public string DiscriminatorField { get; }

        public Type[] SupportedTypes { get; }

        private SubTypeJsonConverterReader(string discriminatorField, params Type[] supportedTypes)
        {
            this.DiscriminatorField = discriminatorField;
            this.SupportedTypes = supportedTypes;

            foreach (var type in supportedTypes)
            {
                if (!type.IsAssignableTo(typeof(BT)))
                {
                    throw new ArgumentException($"{type} is not of type {typeof(BT)}");
                }
                else if (type == typeof(BT))
                {
                    throw new ArgumentException($"{typeof(BT)} can not be the same as one of the supported types, it must be a parent type.");
                }
                else if (type.IsAbstract || type.IsInterface)
                {
                    throw new ArgumentException($"Cannot convert to abstract or interface type {type}");
                }
            }

        }

        public override Type? ResolveConcreteType(JObject obj)
        {
            var typeName = obj.Value<string>(DiscriminatorField);

            if (typeName == null)
            {
                throw new InvalidOperationException($"Can not get typeName from object using field {DiscriminatorField}.");
            }

            return SupportedTypes.FirstOrDefault(t => t.Name == typeName);
        }

        public class Builder
        {
            public string DiscriminatorField { get; set; }

            private List<Type> subTypes;

            public Builder(string discriminatorField = "type$")
            {
                this.DiscriminatorField = discriminatorField;
                this.subTypes = new List<Type>();
            }

            public Builder WithSubType<ST>() where ST : BT
            {
                this.subTypes.Add(typeof(ST));
                return this;
            }

            public SubTypeJsonConverterReader<BT> Build()
            {
                return new SubTypeJsonConverterReader<BT>(DiscriminatorField, subTypes.ToArray());
            }
        }
    }
}
