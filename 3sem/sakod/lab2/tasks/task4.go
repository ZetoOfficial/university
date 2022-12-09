// (4 балла) На квадратной доске расставлены целые неотрицательные числа.
// Черепашка, находящаяся в левом верхнем углу, мечтает попасть в правый нижний.
// При этом она может переползать только в клетку справа или снизу и хочет, чтобы сумма всех чисел, оказавшихся у нее на пути,
// была бы максимальной. Напишите программу, которая определяет эту сумму.
// Указания.
// 1). Используйте метод динамического программирования
// 2). Размер доски и числа на доске считывайте из файла.

package tasks

import (
	"fmt"
)

func Turtle(v int, arr [][]int) int { // O(N*V)
	arrCollected := make([][]int, v+1)
	for i := 0; i <= v; i++ {
		arrCollected[i] = make([]int, v+1)
	}

	for i := 1; i <= v; i++ {
		for j := 1; j <= v; j++ {
			arrCollected[i][j] = arr[i-1][j-1] + Max(arrCollected[i-1][j], arrCollected[i][j-1])
		}
	}
	return arrCollected[v][v]
}

func Task4() {
	V, arr := LoadDataFromFile("input.txt")
	answer := Turtle(V, arr)
	fmt.Println(answer)
}
