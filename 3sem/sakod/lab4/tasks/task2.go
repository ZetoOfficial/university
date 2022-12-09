// 4. Напишите процедуру вычисления арифметического выражения в дереве, используя постфиксный обход.
// Пример арифметического выражения: ((1*2)+(3*4))
// Пример ответа: 14

package tasks

import (
	"fmt"
	"strconv"
	"unicode"
)

func Task2() {
	exp := "((1+2)*(3+4))"
	// exp := "(7-(2*3))"
	// exp := "((1*2)+(3*4))"

	// Build tree
	if !isValidArithmeticExpression(exp) {
		fmt.Println("Invalid arithmetic expression")
		return
	}
	tree := recursiveBuildTreeOfArithmeticExpression(exp)

	// Print tree
	printTree(tree, "")

	// Calculate
	fmt.Printf("Result: %v", calculateTree(tree))
}

// Алгоритм построения дерева для арифметического выражения с приоритетами операций
//
// Примеры арифметических выражений:
// ((1+2)*(3+4)); (7-(2*3))
func recursiveBuildTreeOfArithmeticExpression(exp string) *Node {
	if len(exp) == 0 {
		return nil
	}

	fmt.Println(exp)

	// Удаляем скобки в начале и конце выражения, если они единственные
	// Пример: ((1+2)*(3+4)) -> (1+2)*(3+4)
	// Пример: (1+2)*(3+4) -> (1+2)*(3+4)
	// Пример: (1+2) -> 1+2
	// Пример: 1+2 -> 1+2
	if exp[0] == '(' && exp[len(exp)-1] == ')' {
		// Проверяем, что скобки парные
		priority := 0
		for _, c := range exp {
			if c == '(' {
				priority++
			} else if c == ')' {
				priority--
			}
		}

		if priority == 0 {
			exp = exp[1 : len(exp)-1]
		}
	}

	// Ищем оператор с наименьшим приоритетом
	minPriority := 0
	minPriorityIndex := -1
	priority := 0
	for i, c := range exp {
		if c == '(' {
			priority++
		} else if c == ')' {
			priority--
		} else if isOperator(string(c)) {
			if minPriorityIndex == -1 || priority < minPriority {
				minPriority = priority
				minPriorityIndex = i
			}
		}
	}

	// Если оператор не найден, значит это число
	if minPriorityIndex == -1 {
		return &Node{Value: exp}
	}

	// Если оператор найден, то строим дерево
	node := &Node{Value: string(exp[minPriorityIndex])}
	node.Left = recursiveBuildTreeOfArithmeticExpression(exp[:minPriorityIndex])
	node.Right = recursiveBuildTreeOfArithmeticExpression(exp[minPriorityIndex+1:])

	return node
}

func isOperator(node string) bool {
	return node == "+" || node == "-" || node == "*" || node == "/"
}

// Подсчет результата арифметического выражения в дереве
func calculateTree(node *Node) int {
	if node == nil {
		return 0
	}

	if node.Left == nil && node.Right == nil {
		result, _ := strconv.Atoi(node.Value)
		return result
	}

	left := calculateTree(node.Left)
	right := calculateTree(node.Right)

	switch node.Value {
	case "+":
		return left + right
	case "-":
		return left - right
	case "*":
		return left * right
	case "/":
		return left / right
	}

	return 0
}

// Проверка арифметического выражения на валидность
// Валидным считается выражение, состоящее только из цифр, скобок и операторов
// Валидным считается выражение, в котором скобки парные
// Валидным считается выражение, в котором операторы расставлены правильно
// Валидным считается выражение, в котором нет лишних скобок
func isValidArithmeticExpression(s string) bool {
	// Проверяем, что строка не пустая
	if len(s) == 0 {
		return false
	}

	// Проверяем, что строка состоит только из цифр, скобок и операторов
	for _, c := range s {
		if !unicode.IsDigit(c) && c != '(' && c != ')' && c != '+' && c != '-' && c != '*' && c != '/' {
			return false
		}
	}

	// Проверяем, что скобки расставлены правильно
	left := 0
	right := 0
	for _, c := range s {
		if c == '(' {
			left++
		} else if c == ')' {
			right++
		}
	}
	if left != right {
		return false
	}

	// Проверяем, что операторы расставлены правильно
	// Правильно расставленными будем считать операторы, которые не стоят в начале и в конце строки
	// и не стоят рядом друг с другом
	for i := 0; i < len(s); i++ {
		if isOperator(string(s[i])) {
			if i == 0 || i == len(s)-1 {
				return false
			}

			if isOperator(string(s[i-1])) || isOperator(string(s[i+1])) {
				return false
			}
		}
	}

	return true
}
