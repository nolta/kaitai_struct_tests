#include <boost/test/unit_test.hpp>

#include <multiple_use.h>

#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_multiple_use) {
    std::ifstream ifs("src/position_abs.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    multiple_use_t* r = new multiple_use_t(&ks);

    BOOST_CHECK_EQUAL(r->t1()->first_use()->value(), 0x20);
    BOOST_CHECK_EQUAL(r->t2()->second_use()->value(), 0x20);

    delete r;
}
