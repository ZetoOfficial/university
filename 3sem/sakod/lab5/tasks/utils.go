package tasks

import (
	"fmt"
	"time"
)

func TimeTrack(start time.Time, name string) {
	elapsed := time.Since(start).Nanoseconds()
	fmt.Printf("%s took %vns\n", name, elapsed)
}
