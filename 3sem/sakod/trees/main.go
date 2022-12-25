package main

import (
	"fmt"
	"trees/tasks"
)

func main() {
	// keys 12 8 7 3 11 15 14 13 19 2 4 6 5 10 9 17 16 1 20 18
	keys := []int{12, 8, 7, 3, 11, 15, 14, 13, 19, 2, 4, 6, 5, 10, 9, 17, 16, 1, 20, 18}

	bst := tasks.BSTree{}
	for _, key := range keys {
		bst.Insert(key)
	}
	fmt.Println("BST:")
	bst.Root.PrintTree("")

	avl := tasks.AVLTree{}
	for _, key := range keys {
		avl.Insert(key)
	}
	fmt.Println("AVL:")
	avl.Root.PrintTree("")
}
