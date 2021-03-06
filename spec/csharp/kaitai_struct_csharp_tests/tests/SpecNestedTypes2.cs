using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecNestedTypes2 : CommonSpec
    {
        [Test]
        public void TestNestedTypes2()
        {
            var r = NestedTypes2.FromFile(SourceFile("fixed_struct.bin"));
            Assert.AreEqual(r.One.TypedAtRoot.ValueB, 80);
    
            Assert.AreEqual(r.One.TypedHere1.ValueC, 65);
    
            Assert.AreEqual(r.One.TypedHere1.TypedHere.ValueD, 67);
            Assert.AreEqual(r.One.TypedHere1.TypedParent.ValueCc, 75);
            Assert.AreEqual(r.One.TypedHere1.TypedRoot.ValueB, 45);
    
            Assert.AreEqual(r.One.TypedHere2.ValueCc, 49);
    
            Assert.AreEqual(r.Two.ValueB, -1);
        }
    }
}
