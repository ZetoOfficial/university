def perceptron(sensor, weights, bias):
    s = 0
    n_sensor = len(sensor)
    for i in range(n_sensor):
        s += int(sensor[i]) * weights[i]
    if s >= bias:
        return 1
    else:
        return 0


def is_dot(sensor):
    return perceptron(sensor, [1, -1, -1, -1], 1) == 1


def is_horizontal_line(sensor):
    ans = perceptron(
        [
            perceptron(sensor, [1, 1, -1, -1], 2),
            perceptron(sensor, [-1, -1, 1, 1], 2),
        ],
        [1, 1],
        1,
    )
    return ans == 1


def is_vertical_line(sensor):
    ans = perceptron(
        [
            perceptron(sensor, [-1, 1, -1, 1], 2),
            perceptron(sensor, [1, -1, 1, -1], 2),
        ],
        [1, 1],
        1,
    )
    return ans == 1


def is_square(sensor):
    return perceptron(sensor, [1, 1, 1, 1], 2) == 1


def get_image_name(sensor):
    if is_dot(sensor):
        return 'точка (типа точка, а не банк)'
    elif is_horizontal_line(sensor):
        return 'горизонтальная линия'
    elif is_vertical_line(sensor):
        return 'вертикальная линия'
    elif is_square(sensor):
        return 'квадрат'
    else:
        return 'другое'


dot = list('1000')
horizontal_line = list('1100')
vertical_line = list('1010')
square = list('1111')


print(dot, get_image_name(dot))
print(horizontal_line, get_image_name(horizontal_line))
print(vertical_line, get_image_name(vertical_line))
print(square, get_image_name(square))
