import numpy as np


def get_class(predicted_values: np.array):
    ans = []
    for val in predicted_values:
        if val >= 1:
            ans.append(1)
        else:
            ans.append(-1)
    return np.array(ans)


def linear_kernel(x: np.array):
    return x


def quadratic_kernel(x: np.array):
    if len(x.shape) > 1:
        return np.concatenate((x, np.array([x[:, 0] * x[:, 1], x[:, 0] * x[:, 0], x[:, 1] * x[:, 1]]).T), axis=1)
    else:
        return np.concatenate((x, np.array([x[0] * x[1], x[0] * x[0], x[1] * x[1]]).T))


def gaussian_kernel(x: np.array):
    if len(x.shape) > 1:
        x_norm = ((x[:, 0] - x[:, 1]) ** 2).sum()
        x_new = np.zeros((x.shape[0], x.shape[1] + 1))
        x_new[:, :-1] = x
        x_new[:, -1] = np.exp(-x_norm / (2 * 1))
    else:
        x_norm = ((x[0] - x[1]) ** 2).sum()
        x_new = np.zeros(x.shape[0] + 1)
        x_new[:-1] = x
        x_new[-1] = np.exp(-x_norm / (2 * 1))
    return x_new #np.concatenate((x, np.exp(-x_norm / (2 * x.var()))))


def sigmoid_kernel(x: np.array, alpha=3, beta=0):
    if len(x.shape) > 1:
        x_new = np.zeros((x.shape[0], 2 * x.shape[1]))
        x_new[:, :-x.shape[1]] = x
        x_new[:, -x.shape[1]:] = alpha * np.tanh(x) + beta
    else:
        x_new = np.zeros(2 * x.shape[0])
        x_new[:-x.shape[0]] = x
        x_new[-x.shape[0]:] = alpha * np.tanh(x) + beta
    return x_new #np.concatenate((x, np.exp(-x_norm / (2 * x.var()))))


class SVM:
    kernels = {"linear": linear_kernel, "quadratic": quadratic_kernel,
               "gaussian": gaussian_kernel, "sigmoid": sigmoid_kernel}

    def __init__(self, kernel: str = "linear", learning_rate: float = 0.01, epochs: int = 100, alpha: float = 0.1, beta: float = 5):
        self.epochs = epochs
        self.alpha = alpha
        self.learning_rate = learning_rate
        self.weights = np.array([])
        np.random.seed = 1337
        self.errors = []
        self.kernel = SVM.kernels[kernel]

    def fit(self, x_train: np.array, y_train: np.array):
        x_transformed = self.kernel(x_train)
        if x_transformed.shape[1] > len(self.weights):
            self.weights = np.random.normal(size=x_transformed.shape[1] + 1)

        for epoch in range(self.epochs):
            loss = 0
            for i in range(len(x_transformed)):
                if y_train[i] * self.predict(x_train[i]) >= 1:
                    loss += self.soft_margin_loss(x_transformed[i], y_train[i])
                    #self.weights -= self.learning_rate * self.alpha * self.weights / self.epochs
                else:
                    self.weights[:-1] = self.weights[:-1] + self.learning_rate * (x_transformed[i] * y_train[i]) # - self.alpha *
                                                                                 # self.weights[:-1] / self.epochs)
                    self.weights[-1] = self.weights[-1] + self.learning_rate * y_train[i]
                    loss += self.soft_margin_loss(x_transformed[i], y_train[i])
            self.errors.append(loss)

        return self

    def predict(self, X: np.array) -> np.array:
        return self.weights[-1] + np.dot(self.kernel(X), self.weights[:-1])

    def soft_margin_loss(self, x, y):
        return self.hinge_loss(x, y) + self.alpha * np.dot(self.weights, self.weights)

    def hinge_loss(self, x, y):
        return max(0, 1 - y * (np.dot(self.weights[:-1], x) + self.weights[-1]))


