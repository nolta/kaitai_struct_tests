package spec

import (
	"os"
	"testing"

	"github.com/kaitai-io/kaitai_struct_go_runtime/kaitai"
	"github.com/stretchr/testify/assert"

	. "test_formats"
)

func TestNestedTypes(t *testing.T) {
	f, err := os.Open("../../src/fixed_struct.bin")
	if err != nil {
		t.Fatal(err)
	}
	s := kaitai.NewStream(f)

	var r NestedTypes
	err = r.Read(s, &r, &r)
	if err != nil {
		t.Fatal(err)
	}

	assert.EqualValues(t, 80, r.One.TypedAtRoot.ValueB)
	assert.EqualValues(t, 65, r.One.TypedHere.ValueC)
	assert.EqualValues(t, 67, r.Two.ValueB)
}
