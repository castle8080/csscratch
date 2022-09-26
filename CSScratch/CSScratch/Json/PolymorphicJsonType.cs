using System;

namespace CSScratch.Json
{

    /// <summary>
    /// Used by PolymorphicTypeReadConverter and PolymorphicTypeWriteConverter to allow
    /// Newtonsoft to serailize and deserialize types which use inheritance.
    /// 
    /// Usage:
    /// 
    /// [PolymorphicJsonType("$type", typeof(MyConcreteClass1), typeof(MyConcreteClassN))]
    /// public abstract class MyAbstractClass {
    /// }
    /// 
    /// This attibute should be placed on a type whcih shold be instantiated directly. Instances
    /// to be serialized or deserialized should be a the direct type of one of the concrete classes.
    /// 
    /// On serialization, the discriminatorPropertyName is added the json for the object.
    /// On deserialization, this value is read and used to find the correct concrete type to
    /// instantiate.
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PolymorphicJsonType : Attribute
    {
        public string DiscriminatorPropertyName { get; }

        public Type[] BaseTypes { get; }

        public PolymorphicJsonType(string discriminatorPropertyName, params Type[] baseTypes)
        {
            this.DiscriminatorPropertyName = discriminatorPropertyName;
            this.BaseTypes = baseTypes.ToArray();
        }
    }
}
