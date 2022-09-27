namespace CSScratch.DiscriminatedUnion
{
    public abstract class DUnionValue
    {

        public abstract Type ValueType { get; }

        public abstract bool IsType<T>();

        public abstract T Get<T>();

        public abstract object GetObject();
    }

    public class DUnionValue<T> : DUnionValue
    {
        public override Type ValueType { get => typeof(T); }

        public T Value { get; }

        public DUnionValue(T value)
        {
            this.Value = value;
        }

        public override bool IsType<PT>() => typeof(PT) == typeof(T);

        public override PT Get<PT>()
        {
            if (!this.IsType<PT>())
            {
                throw new InvalidOperationException($"The current value has type {typeof(T)} not {typeof(PT)}.");
            }

            return (PT) (object) this.Value;
        }

        public override object GetObject()
        {
            return this.Value;
        }
    }
}
