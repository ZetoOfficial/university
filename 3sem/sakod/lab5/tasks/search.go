package tasks

import (
	"fmt"
	"math/rand"
	"time"

	"github.com/tealeg/xlsx"
)

// Последовательный поиск O(n)
func SequentialSearch(arr []int, value int) int {
	for i, v := range arr {
		if v == value {
			return i
		}
	}

	return len(arr) + 1
}

// Последовательный с барьером поиск O(n)
func SequentialSearchWithBarrier(arr []int, value int) int {
	i := 0
	for arr[i] != value {
		i++
	}

	if i == len(arr)-1 {
		return -1
	}

	return i
}

// Бинарный поиск O(log(n))
func BinarySearch(arr []int, value int) int {
	left := 0
	right := len(arr) - 1

	for left <= right {
		mid := (left + right) / 2

		if arr[mid] == value {
			return mid
		} else if arr[mid] < value {
			left = mid + 1
		} else {
			right = mid - 1
		}
	}

	return -1
}

// Интерполяционный поиск O(log(log(n)))
func InterpolationSearch(arr []int, value int) int {
	left := 0
	right := len(arr) - 1

	for left <= right && value >= arr[left] && value <= arr[right] {
		mid := left + (value-arr[left])*(right-left)/(arr[right]-arr[left])

		if arr[mid] == value {
			return mid
		} else if arr[mid] < value {
			left = mid + 1
		} else {
			right = mid - 1
		}
	}

	return -1
}

// заполнение массива рандомными значениями
func fillArray(arr []int) {
	for i := range arr {
		arr[i] = rand.Intn(100)
	}
}

func runSequentialSearch(arr []int, value int, M int) int64 {
	start := time.Now()
	for i := 0; i < M; i++ {
		SequentialSearch(arr, value)
	}
	elapsed := time.Since(start).Nanoseconds()
	fmt.Printf("Последовательный поиск: N: %v M: %v took %d ns\n", len(arr), M, elapsed)
	return elapsed
}

func runSequentialSearchWithBarrier(arr []int, value int, M int) int64 {
	arr = append(arr, value)
	start := time.Now()
	for i := 0; i < M; i++ {
		SequentialSearchWithBarrier(arr, value)
	}
	elapsed := time.Since(start).Nanoseconds()
	fmt.Printf("Последовательный с барьером поиск: N: %v M: %v took %d ns\n", len(arr), M, elapsed)
	return elapsed
}

func runBinarySearch(arr []int, value int, M int) int64 {
	start := time.Now()
	for i := 0; i < M; i++ {
		BinarySearch(arr, value)
	}
	elapsed := time.Since(start).Nanoseconds()
	fmt.Printf("Бинарный поиск: N: %v M: %v took %d ns\n", len(arr), M, elapsed)
	return elapsed
}

func runInterpolationSearch(arr []int, value int, M int) int64 {
	start := time.Now()
	for i := 0; i < M; i++ {
		InterpolationSearch(arr, value)
	}
	elapsed := time.Since(start).Nanoseconds()
	fmt.Printf("Интерполяционный поиск: N: %v M: %v took %v ns\n", len(arr), M, elapsed)
	return elapsed
}

func Task7() {
	var file *xlsx.File
	var sheet *xlsx.Sheet
	var row *xlsx.Row
	var cell *xlsx.Cell
	var err error

	var nCountArray []int = []int{1000, 2000, 4000, 8000, 16000}
	var nTasksArray [][]int
	var tempArr []int
	var searchElem int = 45

	sortFuncMap := map[string]func([]int, int, int) int64{
		"Последовательный поиск":      runSequentialSearch,
		"Последовательный с барьером": runSequentialSearchWithBarrier,
		"Бинарный поиск":              runBinarySearch,
		"Интерполяционный поиск":      runInterpolationSearch,
	}
	sortFuncNames := []string{"Последовательный поиск", "Последовательный с барьером", "Бинарный поиск", "Интерполяционный поиск"}

	// Заполняю тестовые массивчики с данными
	for _, n := range nCountArray {
		tempArr = make([]int, n)
		fillArray(tempArr)
		nTasksArray = append(nTasksArray, tempArr)
	}

	// Создаю файл
	file = xlsx.NewFile()
	sheet, err = file.AddSheet("Sheet1")
	if err != nil {
		fmt.Print(err.Error())
	}

	// Создаю шапочку таблицы: N, M, SearchName, N=1000, N=2000, N=4000, N=8000, N=16000
	colNames := []string{"M", "SearchName"}
	for _, n := range nCountArray {
		colNames = append(colNames, fmt.Sprintf("N=%v", n))
	}

	// Заполняю шапочку
	row = sheet.AddRow()
	for _, colName := range colNames {
		cell = row.AddCell()
		cell.Value = colName
	}

	// Заполняю таблицу
	for _, iterations := range []int{5000, 10000, 20000} {
		time.Sleep(time.Duration(1))
		for _, funcName := range sortFuncNames {
			row = sheet.AddRow()
			row.AddCell().Value = fmt.Sprintf("%v", iterations)
			row.AddCell().Value = funcName
			for _, n := range nTasksArray {
				row.AddCell().Value = fmt.Sprintf("%v", sortFuncMap[funcName](n, searchElem, iterations))
			}
		}
	}

	// Сохраняю файл
	err = file.Save("result.xlsx")
	if err != nil {
		fmt.Print(err.Error())
	}
}
