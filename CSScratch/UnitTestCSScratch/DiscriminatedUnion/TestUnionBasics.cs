using CSScratch.DiscriminatedUnion;

namespace UnitTestCSScratch.DiscriminatedUnion
{
    using StringOrNumber = DUnion<string, int>;

    public class TestUnionBasics
    {

        [Test]
        public void TestBasicUnion()
        {
            var du1 = new StringOrNumber(42);

            Assert.IsTrue(du1.Is(DUnionType.Of<int>()));
            Assert.That(du1.Get(DUnionType.Of<int>()), Is.EqualTo(42));

            Assert.IsFalse(du1.Is(DUnionType.Of<string>()));
        }

        [Test]
        public void TestBasicUnionT2()
        {
            var du1 = new StringOrNumber("bob");

            // The below should not compile
            //du1.Is(DUnionType.Of<double>());

            Assert.IsTrue(du1.Is(DUnionType.Of<string>()));
            Assert.That(du1.Get(DUnionType.Of<string>()), Is.EqualTo("bob"));

            Assert.IsFalse(du1.Is(DUnionType.Of<int>()));
        }
    }
}