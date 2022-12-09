package main

import (
	"fmt"
	"strings"
)

const alp = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"

var index = 0

func encodeVijiner(s, keyWord string) string {
	var encrypted string
	var chKey byte

	for i, ch := range s {
		chKey = keyWord[i%len(keyWord)]
		encrypted += string(rune((((int(ch) - 'а') + (int(chKey) - 'а')) % 33) + 'а'))
	}

	return encrypted
}

func decodeVijiner(s, keyWord string) string {
	var decrypted string
	var chKey byte

	for i, ch := range s {
		chKey = keyWord[i%len(keyWord)]
		decrypted += string(rune(((((int(ch) - 'а') - (int(chKey) - 'а')) + 33) % 33) + 'а'))
	}

	return decrypted
}

func main() {
	var word string = "Шифр Виженера состоит из последовательности нескольких шифров Цезаря с различными значениями сдвига. Для зашифровывания может использоваться квадрат Виженера. Применительно к русскому алфавиту таблица Виженера составляется из строк по 33 символа, причём каждая следующая строка сдвигается на несколько позиций. Таким образом, в таблице получается 33 различных шифров Цезаря. На каждом этапе шифрования используются различные алфавиты, выбираемые в зависимости от символа ключевого слова."
	word = strings.ToLower(word)

	var keyword string = "МОИАИС"

	var encodedMessage string = ""
	var decodedMessage string = ""

	var initialArray []string = strings.Split(word, " ")

	for i := 0; i < len(initialArray); i++ {
		encodedMessage += encodeVijiner(initialArray[i], keyword)
		encodedMessage += " "
	}

	var encodedArray []string = strings.Split(encodedMessage, " ")

	for i := 0; i < len(encodedArray); i++ {
		decodedMessage += decodeVijiner(encodedArray[i], keyword)
		decodedMessage += " "
	}
	fmt.Println(encodedMessage)
	fmt.Println("++++++++++++++++")
	fmt.Println(decodedMessage)
}
