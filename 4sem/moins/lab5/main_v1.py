import io
import random
import string
from typing import Optional

import matplotlib.pyplot as plt
import numpy as np
import segno
from tqdm import tqdm

random.seed(42)


def perceptron(sensors_mas: list[list[int]], weights_inner: list[list[int]], bias: int) -> bool:
    sensors_sum = 0
    for i in range(len(sensors_mas)):
        for j in range(len(sensors_mas[i])):
            sensors_sum += sensors_mas[i][j] * weights_inner[i][j]
    return sensors_sum >= bias


def generate_random_string(length: int) -> str:
    '''Generate a random string'''
    return ''.join(random.choices(string.ascii_letters + string.digits, k=length))


def generate_qr_code(mask: Optional[int]) -> list[list[int]]:
    return_mas_qr_code = []
    for _ in tqdm(range(100), desc='Generate QRCode'):
        qrcode = segno.make(generate_random_string(970), mask=mask)
        buffer = io.StringIO()
        qrcode.save(buffer, kind="txt", border=0)
        qr_code = [[int(bin_digit) for bin_digit in line] for line in buffer.getvalue().split("\n")][:-1]
        return_mas_qr_code.append(qr_code)
    return return_mas_qr_code


def get_watermark(
    qr_code: list[list[int]],
    start_point_width: int,
    final_point_width: int,
    start_point_down: int,
    final_point_down: int,
) -> list[list[int]]:
    '''Получение массива 7*7 из нижнего, верхнего левого угла и верхнего правого угла'''
    watermark = []
    for i in range(start_point_width, final_point_width):
        row = qr_code[i][start_point_down:final_point_down]
        watermark.append(row)
    return watermark


def check_qr_code(sensor: list[list[int]]) -> bool:
    # Определение ожидаемого шаблона QR-кода как матрицу 7x7.
    weights = [
        [1, 1, 1, 1, 1, 1, 1],
        [1, 0, 0, 0, 0, 0, 1],
        [1, 0, 1, 1, 1, 0, 1],
        [1, 0, 1, 1, 1, 0, 1],
        [1, 0, 1, 1, 1, 0, 1],
        [1, 0, 0, 0, 0, 0, 1],
        [1, 1, 1, 1, 1, 1, 1],
    ]
    results = [get_watermark(sensor, x, x + 7, y, y + 7) for x, y in [(0, 0), (170, 0), (0, 170)]]
    return all(r == weights for r in results)


def generate_no_qr_code(n: int = 100, size: int = 177) -> list[list[int]]:
    return_mas_no_qr_code = []
    for _ in tqdm(range(n), desc='Генерация 100 не qr кодов'):
        inner_mas_no_qr_code = [[random.randint(0, 1) for _ in range(size)] for _ in range(size)]
        return_mas_no_qr_code.append(inner_mas_no_qr_code)
    return return_mas_no_qr_code


def train_network(qr_codes, not_qr_codes):
    weights = [[0] * 177 for _ in range(177)]
    amount_of_epoches = 20
    steps = 200
    learning_step = 1
    for epoch in tqdm(range(amount_of_epoches), desc='Подсчет эпох'):
        for step in range(steps):
            random_num = random.randint(0, 1)
            train_element = 0
            if random_num == 0:
                train_element = not_qr_codes[random.randint(0, 99)]
            else:
                train_element = qr_codes[random.randint(0, 99)]
            result = perceptron(train_element, weights, 5000)
            if result and random_num == 0:
                for i in range(len(train_element)):
                    for j in range(len(train_element[i])):
                        if train_element[i][j] == 1:
                            weights[i][j] -= learning_step
            elif not result and random_num == 1:
                for i in range(len(train_element)):
                    for j in range(len(train_element[i])):
                        if train_element[i][j] == 1:
                            weights[i][j] += learning_step
    return weights


generation_mask = None
qrs = np.array(generate_qr_code(generation_mask))
not_qrs = np.array(generate_no_qr_code())
weights_random_mask = train_network(qrs, not_qrs)

generation_mask = 1
qrs = np.array(generate_qr_code(generation_mask))
not_qrs = np.array(generate_no_qr_code())
weights_certain_mask = train_network(qrs, not_qrs)

plt.figure()
plt.subplot(2, 2, 1)
plt.imshow(weights_random_mask)
plt.subplot(2, 2, 2)
plt.imshow(weights_certain_mask)
plt.show()
