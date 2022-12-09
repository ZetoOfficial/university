// Напишите процедуры нерекурсивных обходов бинарного дерева:
// a) префиксного;
// b) инфиксного;
// c) постфиксного;
// d) поуровневого. Указание: рекомендуется использовать FIFO-очередь.

package tasks

import "fmt"

// printTree(node.Right, prefix+"   ")
// fmt.Printf("%v[%v]\n", prefix, node.Value)
// printTree(node.Left, prefix+"   ")

// Процедура префиксного обхода бинарного дерева
func prefixTreeWalk(node *Node, prefix string) {
	if node != nil {
		fmt.Printf("%v[%v]\n", prefix, node.Value)
		prefixTreeWalk(node.Left, prefix+"   ")
		prefixTreeWalk(node.Right, prefix+"   ")
	}
}

// Процедура инфиксного обхода бинарного дерева
func infixTreeWalk(node *Node, prefix string) {
	if node != nil {
		infixTreeWalk(node.Left, prefix+"   ")
		fmt.Printf("%v[%v]\n", prefix, node.Value)
		infixTreeWalk(node.Right, prefix+"   ")
	}
}

// Процедура постфиксного обхода бинарного дерева
func postfixTreeWalk(node *Node, prefix string) {
	if node != nil {
		postfixTreeWalk(node.Left, prefix+"   ")
		postfixTreeWalk(node.Right, prefix+"   ")
		fmt.Printf("%v[%v]\n", prefix, node.Value)
	}
}

// Процедура поуровневого обхода бинарного дерева c использованием FIFO-очереди
func levelTreeWalk(node *Node) {
	if node != nil {
		var queue []*Node
		queue = append(queue, node)
		for len(queue) > 0 {
			node := queue[0]
			queue = queue[1:]
			fmt.Printf("[%v]", node.Value)
			if node.Left != nil {
				queue = append(queue, node.Left)
			}
			if node.Right != nil {
				queue = append(queue, node.Right)
			}
		}
	}
}

func Task3() {
	// Read data
	var nodes []string = ReadNodesFromFile("input.txt")

	// Build tree
	tree := buildBalancedTree(nodes, 0, len(nodes)-1)

	// Print prefix tree walk
	println("Prefix tree walk:")
	prefixTreeWalk(tree, "")

	// Print infix tree walk
	println("Infix tree walk:")
	infixTreeWalk(tree, "")

	// Print postfix tree walk
	println("Postfix tree walk:")
	postfixTreeWalk(tree, "")

	// Print level tree walk
	println("Level tree walk:")
	levelTreeWalk(tree)
}
