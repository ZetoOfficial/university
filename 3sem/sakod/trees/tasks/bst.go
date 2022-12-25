package tasks

import "fmt"

type BSTree struct {
	Root *BSTNode
}

type BSTNode struct {
	Value       int
	Left, Right *BSTNode
}

func (bst *BSTree) Insert(data int) {
	if bst.Root == nil {
		bst.Root = &BSTNode{Value: data}
		return
	}
	bst.Root.insert(data)
}

func (node *BSTNode) insert(data int) {
	if data < node.Value {
		if node.Left == nil {
			node.Left = &BSTNode{Value: data}
			return
		}
		node.Left.insert(data)
	} else {
		if node.Right == nil {
			node.Right = &BSTNode{Value: data}
			return
		}
		node.Right.insert(data)
	}
}

func (node *BSTNode) PrintTree(prefix string) {
	if node != nil {
		node.Right.PrintTree(prefix + "\t")
		fmt.Printf("%v[%v]\n", prefix, node.Value)
		node.Left.PrintTree(prefix + "\t")
	}
}
