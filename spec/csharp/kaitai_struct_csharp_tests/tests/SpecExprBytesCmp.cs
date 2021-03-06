using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecExprBytesCmp : CommonSpec
    {
        [Test]
        public void TestExprBytesCmp()
        {
            var r = ExprBytesCmp.FromFile(SourceFile("fixed_struct.bin"));
            Assert.AreEqual(r.One, new byte[] { 80 });
            Assert.AreEqual(r.Two, new byte[] { 65, 67, 75 });
    
            Assert.AreEqual(r.IsEq, true);
            Assert.AreEqual(r.IsNe, false);
            Assert.AreEqual(r.IsLt, true);
            Assert.AreEqual(r.IsGt, false);
            Assert.AreEqual(r.IsLe, true);
            Assert.AreEqual(r.IsGe, false);
            Assert.AreEqual(r.IsLt2, false);
            Assert.AreEqual(r.IsGt2, true);
        }
    }
}
