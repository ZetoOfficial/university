// Смоделируйте ситуацию обслуживания клиентов в банке.
// Клиенты, случайным образом помещаются в одну из M очередей обслуживания.
// Случайным образом выбирается одна из очередей, и клиент обслуживается (выбывает из очереди).
// При каждой операции указывайте номер добавленного клиента, номер обслуженного клиента, и состояние очередей.

// Path: tasks/banktask.go

package tasks

import (
	"fmt"
	"math/rand"
	"time"
)

type Client struct {
	id int
}

type Queue struct {
	clients []Client
}

func (q *Queue) IsEmpty() bool {
	return len(q.clients) == 0
}

func (q *Queue) Insert(client Client) {
	q.clients = append(q.clients, client)
}

func (q *Queue) Delete() (Client, error) {
	if q.IsEmpty() {
		return Client{}, fmt.Errorf("queue is empty")
	}
	client := q.clients[0]
	q.clients = q.clients[1:]
	return client, nil
}

func (q *Queue) Print() {
	for _, client := range q.clients {
		fmt.Printf("%d ", client.id)
	}
	fmt.Println()
}

func BankTask(m int) {
	rand.Seed(time.Now().UnixNano())
	queues := make([]Queue, m)
	for i := 0; i < 10; i++ {
		client := Client{id: i}
		queue := rand.Intn(len(queues))
		queues[queue].Insert(client)
		fmt.Printf("Client %d added to queue %d \n", client.id, queue)
		for i, queue := range queues {
			fmt.Printf("Queue %d: ", i)
			queue.Print()
		}
		fmt.Println()
	}
	for i := 0; i < 10; i++ {
		queue := rand.Intn(len(queues))
		client, err := queues[queue].Delete()
		if err != nil {
			fmt.Println(err)
			continue
		}
		fmt.Printf("Client %d served from queue %d \n", client.id, queue)
		for i, queue := range queues {
			fmt.Printf("Queue %d: ", i)
			queue.Print()
		}
		fmt.Println()
	}
}
