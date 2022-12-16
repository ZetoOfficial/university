// 1. Напишите рекурсивную процедуру построения идеально сбалансированного дерева для произвольных N узлов, хранящихся в файле.

package tasks

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

type Node struct {
	Value string
	Left  *Node
	Right *Node
}

func buildBalancedTree(nodes []string, start int, end int) *Node {
	if start > end {
		return nil
	}

	mid := (start + end) / 2
	node := &Node{Value: nodes[mid]}
	node.Left = buildBalancedTree(nodes, start, mid-1)
	node.Right = buildBalancedTree(nodes, mid+1, end)

	return node
}

func printTree(node *Node, prefix string) {
	if node != nil {
		printTree(node.Right, prefix+"   ")
		fmt.Printf("%v[%v]\n", prefix, node.Value)
		printTree(node.Left, prefix+"   ")
	}
}

func Task1() {
	var nodes []string = ReadNodesFromFile("input.txt")

	tree := buildBalancedTree(nodes, 0, len(nodes)-1)

	printTree(tree, "")
}

func ReadNodesFromFile(filename string) []string {
	// example file content: 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
	var nodes []string

	// Open file
	file, err := os.Open(filename)
	if err != nil {
		fmt.Println("Error opening file:", err)
		return nodes
	}
	defer file.Close()

	// Read file
	scanner := bufio.NewScanner(file)
	for scanner.Scan() {
		line := scanner.Text()
		line = strings.TrimSpace(line)
		nodes = strings.Split(line, " ")
	}

	if scanner.Err() != nil {
		fmt.Println("Error reading file:", err)
	}

	return nodes
}
