package tasks

import "fmt"

type AVLTree struct {
	Root *AVLNode
}

type AVLNode struct {
	Value       int
	Left, Right *AVLNode
	Height      int
}

func (node *AVLNode) Balance() int {
	if node == nil {
		return 0
	}
	leftHeight := 0
	if node.Left != nil {
		leftHeight = node.Left.Height
	}
	rightHeight := 0
	if node.Right != nil {
		rightHeight = node.Right.Height
	}
	return leftHeight - rightHeight
}

func (node *AVLNode) UpdateHeight() {
	if node == nil {
		return
	}
	leftHeight := 0
	if node.Left != nil {
		leftHeight = node.Left.Height
	}
	rightHeight := 0
	if node.Right != nil {
		rightHeight = node.Right.Height
	}
	if leftHeight > rightHeight {
		node.Height = leftHeight + 1
	} else {
		node.Height = rightHeight + 1
	}
}

func (node *AVLNode) RotateRight() *AVLNode {
	newRoot := node.Left
	node.Left = newRoot.Right
	newRoot.Right = node
	node.UpdateHeight()
	newRoot.UpdateHeight()
	return newRoot
}

func (node *AVLNode) RotateLeft() *AVLNode {
	newRoot := node.Right
	node.Right = newRoot.Left
	newRoot.Left = node
	node.UpdateHeight()
	newRoot.UpdateHeight()
	return newRoot
}

func (node *AVLNode) BalanceTree() *AVLNode {
	node.UpdateHeight()
	if node.Balance() == 2 {
		if node.Left.Balance() < 0 {
			node.Left = node.Left.RotateLeft()
		}
		return node.RotateRight()
	}
	if node.Balance() == -2 {
		if node.Right.Balance() > 0 {
			node.Right = node.Right.RotateRight()
		}
		return node.RotateLeft()
	}
	return node
}

func (tree *AVLTree) Insert(data int) {
	tree.Root = tree.Root.insert(data)
}

func (node *AVLNode) insert(data int) *AVLNode {
	if node == nil {
		return &AVLNode{Value: data, Height: 1}
	}
	if data < node.Value {
		node.Left = node.Left.insert(data)
	} else {
		node.Right = node.Right.insert(data)
	}
	return node.BalanceTree()
}

func (node *AVLNode) PrintTree(prefix string) {
	if node != nil {
		node.Right.PrintTree(prefix + "\t")
		fmt.Printf("%v[%v]\n", prefix, node.Value)
		node.Left.PrintTree(prefix + "\t")
	}
}
