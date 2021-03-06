using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecStrPadTermEmpty : CommonSpec
    {
        [Test]
        public void TestStrPadTermEmpty()
        {
            var r = StrPadTermEmpty.FromFile(SourceFile("str_pad_term_empty.bin"));
            Assert.AreEqual(r.StrPad, "");
            Assert.AreEqual(r.StrTerm, "");
            Assert.AreEqual(r.StrTermAndPad, "");
            Assert.AreEqual(r.StrTermInclude, "@");
        }
    }
}
