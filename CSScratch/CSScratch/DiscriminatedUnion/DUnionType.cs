namespace CSScratch.DiscriminatedUnion
{
    public static class DUnionType
    {
        public static DUnionType<T> Of<T>() => default;
    }

    /// <summary>
    /// Exists only to make it easier to ask for a type from a union.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct DUnionType<T>
    {
    }
}
