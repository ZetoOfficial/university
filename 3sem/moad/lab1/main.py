import csv
from statistics import median

from pydantic import BaseModel


class Customer(BaseModel):
    id: int
    gender: bool
    age: int
    income: int  # Заработок
    spending_score: int  # Рейтинг трат от 1 до 100


with open('Mall_Customers.csv', 'r') as f:
    reader = csv.DictReader(f)
    customers = []
    for row in reader:
        customers.append(
            Customer(
                id=int(row['id']),
                gender=bool(row['gender'] == 'Male'),
                age=int(row['age']),
                income=int(row['income']),
                spending_score=int(row['spending_score']),
            )
        )


def get_gender_stats(sex: bool) -> float:
    return len(list(filter(lambda c: c.gender == sex, customers))) / len(customers)


def get_age_stats(age_range: tuple[int, int]) -> float:
    return len(list(filter(lambda c: c.age in range(*age_range), customers))) / len(customers)


def get_income_stats(income_range: tuple[int, int]):
    return len(list(filter(lambda c: c.income in range(*income_range), customers))) / len(customers)


def get_spending_score_stats(spending_score_range: tuple[int, int]):
    return len(list(filter(lambda c: c.spending_score in range(*spending_score_range), customers))) / len(customers)


def get_sex_spending_score_stats(sex: bool) -> float:
    only_one_sex = list(filter(lambda c: c.gender == sex, customers))
    return median([_.spending_score for _ in only_one_sex])


print('Пол:')
print(f'М: {get_gender_stats(True)}')
print(f'Ж: {get_gender_stats(False)}')
print('\nВозраст:')
print(f'18 - 19: {get_age_stats((18, 20))}')
print(f'20 - 29: {get_age_stats((20, 30))}')
print(f'30 - 44: {get_age_stats((30, 45))}')
print(f'45 - 59: {get_age_stats((45, 60))}')
print(f'60 - 100: {get_age_stats((60, 100))}')
print('\nЗаработок (k$):')
print(f'0 - 9: {get_income_stats((0, 10))}')
print(f'10 - 19: {get_income_stats((10, 20))}')
print(f'20 - 29: {get_income_stats((20, 30))}')
print(f'30 - 59: {get_income_stats((30, 60))}')
print(f'60 - 99: {get_income_stats((60, 100))}')
print(f'100+: {get_income_stats((100, 1000))}')
print('\nТрата:')
print(f'М: {get_sex_spending_score_stats(True)}')
print(f'Ж: {get_sex_spending_score_stats(False)}')
