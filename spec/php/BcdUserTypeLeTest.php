<?php
namespace Kaitai\Struct\Tests;

class BcdUserTypeLeTest extends TestCase {
    public function testBcdUserTypeLe() {
        $r = BcdUserTypeLe::fromFile(self::SRC_DIR_PATH . "/bcd_user_type_le.bin");

        $this->assertEquals(12345678, $r->ltr->asInt);
        $this->assertEquals("12345678", $r->ltr->asStr);
        $this->assertEquals(87654321, $r->rtl->asInt);
        $this->assertEquals("87654321", $r->rtl->asStr);
        $this->assertEquals(123456, $r->leadingZeroLtr->asInt);
        $this->assertEquals("00123456", $r->leadingZeroLtr->asStr);
    }
}
