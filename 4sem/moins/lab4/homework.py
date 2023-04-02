import random

from PIL import Image, ImageDraw, ImageFont

SENSOR_PATTERNS = [
    [1, 1, 1, 1, 1, 1, 0],  # 0
    [0, 1, 1, 0, 0, 0, 0],  # 1
    [1, 1, 0, 1, 1, 0, 1],  # 2
    [1, 1, 1, 1, 0, 0, 1],  # 3
    [0, 1, 1, 0, 0, 1, 1],  # 4
    [1, 0, 1, 1, 0, 1, 1],  # 5
    [1, 0, 1, 1, 1, 1, 1],  # 6
    [1, 1, 1, 0, 0, 0, 0],  # 7
    [1, 1, 1, 1, 1, 1, 1],  # 8
    [1, 1, 1, 1, 0, 1, 1],  # 9
]


def perceptron(sensor: list[int], weights: list[int], bias: int):
    sensor_sum = sum(sensor[i] * weights[i] for i in range(len(sensor)))
    return sensor_sum == bias


def detect_digit(sensor):
    for digit, pattern in enumerate(SENSOR_PATTERNS):
        weights = [2**i for i in range(len(sensor))]
        bias = sum(pattern[i] * weights[i] for i in range(len(sensor)))
        if perceptron(sensor, weights, bias):
            return str(digit)
    return "Не цифра"


def generate_test_sensors(num_sensors):
    sensors = []
    for i in range(num_sensors):
        sensors.append([random.randint(0, 1) for j in range(7)])
    return sensors


def draw_numbers(test_sensors: list[int]):
    image_width, image_height = 500, 500
    margin, step_width, x, step = 150, 150, 100, 0
    # change to arial.ttf if u use windows :)
    font_my_text = ImageFont.truetype("/Library/Fonts/Arial Unicode.ttf", 64)

    image = Image.new("RGBA", (image_width, image_height), "gray")
    image_draw = ImageDraw.Draw(image)

    sensors_list = [test_sensors[i : i + 7] for i in range(0, len(test_sensors), 7)]
    for sensors in sensors_list:
        number = detect_digit(sensors)
        print(sensors, number)
        image_draw.text(
            (margin + step * step_width * x, image_height // 2 - 20),
            number,
            fill="black",
            font=font_my_text,
        )
        step += 1
    return image


test_sensors = [
    [1, 0, 1, 1, 1, 1, 1],  # 6
    [1, 1, 1, 0, 0, 0, 0],  # 7
    [0, 1, 1, 0, 0, 1, 1],  # 4
    [1, 1, 1, 1, 0, 1, 1],  # 9
    [1, 1, 1, 1, 1, 1, 1],  # 8
    [1, 1, 1, 1, 0, 0, 1],  # 3
    [0, 1, 1, 0, 0, 0, 0],  # 0
    [1, 1, 0, 1, 1, 0, 1],  # 2
    [1, 0, 1, 1, 0, 1, 1],  # 5
]

for sensor in test_sensors:
    draw_numbers(sensor).show()
