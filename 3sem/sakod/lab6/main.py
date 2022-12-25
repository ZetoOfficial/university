def hash_function(x):
    return (x + 23) % 13


def line_hash_function(x, i):
    return (hash_function(x) + i) % M


def quadratic_hash_function(x, i):
    return (hash_function(x) + i * i) % M


def double_hash_function(x, i):
    return (hash_function(x) + i * hash_function(x)) % M


def insert(arr, x, hash_function):
    for i in range(len(arr)):
        index = hash_function(x, i)
        if arr[index] == 0:
            arr[index] = x
            break


if __name__ == "__main__":
    # 84, 72, 93, 25, 31, 85, 89, 185, 37, 81, 129, 301, 38, 434, 216, 312, 187, 234, 51
    arr = [
        84,
        72,
        93,
        25,
        31,
        85,
        89,
        185,
        37,
        81,
        129,
        301,
        38,
        434,
        216,
        312,
        187,
        234,
        51,
    ]
    hash_table1 = [0] * (len(arr) + 1)
    hash_table2 = [0] * (len(arr) + 1)
    hash_table3 = [0] * (len(arr) + 1)
    M = len(hash_table1)

    for x in arr:
        insert(hash_table1, x, line_hash_function)
        insert(hash_table2, x, quadratic_hash_function)
        insert(hash_table3, x, double_hash_function)
    print(hash_table1)
    print(hash_table2)
    print(hash_table3)
    print(M)
