import unittest

from default_endian_expr_is_be import DefaultEndianExprIsBe

class TestDefaultEndianExprIsBe(unittest.TestCase):
    def test_default_endian_expr_is_be(self):
        r = DefaultEndianExprIsBe.from_file("src/endian_expr.bin")

        # LE
        self.assertEqual(r.docs[0].indicator, bytearray([0x49, 0x49]))
        self.assertEqual(r.docs[0].main.some_int, 0x42)
        self.assertEqual(r.docs[0].main.some_int_be, 0x42)
        self.assertEqual(r.docs[0].main.some_int_le, 0x42)

        self.assertEqual(r.docs[0].main.inst_int, 0x42)
        self.assertEqual(r.docs[0].main.inst_sub.foo, 0x42)

        # BE
        self.assertEqual(r.docs[1].indicator, bytearray([0x4d, 0x4d]))
        self.assertEqual(r.docs[1].main.some_int, 0x42)
        self.assertEqual(r.docs[1].main.some_int_be, 0x42)
        self.assertEqual(r.docs[1].main.some_int_le, 0x42)

        self.assertEqual(r.docs[1].main.inst_int, 0x42000000)
        self.assertEqual(r.docs[1].main.inst_sub.foo, 0x42000000)

        # Weird => LE
        self.assertEqual(r.docs[2].indicator, bytearray([0x58, 0x58]))
        self.assertEqual(r.docs[2].main.some_int, 0x42000000)
        self.assertEqual(r.docs[2].main.some_int_be, 0x42)
        self.assertEqual(r.docs[2].main.some_int_le, 0x42)

        self.assertEqual(r.docs[2].main.inst_int, 0x42)
        self.assertEqual(r.docs[2].main.inst_sub.foo, 0x42)
