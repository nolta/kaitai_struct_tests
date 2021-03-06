using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecNavParentFalse : CommonSpec
    {
        [Test]
        public void TestNavParentFalse()
        {
            var r = NavParentFalse.FromFile(SourceFile("nav_parent_codes.bin"));
            Assert.AreEqual(r.ChildSize, 3);
            Assert.AreEqual(r.ElementA.Foo.Code, 73);
            Assert.AreEqual(r.ElementA.Foo.More, new byte[] { 49, 50, 51 });
            Assert.AreEqual(r.ElementA.Bar.Foo.Code, 66);
            Assert.AreEqual(r.ElementB.Foo.Code, 98);
        }
    }
}
