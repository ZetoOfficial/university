package tasks

import (
	"fmt"
	"math/rand"
	"time"

	"github.com/tealeg/xlsx"
)

// Сортировка Пузырьком O(n^2) Устойчивая
func bubbleSortTask2(arr []int) {
	for i := 0; i < len(arr); i++ {
		for j := 0; j < len(arr)-1; j++ {
			if arr[j] > arr[j+1] {
				arr[j], arr[j+1] = arr[j+1], arr[j]
			}
		}
	}
}

// Сортировка Шейкер O(n^2)
func shakerSortTask2(arr []int) {
	for i := 0; i < len(arr)/2; i++ {
		for j := i; j < len(arr)-i-1; j++ {
			if arr[j] > arr[j+1] {
				arr[j], arr[j+1] = arr[j+1], arr[j]
			}
		}
		for j := len(arr) - i - 2; j > i; j-- {
			if arr[j] < arr[j-1] {
				arr[j], arr[j-1] = arr[j-1], arr[j]
			}
		}
	}
}

// Сортировка Выбором O(n^2)
func selectionSortTask2(arr []int) {
	for i := 0; i < len(arr); i++ {
		min := i
		for j := i + 1; j < len(arr); j++ {
			if arr[j] < arr[min] {
				min = j
			}
		}
		arr[i], arr[min] = arr[min], arr[i]
	}
}

// Сортировка Вставками
func insertionSortTask2(arr []int) {
	for i := 1; i < len(arr); i++ {
		for j := i; j > 0 && arr[j-1] > arr[j]; j-- {
			arr[j], arr[j-1] = arr[j-1], arr[j]
		}
	}
}

// Бинарный поиск
func binarySearchTask2(arr []int, value int) int {
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

// Сортировка Бинарными вставками
func binaryInsertionSortTask2(arr []int) {
	for i := 1; i < len(arr); i++ {
		value := arr[i]
		index := binarySearchTask2(arr[:i], value)
		if index == -1 {
			index = i
		}
		copy(arr[index+1:i+1], arr[index:i])
		arr[index] = value
	}
}

func runBubbleSortTask2(arr []int) int64 {
	start := time.Now()
	bubbleSortTask2(arr)
	return time.Since(start).Nanoseconds()
}

func runShakerSortTask2(arr []int) int64 {
	start := time.Now()
	shakerSortTask2(arr)
	return time.Since(start).Nanoseconds()
}

func runSelectionSortTask2(arr []int) int64 {
	start := time.Now()
	selectionSortTask2(arr)
	return time.Since(start).Nanoseconds()
}

func runInsertionSortTask2(arr []int) int64 {
	start := time.Now()
	insertionSortTask2(arr)
	return time.Since(start).Nanoseconds()
}

func runBinaryInsertionSortTask2(arr []int) int64 {
	start := time.Now()
	binaryInsertionSortTask2(arr)
	return time.Since(start).Nanoseconds()
}

// заполнение массива рандомными значениями
func fillArrayTask2(arr []int) {
	rand.Seed(time.Now().UnixNano())
	for i := range arr {
		arr[i] = rand.Intn(1000000)
	}
}

// reverseArrayTask2 - переворачивает массив
func reverseArrayTask2(arr []int) {
	for i := 0; i < len(arr)/2; i++ {
		arr[i], arr[len(arr)-i-1] = arr[len(arr)-i-1], arr[i]
	}
}

func Task2() {
	var file *xlsx.File
	var sheet *xlsx.Sheet
	var row *xlsx.Row
	var cell *xlsx.Cell
	var err error

	var nCountArray []int = []int{5000, 10000, 20000, 20000, 20000}
	var nTasksArray [][]int
	var tempArr []int

	sortFuncMap := map[string]func([]int) int64{
		"Пузырьком":           runBubbleSortTask2,
		"Шейкер":              runShakerSortTask2,
		"Выбором":             runSelectionSortTask2,
		"Вставками":           runInsertionSortTask2,
		"Бинарными вставками": runBinaryInsertionSortTask2,
	}
	sortFuncNames := []string{"Пузырьком", "Шейкер", "Выбором", "Вставками", "Бинарными вставками"}

	// Заполняю тестовые массивчики с данными
	for _, n := range nCountArray {
		tempArr = make([]int, n)
		fillArrayTask2(tempArr)
		nTasksArray = append(nTasksArray, tempArr)
	}

	binaryInsertionSortTask2(nTasksArray[len(nTasksArray)-2])
	binaryInsertionSortTask2(nTasksArray[len(nTasksArray)-1])
	reverseArrayTask2(nTasksArray[len(nTasksArray)-1])

	// Создаю файл
	file = xlsx.NewFile()
	sheet, err = file.AddSheet("Sheet1")
	if err != nil {
		fmt.Print(err.Error())
	}

	// Создаю шапочку таблицы: N, M, SearchName, N=1000, N=2000, N=4000, N=8000, N=16000
	colNames := []string{"SortName"}
	for _, n := range nCountArray {
		colNames = append(colNames, fmt.Sprintf("N=%v", n))
	}
	colNames[len(colNames)-2] = "N=20000 (asc)"
	colNames[len(colNames)-1] = "N=20000 (desc)"

	// Заполняю шапочку
	row = sheet.AddRow()
	for _, colName := range colNames {
		cell = row.AddCell()
		cell.Value = colName
	}

	// Заполняю таблицу
	for _, funcName := range sortFuncNames {
		time.Sleep(time.Duration(1))
		row = sheet.AddRow()
		row.AddCell().Value = funcName
		for _, n := range nTasksArray {
			var tempArray []int = make([]int, len(n))
			copy(tempArray, n)
			row.AddCell().Value = fmt.Sprintf("%v", sortFuncMap[funcName](tempArray))
		}
	}

	// Сохраняю файл
	err = file.Save("result2.xlsx")
	if err != nil {
		fmt.Print(err.Error())
	}
}
