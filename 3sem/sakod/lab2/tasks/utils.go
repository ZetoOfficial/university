package tasks

import (
	"fmt"
	"io"
	"log"
	"os"
	"strconv"
	"strings"
	"time"
)

func Timer(name string) func() {
	start := time.Now()
	return func() {
		t := time.Since(start)
		fmt.Printf("%s took \t%vns (%v)\n", name, t.Nanoseconds(), t)
	}
}

func Max(x, y int) int {
	if x < y {
		return y
	}
	return x
}

func LoadDataFromFile(path string) (int, [][]int) {
	file, err := os.Open(path)
	if err != nil {
		log.Fatal(err)
	}
	defer file.Close()

	data := make([]byte, 64)
	var newStr []string
	for {
		n, err := file.Read(data)
		if err == io.EOF { // если конец файла
			break // выходим из цикла
		}
		newStr = strings.Split(string(data[:n]), "\n")
	}

	N, _ := strconv.Atoi(newStr[0]) // String N to Int N

	arr := make([][]int, N)
	for i := range arr {
		arr[i] = make([]int, N)
	}

	for i, s := range newStr[1:] {
		sNumbers := strings.Split(s, " ")
		var numbers = []int{}
		for _, i := range sNumbers {
			j, _ := strconv.Atoi(i)
			numbers = append(numbers, j)
		}
		arr[i] = numbers
	}
	return N, arr
}
