# Input values
product = "черешня"
price_per_kg = 2
quantity_kg = 3
amount_paid = 10

# Calculated values
total_price = price_per_kg * quantity_kg
change = amount_paid - total_price

# Output formatting
output = "================Чек================\n"
print("Товар:".ljust(25) + f"{product}".rjust(10))
print("Цена:".ljust(22) + f"{quantity_kg}кг * {price_per_kg}руб/кг".rjust(10))
print("Итого:".ljust(25) + f"{total_price}руб".rjust(10))
print("Внесено:".ljust(25) + f"{amount_paid}руб".rjust(10))
print("Сдача:".ljust(25) + f"{change}руб".rjust(10))
print("===================================")
