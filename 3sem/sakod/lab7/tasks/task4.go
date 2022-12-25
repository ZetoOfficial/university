package tasks

import (
	"fmt"
	"time"

	"github.com/tealeg/xlsx"
)

// Сортировка Шелла
func ShellSort(arr []int, step int) {
	for i := step; i < len(arr); i++ {
		for j := i; j >= step && arr[j-step] > arr[j]; j -= step {
			arr[j], arr[j-step] = arr[j-step], arr[j]
		}
	}
}

func runShellSortTask4(arr []int, step int) int64 {
	start := time.Now()
	ShellSort(arr, step)
	return time.Since(start).Nanoseconds()
}

func Task4() {
	var file *xlsx.File
	var sheet *xlsx.Sheet
	var row *xlsx.Row
	var cell *xlsx.Cell
	var err error

	var nCountArray []int = []int{25000, 50000, 100000}
	var nTasksArray [][]int
	var tempArr []int

	// Заполняю тестовые массивчики с данными
	for _, n := range nCountArray {
		tempArr = make([]int, n)
		fillArrayTask2(tempArr)
		nTasksArray = append(nTasksArray, tempArr)
	}

	// Создаю файл
	file = xlsx.NewFile()
	sheet, err = file.AddSheet("Sheet1")
	if err != nil {
		fmt.Print(err.Error())
	}

	colNames := []string{"SortName"}
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
	for _, step := range []int{1, 5, 19, 41} {
		time.Sleep(time.Duration(1))
		row = sheet.AddRow()
		row.AddCell().Value = fmt.Sprintf("step = %v", step)
		for _, n := range nTasksArray {
			var tempArray []int = make([]int, len(n))
			copy(tempArray, n)
			row.AddCell().Value = fmt.Sprintf("%v", runShellSortTask4(tempArray, step))
		}
	}

	// Сохраняю файл
	err = file.Save("result4.xlsx")
	if err != nil {
		fmt.Print(err.Error())
	}
}
