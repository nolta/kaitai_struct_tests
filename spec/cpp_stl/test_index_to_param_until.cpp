#include <boost/test/unit_test.hpp>

#include <index_to_param_until.h>

#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_index_to_param_until) {
    std::ifstream ifs("src/index_sizes.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    index_to_param_until_t* r = new index_to_param_until_t(&ks);

    BOOST_CHECK_EQUAL(r->qty(), 3);

    BOOST_CHECK_EQUAL(r->sizes()->at(0), 1);
    BOOST_CHECK_EQUAL(r->sizes()->at(1), 8);
    BOOST_CHECK_EQUAL(r->sizes()->at(2), 4);

    BOOST_CHECK_EQUAL(r->blocks()->at(0)->buf(), "A");
    BOOST_CHECK_EQUAL(r->blocks()->at(1)->buf(), "BBBBBBBB");
    BOOST_CHECK_EQUAL(r->blocks()->at(2)->buf(), "CCCC");

    delete r;
}
