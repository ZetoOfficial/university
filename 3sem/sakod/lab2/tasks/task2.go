// (2 балла) Напишите реализацию задачи о рюкзаке методом восходящего динамического программирования.

package tasks

import "fmt"

type cell struct {
	items []item
	cost  int
}

type item struct {
	cost int
	size int
}

func Knap(items []item, capacity int) cell {
	// Оценка: O(N*Capacity)
	costTable := make([][]cell, len(items)+1)
	for i := range costTable {
		costTable[i] = make([]cell, capacity+1)
	}
	for i := 1; i <= len(items); i++ {
		for j := 1; j <= capacity; j++ {
			// На случай, если вес текущей вещи больше вместимости текущего рюкзака
			if items[i-1].size > j {
				costTable[i][j] = costTable[i-1][j]
			} else {
				lastMaxCost := costTable[i-1][j].cost
				// Current item cost + remaining space cost (cell[i-1][j-item.size])
				maxAvailableCost := (costTable[i-1][j-items[i-1].size]).cost + items[i-1].cost
				if lastMaxCost > maxAvailableCost {
					costTable[i][j] = costTable[i-1][j]
				} else {
					var items = append((costTable[i-1][j-items[i-1].size]).items, items[i-1])
					costTable[i][j] = cell{items: items, cost: maxAvailableCost}
				}
				// costTable[i][j] = Max(lastMaxCost, maxAvailableCost)
			}
		}
	}
	return costTable[len(items)][capacity]
}

func Task2() {
	items := []item{
		{cost: 3000, size: 43},
		{cost: 2000, size: 33},
		{cost: 45000000000000, size: 111},
		{cost: 5500, size: 14},
		{cost: 6500, size: 31},
		{cost: 6500, size: 51},

		{cost: 21500, size: 21},
		{cost: 13500, size: 21},
		{cost: 11500, size: 13},
	}
	result := Knap(items, 50)
	fmt.Printf("Answer for 50: %v", result)
}
