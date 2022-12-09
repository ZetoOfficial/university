"""
На любом языке программирования, написать программу, выполняющую арифметическую операцию над числами в различных системах счисления.
Умножение
16 * 6 = 16

Перевод из любой в десятичную
Из десятичной в 16-ричную
"""
from typing import Union

ALPHABET = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"


def convert_base(num: Union[int, str], to_base=10, from_base=10) -> str:
    n = int(num, from_base) if isinstance(num, str) else int(num)
    return ALPHABET[n] if n < to_base else convert_base(n // to_base, to_base) + ALPHABET[n % to_base]


# Подготовка тестовых данных
num1 = convert_base(25, to_base=16, from_base=10)  # перевод 25 в 16ричную сис
num2 = convert_base(45, to_base=6, from_base=10)  # перевод 45 в 6ричную сис

# Тестирование
first_num = int(convert_base(num1, to_base=10, from_base=16))  # перевод первого числа в десятичную
second_num = int(convert_base(num2, to_base=10, from_base=6))  # перевод второго числа в десятичную
answer = convert_base(first_num * second_num, to_base=16, from_base=10)  # перевод ответа в 16ричную
print(answer)
