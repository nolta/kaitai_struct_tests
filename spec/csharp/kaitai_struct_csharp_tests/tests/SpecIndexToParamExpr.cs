using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecIndexToParamExpr : CommonSpec
    {
        [Test]
        public void TestIndexToParamExpr()
        {
            var r = IndexToParamExpr.FromFile(SourceFile("index_sizes.bin"));
            Assert.AreEqual(r.Qty, 3);
    
            Assert.AreEqual(r.Sizes[0], 1);
            Assert.AreEqual(r.Sizes[1], 8);
            Assert.AreEqual(r.Sizes[2], 4);
    
            Assert.AreEqual(r.Blocks[0].Buf, "A");
            Assert.AreEqual(r.Blocks[1].Buf, "BBBBBBBB");
            Assert.AreEqual(r.Blocks[2].Buf, "CCCC");
        }
    }
}
