# Вывести первые N чисел фибоначчи
def fib(n: int) -> list[int]:
    if n <= 0:
        return []
    elif n == 1:
        return [1]
    res = fib(n - 1)
    return res + [sum(res[-2::])]


class Solution:
    def romanToInt(self, s: str) -> int:
        symToInt = {"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}
        res = 0
        fine = 0
        for i in range(len(s)):
            if fine > 0:
                fine = 0
                continue
            if s[i : i + 2] in ("IV", "IX"):
                res += symToInt[s[i + 1]] - 1
                fine += 1
            elif s[i : i + 2] in ("XL", "XC"):
                res += symToInt[s[i + 1]] - 10
                fine += 1
            elif s[i : i + 2] in ("CD", "CM"):
                res += symToInt[s[i + 1]] - 100
                fine += 1
            else:
                res += symToInt[s[i]]
        return res


s = "MCMXCIV"
print(s)
print(Solution().romanToInt(s))
