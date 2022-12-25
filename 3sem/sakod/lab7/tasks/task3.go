package tasks

import (
	"fmt"
	"math/rand"
	"time"

	"github.com/tealeg/xlsx"
)

type SortObject struct {
	key int
}

// Сортировка Пузырьком O(n^2) Устойчивая
func bubbleSortTask3(arr []SortObject) {
	for i := 0; i < len(arr); i++ {
		for j := 0; j < len(arr)-1; j++ {
			if arr[j].key > arr[j+1].key {
				arr[j], arr[j+1] = arr[j+1], arr[j]
			}
		}
	}
}

// Сортировка Шейкер O(n^2)
func shakerSortTask3(arr []SortObject) {
	for i := 0; i < len(arr)/2; i++ {
		for j := i; j < len(arr)-i-1; j++ {
			if arr[j].key > arr[j+1].key {
				arr[j], arr[j+1] = arr[j+1], arr[j]
			}
		}
		for j := len(arr) - i - 2; j > i; j-- {
			if arr[j].key < arr[j-1].key {
				arr[j], arr[j-1] = arr[j-1], arr[j]
			}
		}
	}
}

// Сортировка Выбором O(n^2)
func selectionSortTask3(arr []SortObject) {
	for i := 0; i < len(arr); i++ {
		min := i
		for j := i + 1; j < len(arr); j++ {
			if arr[j].key < arr[min].key {
				min = j
			}
		}
		arr[i], arr[min] = arr[min], arr[i]
	}
}

// Сортировка Вставками
func insertionSortTask3(arr []SortObject) {
	for i := 1; i < len(arr); i++ {
		for j := i; j > 0 && arr[j-1].key > arr[j].key; j-- {
			arr[j], arr[j-1] = arr[j-1], arr[j]
		}
	}
}

// Сортировка Бинарными вставками
func binaryInsertionSortTask3(arr []SortObject) {
	for i := 1; i < len(arr); i++ {
		key := arr[i]
		left := 0
		right := i
		for left < right {
			mid := (left + right) / 2
			if key.key < arr[mid].key {
				right = mid
			} else {
				left = mid + 1
			}
		}
		for j := i; j > left; j-- {
			arr[j] = arr[j-1]
		}
		arr[left] = key
	}
}

func runBubbleSortTask3(arr []SortObject) int64 {
	start := time.Now()
	bubbleSortTask3(arr)
	return time.Since(start).Nanoseconds()
}

func runShakerSortTask3(arr []SortObject) int64 {
	start := time.Now()
	shakerSortTask3(arr)
	return time.Since(start).Nanoseconds()
}

func runSelectionSortTask3(arr []SortObject) int64 {
	start := time.Now()
	selectionSortTask3(arr)
	return time.Since(start).Nanoseconds()
}

func runInsertionSortTask3(arr []SortObject) int64 {
	start := time.Now()
	insertionSortTask3(arr)
	return time.Since(start).Nanoseconds()
}

func runBinaryInsertionSortTask3(arr []SortObject) int64 {
	start := time.Now()
	binaryInsertionSortTask3(arr)
	return time.Since(start).Nanoseconds()
}

// заполнение массива рандомными значениями
func fillArrayTask3(arr []SortObject) {
	rand.Seed(time.Now().UnixNano())
	for i := range arr {
		arr[i].key = rand.Intn(1000000)
	}
}

// reverseArrayTask3 - переворачивает массив
func reverseArrayTask3(arr []SortObject) {
	for i := 0; i < len(arr)/2; i++ {
		arr[i], arr[len(arr)-i-1] = arr[len(arr)-i-1], arr[i]
	}
}

func Task3() {
	var file *xlsx.File
	var sheet *xlsx.Sheet
	var row *xlsx.Row
	var cell *xlsx.Cell
	var err error

	var nCountArray []int = []int{5000, 10000, 20000, 20000, 20000}
	var nTasksArray [][]SortObject
	var tempArr []SortObject

	sortFuncMap := map[string]func([]SortObject) int64{
		"Пузырьком":           runBubbleSortTask3,
		"Шейкер":              runShakerSortTask3,
		"Выбором":             runSelectionSortTask3,
		"Вставками":           runInsertionSortTask3,
		"Бинарными вставками": runBinaryInsertionSortTask3,
	}
	sortFuncNames := []string{"Пузырьком", "Шейкер", "Выбором", "Вставками", "Бинарными вставками"}

	// Заполняю тестовые массивчики с данными
	for _, n := range nCountArray {
		tempArr = make([]SortObject, n)
		fillArrayTask3(tempArr)
		nTasksArray = append(nTasksArray, tempArr)
	}

	binaryInsertionSortTask3(nTasksArray[len(nTasksArray)-2])
	binaryInsertionSortTask3(nTasksArray[len(nTasksArray)-1])
	reverseArrayTask3(nTasksArray[len(nTasksArray)-1])

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
			var tempArray []SortObject = make([]SortObject, len(n))
			copy(tempArray, n)
			row.AddCell().Value = fmt.Sprintf("%v", sortFuncMap[funcName](tempArray))
		}
	}

	// Сохраняю файл
	err = file.Save("result3.xlsx")
	if err != nil {
		fmt.Print(err.Error())
	}
}
