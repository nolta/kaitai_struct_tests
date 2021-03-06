using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecEnum1 : CommonSpec
    {
        [Test]
        public void TestEnum1()
        {
            var r = Enum1.FromFile(SourceFile("enum_0.bin"));
            Assert.AreEqual(r.Main.Submain.Pet1, Enum1.MainObj.Animal.Cat);
            Assert.AreEqual(r.Main.Submain.Pet2, Enum1.MainObj.Animal.Chicken);
        }
    }
}
