package main

import (
	"fmt"
	"lab3/tasks"
	"time"
)

func main() {
	// tasks.BankTask(1)
	// tasks.BankTask(3)
	defer tasks.TimeTrack(time.Now(), "JosephusOnLinkedList (9, 3)")
	tasks.JosephusOnLinkedList(9, 3)
	defer tasks.TimeTrack(time.Now(), "JosephusOnArray (9, 3)")
	tasks.JosephusOnArray(9, 3)

	defer tasks.TimeTrack(time.Now(), "EratOnLinkedList (100)")
	ans1 := tasks.EratOnLinkedList(100)
	defer tasks.TimeTrack(time.Now(), "EratOnArray (100)")
	ans2 := tasks.EratOnArray(100)

	ans1.Show()
	fmt.Printf("EratOnArray: %v\n", ans2)
}
