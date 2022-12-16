package tasks

import "fmt"

// АВЛ дерево
// 1. Реализовать функцию вставки в АВЛ дерево
// 2. Реализовать функцию удаления из АВЛ дерева

type AVLNode struct {
	Value  int
	Left   *AVLNode
	Right  *AVLNode
	Height int
}

func AVLInsert(root *AVLNode, value int) *AVLNode {
	if root == nil {
		return &AVLNode{Value: value}
	}

	if value < root.Value {
		root.Left = AVLInsert(root.Left, value)
	} else {
		root.Right = AVLInsert(root.Right, value)
	}

	root.Height = 1 + max(height(root.Left), height(root.Right))

	balance := getBalance(root)

	if balance > 1 && value < root.Left.Value {
		return rightRotate(root)
	}

	if balance < -1 && value > root.Right.Value {
		return leftRotate(root)
	}

	if balance > 1 && value > root.Left.Value {
		root.Left = leftRotate(root.Left)
		return rightRotate(root)
	}

	if balance < -1 && value < root.Right.Value {
		root.Right = rightRotate(root.Right)
		return leftRotate(root)
	}

	return root
}

func AVLDelete(root *AVLNode, value int) *AVLNode {
	if root == nil {
		return nil
	}

	if value < root.Value {
		root.Left = AVLDelete(root.Left, value)
	} else if value > root.Value {
		root.Right = AVLDelete(root.Right, value)
	} else {
		if root.Left == nil {
			return root.Right
		} else if root.Right == nil {
			return root.Left
		}

		min := findMinInAVL(root.Right)
		root.Value = min.Value
		root.Right = AVLDelete(root.Right, min.Value)
	}

	root.Height = 1 + max(height(root.Left), height(root.Right))

	balance := getBalance(root)

	if balance > 1 && getBalance(root.Left) >= 0 {
		return rightRotate(root)
	}

	if balance > 1 && getBalance(root.Left) < 0 {
		root.Left = leftRotate(root.Left)
		return rightRotate(root)
	}

	if balance < -1 && getBalance(root.Right) <= 0 {
		return leftRotate(root)
	}

	if balance < -1 && getBalance(root.Right) > 0 {
		root.Right = rightRotate(root.Right)
		return leftRotate(root)
	}

	return root
}

func findMinInAVL(root *AVLNode) *AVLNode {
	if root == nil {
		return nil
	}

	if root.Left == nil {
		return root
	}

	return findMinInAVL(root.Left)
}

func height(root *AVLNode) int {
	if root == nil {
		return 0
	}

	return root.Height
}

func max(a, b int) int {
	if a > b {
		return a
	}

	return b
}

func getBalance(root *AVLNode) int {
	if root == nil {
		return 0
	}

	return height(root.Left) - height(root.Right)
}

func rightRotate(root *AVLNode) *AVLNode {
	left := root.Left
	right := left.Right

	left.Right = root
	root.Left = right

	root.Height = 1 + max(height(root.Left), height(root.Right))
	left.Height = 1 + max(height(left.Left), height(left.Right))

	return left
}

func leftRotate(root *AVLNode) *AVLNode {
	right := root.Right
	left := right.Left

	right.Left = root
	root.Right = left

	root.Height = 1 + max(height(root.Left), height(root.Right))
	right.Height = 1 + max(height(right.Left), height(right.Right))

	return right
}

func printAVLTree(root *AVLNode, prefix string) {
	if root != nil {
		printAVLTree(root.Right, prefix+"    ")
		fmt.Printf("%v[%v]\n", prefix, root.Value)
		printAVLTree(root.Left, prefix+"    ")
	}
}

func Task2() {
	var root *AVLNode

	root = AVLInsert(root, 439)
	root = AVLInsert(root, 228)
	root = AVLInsert(root, 302)
	root = AVLInsert(root, 124)
	root = AVLInsert(root, 228)
	root = AVLInsert(root, 407)
	root = AVLInsert(root, 80)
	root = AVLInsert(root, 499)
	root = AVLInsert(root, 431)
	root = AVLInsert(root, 554)
	root = AVLInsert(root, 464)
	root = AVLInsert(root, 172)
	root = AVLInsert(root, 477)
	root = AVLInsert(root, 309)
	root = AVLInsert(root, 112)
	root = AVLInsert(root, 28)

	printAVLTree(root, "")

	fmt.Println("AVLDelete 439")
	root = AVLDelete(root, 439)
	printAVLTree(root, "")
	fmt.Println("AVLDelete 228")
	root = AVLDelete(root, 228)
	printAVLTree(root, "")
	fmt.Println("AVLDelete 302")
	root = AVLDelete(root, 302)
	printAVLTree(root, "")
	fmt.Println("AVLDelete 124")
	root = AVLDelete(root, 124)
	printAVLTree(root, "")
	fmt.Println("AVLDelete 228")
	root = AVLDelete(root, 228)
	printAVLTree(root, "")
	fmt.Println("AVLDelete 407")
	root = AVLDelete(root, 407)
	printAVLTree(root, "")
	fmt.Println("AVLDelete 80")
	root = AVLDelete(root, 80)
	printAVLTree(root, "")
}
