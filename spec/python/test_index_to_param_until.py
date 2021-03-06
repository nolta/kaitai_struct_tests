import unittest

from index_to_param_until import IndexToParamUntil

class TestIndexToParamUntil(unittest.TestCase):
    def test_index_to_param_until(self):
        r = IndexToParamUntil.from_file("src/index_sizes.bin")

        self.assertEqual(r.qty, 3)

        self.assertEqual(r.sizes[0], 1)
        self.assertEqual(r.sizes[1], 8)
        self.assertEqual(r.sizes[2], 4)

        self.assertEqual(r.blocks[0].buf, "A")
        self.assertEqual(r.blocks[1].buf, "BBBBBBBB")
        self.assertEqual(r.blocks[2].buf, "CCCC")
