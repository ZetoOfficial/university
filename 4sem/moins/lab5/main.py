import random
import string

import matplotlib.pyplot as plt
import numpy as np
import segno

# Set random seed for reproducibility
random.seed(42)


def generate_random_string(length):
    """Generate a random string of given length"""
    return ''.join(random.choices(string.ascii_letters + string.digits, k=length))


def generate_qr_code(string):
    """Generate a QR code from the given string"""
    qr = segno.make(string, micro=False)
    qr.mask = 4  # Set mask to 4 for this example
    qr_data = np.array(qr.matrix, dtype=int)
    return qr_data


def generate_data(n, string_length):
    """Generate n QR codes and n random arrays of given string length"""
    qr_codes = []
    random_arrays = []
    for i in range(n):
        # Generate random string of given length
        rand_str = generate_random_string(string_length)
        # Generate QR code from random string
        qr_code = generate_qr_code(rand_str)
        qr_codes.append(qr_code)
        # Generate random array of same shape as QR code
        random_array = np.random.randint(0, 2, size=qr_code.shape)
        random_arrays.append(random_array)
    return qr_codes, random_arrays


def train_perceptron(X, y, n_epochs=20, threshold=1000):
    """Train a perceptron on the given input data"""
    # Initialize weights
    w = np.random.rand(X.shape[1])
    for epoch in range(n_epochs):
        # Shuffle data for each epoch
        indices = np.random.permutation(X.shape[0])
        X_shuffled = X[indices]
        y_shuffled = y[indices]
        # Iterate over each data point
        for i in range(X_shuffled.shape[0]):
            x_i = X_shuffled[i]
            y_i = y_shuffled[i]
            # Compute dot product of input and weights
            dot_product = np.dot(w, x_i)
            # If dot product is above threshold and y_i is 0, update weights
            if dot_product.all() > threshold and y_i == 0:
                w = w - x_i
            # If dot product is below threshold and y_i is 1, update weights
            elif dot_product.all() < threshold and y_i == 1:
                w = w + x_i
    return w


def plot_weights(weights):
    """Plot the resulting weights as an image"""
    plt.imshow(weights, cmap='gray')
    plt.show()


# Part 1
# Find out experimentally at what string length the minimum size of the QR-code is achieved
for i in range(1, 100):
    rand_str = generate_random_string(i)
    qr_code = generate_qr_code(rand_str)
    if qr_code.shape[0] == qr_code.shape[1]:
        print(f"Minimum QR code size achieved at string length {i}")
        break

# Part 2
# Generate data and train perceptron
qr_codes, random_arrays = generate_data(100, 21 * 21)
X = np.array(qr_codes + random_arrays)
y = np.concatenate((np.ones(100), np.zeros(100)))
weights = train_perceptron(X, y)
plot_weights(weights)
