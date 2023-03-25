import csv

A = []
with open('out.csv', 'r') as f:
    reader = csv.reader(f)
    for _ in reader:
        A.append(list(map(int, _)))

# эффекта не будет, потому что она зеркальна
B = list(map(list, zip(*A)))

length = len(A)
C = [[0 for _ in range(length)] for _ in range(length)]
sum_C = 0
d = []
for x in range(length):
    for y in range(length):
        C[x][y] = A[x][y] * B[x][y]
        sum_C += C[x][y]
    d.append(sum(C[x]))
print(sum_C)
print(sum(d))

# 3025
# 3025
