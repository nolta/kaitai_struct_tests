using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecSwitchBytearray : CommonSpec
    {
        [Test]
        public void TestSwitchBytearray()
        {
            var r = SwitchBytearray.FromFile(SourceFile("switch_opcodes.bin"));
            Assert.AreEqual(r.Opcodes.Count, 4);

            CollectionAssert.AreEqual(r.Opcodes[0].Code, new byte[] { 83 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Strval)r.Opcodes[0].Body).Value, "foobar");

            CollectionAssert.AreEqual(r.Opcodes[1].Code, new byte[] { 73 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Intval)r.Opcodes[1].Body).Value, 0x42);

            CollectionAssert.AreEqual(r.Opcodes[2].Code, new byte[] { 73 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Intval)r.Opcodes[2].Body).Value, 0x37);

            CollectionAssert.AreEqual(r.Opcodes[3].Code, new byte[] { 83 });
            Assert.AreEqual(((SwitchBytearray.Opcode.Strval)r.Opcodes[3].Body).Value, "");
        }
    }
}
