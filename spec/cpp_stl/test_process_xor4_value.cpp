#include <boost/test/unit_test.hpp>

#include <process_xor4_value.h>

#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_process_xor4_value) {
    std::ifstream ifs("src/process_xor_4.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    process_xor4_value_t* r = new process_xor4_value_t(&ks);

    BOOST_CHECK_EQUAL((uint8_t) r->key()[0], 0xec);
    BOOST_CHECK_EQUAL((uint8_t) r->key()[1], 0xbb);
    BOOST_CHECK_EQUAL((uint8_t) r->key()[2], 0xa3);
    BOOST_CHECK_EQUAL((uint8_t) r->key()[3], 0x14);
    BOOST_CHECK_EQUAL(r->buf(), "foo bar");

    delete r;
}
