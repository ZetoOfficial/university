def gcd(n: int, m: int) -> int:
    '''GCD implementation.'''
    return gcd(m % n, n) if n and m else max(n, m)


# input
n, m = map(int, input().split())

# use gcd & print output
print(gcd(n, m))


# tests
import math

assert math.gcd(n, m) == gcd(n, m)
