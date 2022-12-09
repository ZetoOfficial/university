package tasks

// JosephusOnLinkedList	| Решить задачу Джозефа на основе связного списка
// N - количество человек
// M - номер человека, который будет убит
func JosephusOnLinkedList(N, M int) int {
	lst := LinkedList{}
	for i := 1; i <= N; i++ {
		lst.Insert(i)
	}
	lst.ToCircular()
	current := lst.head
	for lst.length != 1 {
		for i := 1; i < M; i++ {
			current = current.next
		}
		lst.Delete(current)
	}
	return current.key
}

// JosephusOnArray	| Решить задачу Джозефа на основе массива
func JosephusOnArray(N, M int) int {
	arr := make([]int, N)
	for i := 0; i < N; i++ {
		arr[i] = i + 1
	}
	cnt := 0
	for len(arr) != 1 {
		cnt = (cnt + M - 1) % len(arr)
		arr = append(arr[:cnt], arr[cnt+1:]...)
	}
	return arr[0]
}
