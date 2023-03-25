import math
import random
import time

import cpuinfo
import numpy as np


def timeit(func):
    def wrapper(*args, **kwargs):
        start_time = time.time()
        func(*args, **kwargs)
        end_time = time.time()
        return f'{end_time - start_time:.8f} секунд'

    return wrapper


@timeit
def foo1(lst: list | np.ndarray, key: int) -> bool:
    """1)	key in arr # list | np.array, используя оператор in"""
    return key in lst


@timeit
def foo2(lst: list, key: int) -> bool:
    """2)	arr.index или arr.count # list, используя метод count или index класса list"""
    return lst.count(key) != 0


@timeit
def foo3(lst: list | np.ndarray, key: int) -> bool:
    """3)	for, if, == # list | np.array, вручную используя for и сравнение"""
    for i in range(0, len(lst)):
        if lst[i] == key:
            return True
    return False


@timeit
def foo4(lst: list | np.ndarray, key: int) -> bool:
    """4)	while, if, == # list | np.array, вручную используя while и сравнение"""
    i = 0
    while i < len(lst):
        if key == lst[i]:
            return True
        i += 1
    return False


@timeit
def foo5(lst: list | np.ndarray, key: int) -> bool:
    """5)	binary search O(log n)"""
    lys = np.sort(lst)
    first = 0
    last = len(lys) - 1
    while first <= last:
        mid = (first + last) // 2
        if lys[mid] == key:
            return True
        else:
            if key < lys[mid]:
                last = mid - 1
            else:
                first = mid + 1
    return False


data_list = random.sample(range(0, int(math.pow(10, 7))), int(math.pow(10, 7)))
data_arr = np.array(data_list)

search_key = data_list[random.randint(0, int(math.pow(10, 7)) - 1)]

print(f"Процессор: {cpuinfo.get_cpu_info()['brand_raw']}")
print(data_list[0:10])
print('Время работы: сущ. ключ / не сущ. ключ')
print(f'функция 1: {foo1(data_list, search_key)} / {foo1(data_list, -1)}')
print(f'функция 2: {foo2(data_list, search_key)} / {foo2(data_list, -1)}')
print(f'функция 3: {foo3(data_list, search_key)} / {foo3(data_list, -1)}')
print(f'функция 4: {foo4(data_list, search_key)} / {foo4(data_list, -1)}')
print(f'функция 5: {foo1(data_arr, search_key)} / {foo1(data_arr, -1)}')
print(f'функция 6: {foo3(data_arr, search_key)} / {foo3(data_arr, -1)}')
print(f'функция 7: {foo4(data_arr, search_key)} / {foo4(data_arr, -1)}')
print(f'функция 8: {foo5(data_arr, search_key)} / {foo5(data_arr, -1)}')

print('sleep 5 sec...')
time.sleep(5)
print('run')

print(f'функция 1: {foo1(data_list, search_key)} / {foo1(data_list, -1)}')
print(f'функция 2: {foo2(data_list, search_key)} / {foo2(data_list, -1)}')
print(f'функция 3: {foo3(data_list, search_key)} / {foo3(data_list, -1)}')
print(f'функция 4: {foo4(data_list, search_key)} / {foo4(data_list, -1)}')
print(f'функция 5: {foo1(data_arr, search_key)} / {foo1(data_arr, -1)}')
print(f'функция 6: {foo3(data_arr, search_key)} / {foo3(data_arr, -1)}')
print(f'функция 7: {foo4(data_arr, search_key)} / {foo4(data_arr, -1)}')
print(f'функция 8: {foo5(data_arr, search_key)} / {foo5(data_arr, -1)}')

# Процессор: Apple M1 Pro
# [5355250, 8227370, 5682207, 614800, 3539832, 7093974, 6130700, 1302628, 6036421, 3936443]
# Время работы: сущ. ключ / не сущ. ключ
# функция 1: 0.13692713 секунд / 0.27218890 секунд
# функция 2: 0.29724479 секунд / 0.25727415 секунд
# функция 3: 0.18244195 секунд / 0.41333604 секунд
# функция 4: 0.34929681 секунд / 0.77166486 секунд
# функция 5: 0.00350070 секунд / 0.00180101 секунд
# функция 6: 0.26667500 секунд / 0.63467503 секунд
# функция 7: 0.45795417 секунд / 1.05775881 секунд
# функция 8: 0.65524316 секунд / 0.62479377 секунд
