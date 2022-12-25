package tasks

import (
	"fmt"
	"math/rand"
	"time"
)

func hashFunc(x, n int) int {
	return (x + 23) % (n / 100)
}

type Chain struct {
	Key    int
	Next   *Chain
	Length int
}

type CHTable struct {
	Chains []*Chain
}

// insert into chain
// 1. Вычисляем хеш
// 2. Если элемента с таким хешем в массиве нет, то добавляем
// 3. Если элемент есть, то вставляем элемент в конце цепочки
// 4. Увеличиваем длину цепочки
func (hashTable *CHTable) Insert(x, n int) {
	hash := hashFunc(x, n)
	if hashTable.Chains[hash] == nil {
		hashTable.Chains[hash] = &Chain{Key: x, Length: 1}
	} else {
		chain := hashTable.Chains[hash]
		for chain.Next != nil {
			chain = chain.Next
		}
		chain.Next = &Chain{Key: x, Length: 1}
	}
	hashTable.Chains[hash].Length++
}

func (hashTable *CHTable) Print() {
	for i, chain := range hashTable.Chains {
		if chain != nil {
			fmt.Printf("%d: %d", i, chain.Key)
			for chain.Next != nil {
				chain = chain.Next
				fmt.Printf(" -> %d", chain.Key)
			}
			fmt.Println()
		}
	}
}

func (hashTable *CHTable) MinLength() (min int) {
	min = int(^uint(0) >> 1)
	for _, chain := range hashTable.Chains {
		if chain.Length < min {
			min = chain.Length
		}
	}
	return min
}

func (hashTable *CHTable) MaxLength() (max int) {
	max = 0
	for _, chain := range hashTable.Chains {
		if chain.Length > max {
			max = chain.Length
		}
	}
	return max
}

func Task1() {
	// a) Является ли данная хеш-функция совершенной?
	// (x + 23) % 13
	keys := []int{84, 72, 93, 25, 31, 85, 89, 185, 37, 81, 129, 301, 38, 434, 216, 312, 187, 234, 51}
	hashTable := CHTable{make([]*Chain, 13)}
	for _, x := range keys {
		hashTable.Insert(x, 13*100)
	}
	hashTable.Print()
	// Ответ: Нет, хеш функция не совершенна. Коллизии присутствуют
}

// 2) Напишите программу, которая с использованием хеширования с цепочками вставляет N случайных целых чисел в таблицу размером N/100, а затем определяет длину самого короткого и самого длинного списка (N = 5000, 10000, 20000).
func testTask2(n int) {
	hashTable := CHTable{make([]*Chain, n/100)}
	rand.Seed(time.Now().UnixNano())
	for i := 0; i < n; i++ {
		key := rand.Intn(1000)
		hashTable.Insert(key, n)
	}
	min := hashTable.MinLength()
	max := hashTable.MaxLength()
	fmt.Printf("n = %d, min = %d, max = %d\n", n, min, max)
}

func Task2() {
	testTask2(5000)
	testTask2(10000)
	testTask2(20000)
}
