from itertools import cycle

alp = 'abcdefghijklmnopqrstuvwxyz'
alp_len = len(alp)


def encode_vijn(text: str, keytext: str) -> str:
    f = lambda arg: alp[(alp.index(arg[0]) + alp.index(arg[1]) % alp_len) % alp_len]
    return ''.join(map(f, zip(text, cycle(keytext))))


def decode_vijn(coded_text: str, keytext: str) -> str:
    f = lambda arg: alp[alp.index(arg[0]) - alp.index(arg[1]) % alp_len]
    return ''.join(map(f, zip(coded_text, cycle(keytext))))


if __name__ == '__main__':
    word = 'Шифр Виженера состоит из последовательности нескольких шифров Цезаря с различными значениями сдвига. Для зашифровывания может использоваться квадрат Виженера. Применительно к русскому алфавиту таблица Виженера составляется из строк по 33 символа, причём каждая следующая строка сдвигается на несколько позиций. Таким образом, в таблице получается 33 различных шифров Цезаря. На каждом этапе шифрования используются различные алфавиты, выбираемые в зависимости от символа ключевого слова.'
    word = 'privet'
    keytext = 'МОИАИС'
    w1 = encode_vijn(word, keytext)
    print(word, w1)
    o1 = decode_vijn(w1, keytext)
    print(w1, o1)
