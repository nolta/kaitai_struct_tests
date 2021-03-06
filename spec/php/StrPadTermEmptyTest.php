<?php
namespace Kaitai\Struct\Tests;

class StrPadTermEmptyTest extends TestCase {
    public function testStrPadTermEmpty() {
        $r = StrPadTermEmpty::fromFile(self::SRC_DIR_PATH . "/str_pad_term_empty.bin");

        $this->assertEquals('', $r->strPad);
        $this->assertEquals('', $r->strTerm);
        $this->assertEquals('', $r->strTermAndPad);
        $this->assertEquals('@', $r->strTermInclude);
    }
}
