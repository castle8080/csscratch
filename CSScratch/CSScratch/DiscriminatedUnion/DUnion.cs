namespace CSScratch.DiscriminatedUnion
{
    public abstract partial class DUnion
    {
        public DUnionValue UnionValue { get; }

        protected DUnion(DUnionValue unionValue)
        {
            this.UnionValue = unionValue;
        }

        public override string ToString()
        {
            return UnionValue.ToString();
        }
    }

}
