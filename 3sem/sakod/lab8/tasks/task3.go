package tasks

// Рекурсивная реализация быстрой сортировки
func QuickSort(arr []int) []int {
	if len(arr) < 2 {
		return arr
	}
	left, right := 0, len(arr)-1
	pivot := arr[left]
	for i := 1; i <= right; {
		if arr[i] < pivot {
			arr[left], arr[i] = arr[i], arr[left]
			left++
			i++
		} else {
			arr[i], arr[right] = arr[right], arr[i]
			right--
		}
	}
	QuickSort(arr[:left])
	QuickSort(arr[left+1:])
	return arr
}

// Комбинированная реализация быстрой сортировки
// используйте метод простых вставок для сортировки массивов длины, меньшей M.
func QuickSortCombo(arr []int, m int) []int {
	if len(arr) < 2 {
		return arr
	}
	if len(arr) < m {
		return InsertionSort(arr)
	}
	return QuickSort(arr)
}

// Сортировка простыми вставками
func InsertionSort(arr []int) []int {
	for i := 1; i < len(arr); i++ {
		for j := i; j > 0 && arr[j-1] > arr[j]; j-- {
			arr[j-1], arr[j] = arr[j], arr[j-1]
		}
	}
	return arr
}
