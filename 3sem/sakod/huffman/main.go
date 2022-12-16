package main

import "fmt"

// Дерево хаффмана
type Tree struct {
	// Левый и правый потомки
	Left, Right *Tree
	// Частота символа
	Freq int
	// Символ
	Char rune
}

// Создание дерева
func NewTree(freq int, char rune, left, right *Tree) *Tree {
	return &Tree{left, right, freq, char}
}

// Проверка, является ли узел листом
func (t *Tree) IsLeaf() bool {
	return t.Left == nil && t.Right == nil
}

// Сортировка деревьев по частоте
func SortTrees(trees []*Tree) {
	for i := 0; i < len(trees); i++ {
		for j := i + 1; j < len(trees); j++ {
			if trees[i].Freq > trees[j].Freq {
				trees[i], trees[j] = trees[j], trees[i]
			}
		}
	}
}

// Построение дерева
func BuildTree(freqs map[rune]int) *Tree {
	// Создание деревьев
	var trees []*Tree
	for char, freq := range freqs {
		trees = append(trees, NewTree(freq, char, nil, nil))
	}

	// Сортировка деревьев
	SortTrees(trees)

	// Построение дерева
	for len(trees) > 1 {
		// Выбор двух деревьев с наименьшей частотой
		a, b := trees[0], trees[1]
		// Создание нового дерева
		trees = append(trees[2:], NewTree(a.Freq+b.Freq, 0, a, b))
		// Сортировка деревьев
		SortTrees(trees)
	}

	// Возвращение дерева
	return trees[0]
}

// Построение таблицы кодов
func BuildCodeTable(tree *Tree) map[rune]string {
	// Создание таблицы кодов
	table := make(map[rune]string)

	// Построение таблицы кодов
	var buildCodeTable func(*Tree, string)
	buildCodeTable = func(tree *Tree, code string) {
		if tree.IsLeaf() {
			table[tree.Char] = code
		} else {
			buildCodeTable(tree.Left, code+"0")
			buildCodeTable(tree.Right, code+"1")
		}
	}
	buildCodeTable(tree, "")

	// Возвращение таблицы кодов
	return table
}

// Кодирование текста
func Encode(text string, table map[rune]string) string {
	// Кодирование текста
	var encoded string
	for _, char := range text {
		encoded += table[char]
	}

	// Возвращение кодированного текста
	return encoded
}

// Декодирование текста
func Decode(encoded string, tree *Tree) string {
	// Декодирование текста
	var decoded string
	var node *Tree = tree
	for _, char := range encoded {
		if char == '0' {
			node = node.Left
		} else {
			node = node.Right
		}
		if node.IsLeaf() {
			decoded += string(node.Char)
			node = tree
		}
	}

	// Возвращение декодированного текста
	return decoded
}

// Подсчет частот символов
func CountFrequencies(text string) map[rune]int {
	// Создание таблицы частот
	freqs := make(map[rune]int)

	// Подсчет частот символов
	for _, char := range text {
		freqs[char]++
	}

	// Возвращение таблицы частот
	return freqs
}

// Длина внутреннего пути бинарного дерева
func (tree *Tree) InternalPathLength() int {
	// Подсчет длины внутреннего пути дерева
	var internalPathLength func(*Tree, int) int
	internalPathLength = func(tree *Tree, level int) int {
		if tree == nil {
			return 0
		}
		if tree.IsLeaf() {
			return 0
		}
		return level + internalPathLength(tree.Left, level+1) + internalPathLength(tree.Right, level+1)
	}

	// Возвращение длины внутреннего пути дерева
	return internalPathLength(tree, 0)
}

// Высота бинарного дерева
func (tree *Tree) Height() int {
	// Подсчет высоты дерева
	var height func(*Tree) int
	height = func(tree *Tree) int {
		if tree == nil {
			return 0
		}
		if tree.IsLeaf() {
			return 0
		}
		leftHeight := height(tree.Left)
		rightHeight := height(tree.Right)
		if leftHeight > rightHeight {
			return leftHeight + 1
		}
		return rightHeight + 1
	}

	// Возвращение высоты дерева
	return height(tree)
}

// Длина внешнего пути бинарного дерева
func (tree *Tree) ExternalPathLength() int {
	// Подсчет длины внешнего пути дерева
	var externalPathLength func(*Tree, int) int
	externalPathLength = func(tree *Tree, level int) int {
		if tree == nil {
			return 0
		}
		if tree.IsLeaf() {
			return level
		}
		return externalPathLength(tree.Left, level+1) + externalPathLength(tree.Right, level+1)
	}

	// Возвращение длины внешнего пути дерева
	return externalPathLength(tree, 0)
}

func printTree(tree *Tree, level int) {
	if tree == nil {
		return
	}
	printTree(tree.Right, level+1)
	for i := 0; i < level; i++ {
		fmt.Print("  ")
	}
	symbol := tree.Char
	if symbol != 0 {
		fmt.Printf("'%v' %v\n", string(symbol), tree.Freq)
	} else {
		fmt.Printf("%v\n", tree.Freq)
	}
	printTree(tree.Left, level+1)
}

// Проверка кодирования и декодирования
func Test(text string) {
	// Подсчет частот символов
	freqs := CountFrequencies(text)
	fmt.Println(freqs)
	// Построение дерева
	tree := BuildTree(freqs)
	// Длина внутреннего пути
	fmt.Println("Internal path length:", tree.InternalPathLength())
	// Высота дерева
	fmt.Println("Height:", tree.Height())
	// Длина внешнего пути
	fmt.Println("External path length:", tree.ExternalPathLength())
	// Построение таблицы кодов
	table := BuildCodeTable(tree)
	fmt.Println(table)
	// Кодирование текста
	encoded := Encode(text, table)
	// Декодирование текста
	// decoded := Decode(encoded, tree)

	// Вывод результатов
	fmt.Println("Text:", text)
	fmt.Println("Encoded:", encoded)
	// fmt.Println("Decoded:", decoded)
}

func main() {
	Test("Коллеги, суета. Сегодня пары по САКОДу не будет")
}
