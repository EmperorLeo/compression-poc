package compressionpoc

import (
	"testing"
)

func BenchmarkBrotli(b *testing.B) {
	for i := 0; i < b.N; i++ {
		makeCall("br")
	}
}

func BenchmarkNone(b *testing.B) {
	for i := 0; i < b.N; i++ {
		makeCall("identity")
	}
}

func BenchmarkGzip(b *testing.B) {
	for i := 0; i < b.N; i++ {
		makeCall("gzip")
	}
}
