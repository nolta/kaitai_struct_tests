#include <boost/test/unit_test.hpp>

#include <index_sizes.h>

#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_index_sizes) {
    std::ifstream ifs("src/index_sizes.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    index_sizes_t* r = new index_sizes_t(&ks);

    BOOST_CHECK_EQUAL(r->qty(), 3);

    BOOST_CHECK_EQUAL(r->sizes()->at(0), 1);
    BOOST_CHECK_EQUAL(r->sizes()->at(1), 8);
    BOOST_CHECK_EQUAL(r->sizes()->at(2), 4);

    BOOST_CHECK_EQUAL(r->bufs()->at(0), "A");
    BOOST_CHECK_EQUAL(r->bufs()->at(1), "BBBBBBBB");
    BOOST_CHECK_EQUAL(r->bufs()->at(2), "CCCC");

    delete r;
}
