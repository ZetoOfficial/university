package tasks

import "errors"

type PriorityInsertQueue struct {
	elem []int
	top  int
}

func (q *PriorityInsertQueue) IsEmpty() bool {
	return q.top == 0
}

func (q *PriorityInsertQueue) PriorityInsert(key int) {
	q.elem = append(q.elem, key)
	q.top++

	for i := q.top - 1; i > 0; i-- {
		if q.elem[i] > q.elem[i-1] {
			q.elem[i], q.elem[i-1] = q.elem[i-1], q.elem[i]
		} else {
			break
		}
	}
}

func (q *PriorityInsertQueue) Delete() (int, error) {
	if q.IsEmpty() {
		return 0, errors.New("queue is empty")
	}
	q.top--
	return q.elem[q.top], nil
}

type PriorityDeleteQueue struct {
	elem []int
	top  int
}

func (q *PriorityDeleteQueue) IsEmpty() bool {
	return q.top == 0
}

func (q *PriorityDeleteQueue) Insert(key int) {
	q.elem = append(q.elem, key)
	q.top++
}

func (q *PriorityDeleteQueue) PriorityDelete() (int, error) {
	if q.IsEmpty() {
		return 0, errors.New("queue is empty")
	}
	max := 0
	for i := 1; i < q.top; i++ {
		if q.elem[i] > q.elem[max] {
			max = i
		}
	}
	q.elem[max] = q.elem[q.top-1]
	q.top--
	return q.elem[q.top], nil
}
