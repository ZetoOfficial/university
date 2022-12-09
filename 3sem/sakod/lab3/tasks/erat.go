package tasks

// EratOnLinkedList	| Решить задачу Эратосфена на основе связного списка
func EratOnLinkedList(N int) LinkedList {
	lst := LinkedList{}
	for i := 2; i <= N; i++ {
		lst.Insert(i)
	}
	current := lst.head
	for current != nil {
		for i := 2; i <= N; i++ {
			if current.key*i > N {
				break
			}
			node, err := lst.Find(current.key * i)
			if err != nil {
				continue
			}
			lst.Delete(node)
		}
		current = current.next
	}
	return lst
}

// EratOnArray	| Решить задачу Эратосфена на основе массива
func EratOnArray(N int) []int {
	arr := make([]int, 0)
	for i := 2; i <= N; i++ {
		arr = append(arr, i)
	}
	for i := 0; i < len(arr); i++ {
		for j := i + 1; j < len(arr); j++ {
			if arr[j]%arr[i] == 0 {
				arr = append(arr[:j], arr[j+1:]...)
				j--
			}
		}
	}
	return arr
}
