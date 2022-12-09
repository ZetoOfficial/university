// (1 балл) Решите задачу о Ханойской башне.

package tasks

import "fmt"

func hanoi(n, a, b int) { // O(2^N)
	var c int
	if n == 1 {
		fmt.Printf("Переместили бублик %v весом 1 -> %v\n", a, b)
	} else {
		c = 6 - a - b // 6 - сумма номеров стержней
		hanoi(n-1, a, c)
		fmt.Printf("Переместили бублик %v -> %v\n", a, b)
		hanoi(n-1, c, b)
	}
}

func Task3(n int) {
	hanoi(n, 1, 2)
}
