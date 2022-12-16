package tasks

import "fmt"

type Node struct {
	Value int
	Left  *Node
	Right *Node
}

func Insert(root *Node, value int) *Node {
	if root == nil {
		return &Node{Value: value}
	}

	if value < root.Value {
		root.Left = Insert(root.Left, value)
	} else {
		root.Right = Insert(root.Right, value)
	}

	return root
}

func Delete(root *Node, value int) *Node {
	if root == nil {
		return nil
	}

	if value < root.Value {
		root.Left = Delete(root.Left, value)
	} else if value > root.Value {
		root.Right = Delete(root.Right, value)
	} else {
		if root.Left == nil {
			return root.Right
		} else if root.Right == nil {
			return root.Left
		}

		min := findMinInBST(root.Right)
		root.Value = min.Value
		root.Right = Delete(root.Right, min.Value)
	}

	return root
}

func findMinInBST(root *Node) *Node {
	if root == nil {
		return nil
	}

	if root.Left == nil {
		return root
	}

	return findMinInBST(root.Left)
}

func printTree(node *Node, prefix string) {
	if node != nil {
		printTree(node.Right, prefix+"    ")
		fmt.Printf("%v[%v]\n", prefix, node.Value)
		printTree(node.Left, prefix+"    ")
	}
}

// Построение дерева Фибоначчи порядка k без использования дополнительной памяти
func fibTree(k int) *Node {
	if k == 0 {
		return &Node{Value: 0}
	} else if k == 1 {
		return &Node{Value: 1}
	}

	left := fibTree(k - 1)
	right := fibTree(k - 2)
	return &Node{Value: left.Value + right.Value, Left: left, Right: right}
}

func Task1() {
	// var root *Node
	// root = Insert(root, 439)
	// root = Insert(root, 228)
	// root = Insert(root, 302)
	// root = Insert(root, 124)
	// root = Insert(root, 228)
	// root = Insert(root, 407)
	// root = Insert(root, 80)
	// root = Insert(root, 499)
	// root = Insert(root, 431)
	// root = Insert(root, 554)
	// root = Insert(root, 464)
	// root = Insert(root, 172)
	// root = Insert(root, 477)
	// root = Insert(root, 309)
	// root = Insert(root, 112)
	// root = Insert(root, 28)

	// printTree(root, "")

	// fmt.Println("Delete 439")
	// root = Delete(root, 439)
	// printTree(root, "")
	// fmt.Println("Delete 228")
	// root = Delete(root, 228)
	// printTree(root, "")
	// fmt.Println("Delete 302")
	// root = Delete(root, 302)
	// printTree(root, "")
	// fmt.Println("Delete 124")
	// root = Delete(root, 124)
	// printTree(root, "")
	// fmt.Println("Delete 228")
	// root = Delete(root, 228)
	// printTree(root, "")
	// fmt.Println("Delete 407")
	// root = Delete(root, 407)
	// printTree(root, "")
	// fmt.Println("Delete 80")
	// root = Delete(root, 80)
	// printTree(root, "")
	tree := fibTree(9)
	printTree(tree, "")
}
