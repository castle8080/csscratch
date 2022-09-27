using CSScratch.DiscriminatedUnion;

namespace UnitTestCSScratch.DiscriminatedUnion
{
    public class TestUnionBasics
    {
        [Test]
        public void TestBasicUnion()
        {
            var du1 = new DUnion<string, int>(42);

            Assert.IsTrue(du1.Is(DUnionType.Of<int>()));
            Assert.That(du1.Get(DUnionType.Of<int>()), Is.EqualTo(42));

            Assert.IsFalse(du1.Is(DUnionType.Of<string>()));
        }

        [Test]
        public void TestBasicUnionT2()
        {
            var du1 = new DUnion<string, int>("bob");

            // The below should not compile
            //du1.Is(DUnionType.Of<double>());

            Assert.IsTrue(du1.Is(DUnionType.Of<string>()));
            Assert.That(du1.Get(DUnionType.Of<string>()), Is.EqualTo("bob"));

            Assert.IsFalse(du1.Is(DUnionType.Of<int>()));
        }

        [Test]
        public void TestSwitch()
        {
            var items = new[] {
                new DUnion<string, int, double>("bob"),
                new DUnion<string, int, double>(42),
                new DUnion<string, int, double>(3.14)
            };

            // this won't compile unless you supply all cases.
            var results = items.Select(i => i.Switch(
                s => s + ":" + s,
                n => (n * 2).ToString(),
                d => (d * 3).ToString()
            )).ToArray();

            Assert.That(results, Is.EquivalentTo(new[] {
                "bob:bob",
                "84",
                "9.42"
            }));
        }
    }
}