"""
Вводится N, вводится N пар чисел. 
Пары нужно быстро отсортировать по возрастанию суммы в паре
"""
# input
N = int(input())
elements = list(map(int, input().split()))

# sort
pairs = [elements[i : i + 2] for i in range(0, len(elements), 2)]
sort_pairs = sorted(pairs, key=lambda el: sum(el))

# out
for _ in sort_pairs:
    print(*_, end=' ')
