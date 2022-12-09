// 22 | reverse 		| Развернуть список [1,2,3,4] => [4,3,2,1]
// 29 | get min 		| Вернуть значение минимального элемента; если список пустой, то ошибка
// 06 | delete after	| Удаление элемента после заданного
// 13 | find			| Поиск элемента по значению
// 20 | repeat			| Создать уcountенный список (repeat([1, 2], 3) -> [1, 2, 1, 2, 1, 2])
// 27 | sublist_copy	| Создать список из элементов с индексами [from, to)

package tasks

import (
	"errors"
	"fmt"
)

type Node struct {
	prev *Node
	next *Node
	key  int
}

type LinkedList struct {
	head   *Node
	tail   *Node
	length int
}

func (l *LinkedList) IsEmpty() bool {
	return l.head == nil
}

func (l *LinkedList) Show() {
	list := l.head
	for list != nil {
		fmt.Printf("%+v", list.key)
		if list.next != nil {
			fmt.Printf("->")
		}
		list = list.next
	}
	fmt.Println()
}

func (l *LinkedList) InsertFirst(key int) {
	node := &Node{
		next: l.head,
		key:  key,
	}
	if l.head != nil {
		l.head.prev = node
	}
	l.head = node
	lastElement := l.head
	for lastElement.next != nil {
		lastElement = lastElement.next
	}
	l.tail = lastElement
	l.length++
}

func (l *LinkedList) Insert(key int) {
	if l.IsEmpty() {
		l.InsertFirst(key)
		return
	}
	node := l.head
	for node.next != nil {
		node = node.next
	}
	node.next = &Node{
		key: key,
	}
	l.length++
}

func (l *LinkedList) Reverse() {
	if l.IsEmpty() {
		return
	}
	current := l.head
	var prev *Node
	l.tail = l.head
	for current != nil {
		next := current.next
		current.next = prev
		prev, current = current, next
	}
	l.head = prev
}

// Minimum returns node with minimum value
func (l *LinkedList) Minimum() (*Node, error) {
	if l.IsEmpty() {
		return &Node{}, errors.New("empty list")
	}
	node := l.head
	minValue := l.head
	for node != nil {
		if minValue.key > node.key {
			minValue = node
		}
		node = node.next
	}
	return minValue, nil
}

func (l *LinkedList) Delete(node *Node) {
	if node == nil {
		return
	}
	if node.next != nil {
		node.key = node.next.key
		node.next = node.next.next
	} else {
		node = nil
	}
	l.length--
}

func (l *LinkedList) DeleteAfter(node *Node) {
	if node == nil {
		return
	}
	if node.next != nil {
		node.next = node.next.next
	}
	l.length--
}

func (l *LinkedList) Find(key int) (*Node, error) {
	if l.IsEmpty() {
		return nil, errors.New("empty list")
	}
	node := l.head
	for node != nil {
		if node.key == key {
			return node, nil
		}
		node = node.next
	}
	return nil, errors.New("not found")
}

// 20 | repeat | Создать уcountенный список (repeat([1, 2], 3) -> [1, 2, 1, 2, 1, 2])
func Repeat(lst []int, n int) (LinkedList, error) {
	newLst := LinkedList{}
	if len(lst) == 0 || n <= 0 {
		return newLst, nil
	}
	fmt.Printf("%v\n", lst)
	for i := 0; i < n; i++ {
		for _, e := range lst {
			fmt.Printf("%v ", e)
			newLst.Insert(e)
		}
		fmt.Println()
	}
	return newLst, nil
}

// 27 | SubList	| Создать список из элементов с индексами [from, to)
func (l *LinkedList) SubList(from, to int) (*LinkedList, error) {
	newLst := &LinkedList{}
	if !(from >= 0 && to <= l.length) {
		return nil, errors.New("index out of range")
	}
	cnt := 0

	list := l.head
	for list != nil {
		if cnt >= from && cnt <= to {
			newLst.Insert(list.key)
		}
		list = list.next
		cnt++
	}

	return newLst, nil
}

func (l *LinkedList) ToCircular() {
	current := l.head
	for current.next != nil {
		current = current.next
	}
	current.next = l.head
}
