package tasks

type OAHTable struct {
	elements []*int
}

var m int

func (hashTable *OAHTable) Init() {
	hashTable.elements = make([]*int, m)
}

func hash(x int) int {
	return (x + 23) % m
}

func lineHash(x, i int) int {
	return (hash(x) + i) % m
}

func quadraticHash(x, i int) int {
	return (hash(x) + i + i*i) % m
}

func doubleHash(x, i int) int {
	return (hash(x) + hash(x)*i) % m
}

func (hashTable *OAHTable) lineHashInsert(x int) {
	i := 0
	for hashTable.elements[lineHash(x, i)] != nil {
		i++
	}
	hashTable.elements[lineHash(x, i)] = &x
}
func (hashTable *OAHTable) quadraticHashInsert(x int) {
	i := 0
	for quadraticHash(x, i) > m && hashTable.elements[quadraticHash(x, i)] != nil {
		i++
	}
	hashTable.elements[quadraticHash(x, i)] = &x
}
func (hashTable *OAHTable) doubleHashInsert(x int) {
	i := 0
	for doubleHash(x, i) > m && hashTable.elements[doubleHash(x, i)] != nil {
		i++
	}
	hashTable.elements[doubleHash(x, i)] = &x
}

func (hashTable *OAHTable) Print() {
	for i, element := range hashTable.elements {
		if element != nil {
			println(i, *element)
		} else {
			println(i, "nil")
		}
	}
}

// линейное хеширование
func LinearHashing() {
	hashTable := OAHTable{}
	keys := []int{84, 72, 93, 25, 31, 85, 89, 185, 37, 81, 129, 301, 38, 434, 216, 312, 187, 234, 51}
	m = len(keys) + 1
	hashTable.Init()
	for _, x := range keys {
		hashTable.lineHashInsert(x)
	}
	hashTable.Print()
}

// квадратичное хеширование
func QuadraticHashing() {
	hashTable := OAHTable{}
	keys := []int{84, 72, 93, 25, 31, 85, 89, 185, 37, 81, 129, 301, 38, 434, 216, 312, 187, 234, 51}
	m = len(keys) + 1
	hashTable.Init()
	for _, x := range keys {
		hashTable.quadraticHashInsert(x)
	}
	hashTable.Print()
}

// двойное хеширование
func DoubleHashing() {
	hashTable := OAHTable{}
	keys := []int{84, 72, 93, 25, 31, 85, 89, 185, 37, 81, 129, 301, 38, 434, 216, 312, 187, 234, 51}
	m = len(keys) + 1
	hashTable.Init()
	for _, x := range keys {
		hashTable.doubleHashInsert(x)
	}
	hashTable.Print()
}
