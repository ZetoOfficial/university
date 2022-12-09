// (2 балла) Сравните время вычисления 35-го числа Фибоначчи при помощи
// формулы Бине,
// итерационной формулы,
// метода «разделяй и властвуй»,
// метода нисходящего динамического программирования,
// метода восходящего динамического программирования.

// 50 shates of golang
package tasks

import (
	"fmt"
	"math"
)

func Bine(n int) int { // O(1)
	var part1 = math.Pow((1+math.Sqrt(5))/2, float64(n))
	var part2 = math.Pow((1-math.Sqrt(5))/2, float64(n))
	return int((part1 - part2) / math.Sqrt(5))
}

func Iterative(n int) int { // O(n)
	// Простой итерационный цикл без вспомогательного массива
	// запоминая два последних вычислительных значения
	var x, y = 0, 1
	for i := 0; i < n; i++ {
		x, y = y, x+y
	}
	return x
}

func DivideAndConquer(n int) int { // O(2^N)
	// Метод "разделяй и властвуй"
	if n == 0 {
		return 0
	} else if n == 1 {
		return 1
	} else {
		return DivideAndConquer(n-1) + DivideAndConquer(n-2)
	}
}

var DTopDown []int

func TopDownApproach(n int) int { // O(2^N)
	// Нисходящее программирование
	if DTopDown[n] == 0 {
		if n == 0 {
			DTopDown[n] = 0
		} else if n == 1 {
			DTopDown[n] = 1
		} else {
			DTopDown[n] = TopDownApproach(n-1) + TopDownApproach(n-2)
		}
	}
	return DTopDown[n]
}

func BottomUpApproach(n int) int { // O(N)
	// Восходящее программирование
	var DBottomUp []int
	DBottomUp[0], DBottomUp[1] = 0, 1
	for i := 2; i <= n; i++ {
		DBottomUp[i] = DBottomUp[i-1] + DBottomUp[i-2]
	}
	return DBottomUp[n]
}

func EmptyTrack() {
	defer Timer("test")()
	fmt.Printf("")
}

func BineTrack(n int) {
	defer Timer("Bine")()
	Bine(n)
}

func IterativeTrack(n int) {
	defer Timer("Iterative")()
	Iterative(n)
}

func DivideAndConquerTrack(n int) {
	defer Timer("DivideAndConquer")()
	DivideAndConquer(n)
}

func TopDownTrack(n int) {
	defer Timer("TopDown")()
	TopDownApproach(n)
}

func BottomUpTrack(n int) {
	defer Timer("BottomUp")()
	BottomUpApproach(n)
}

func Task1(n int) {
	EmptyTrack()
	BineTrack(n)
	// IterativeTrack(n)
	// DivideAndConquerTrack(n)
	// TopDownTrack(n)
	// BottomUpTrack(n)
}
