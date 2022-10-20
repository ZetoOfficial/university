"""
Есть массив, брать из файла, можно предобработать. 
Функция должна по паре чисел (L, R) быстро находить ответ на отрезке/подмассиве (среди элементов от L до R). 
Пары чисел можно брать тоже из файла или вводить с экрана.

Написать функцию нахождения суммы на отрезке
"""


def range_sum(lst: list, l: int, r: int) -> int:
    '''Get sum in l:r (no include) segment.'''
    return sum(lst[l:r])


# input
with open('./input_rangesum.txt', 'r') as f:
    n, lst, lr = f.read().split('\n')
    lst = list(map(int, lst.split()))
    l, r = list(map(int, lr.split()))

# output
print(range_sum(lst, l, r))
