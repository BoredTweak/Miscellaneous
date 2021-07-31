import numpy
import math


class NeuralNetwork():
    def nonlin(x, deriv=False):
        if(deriv == True):
            return x*(1-x)

        return 1/(1 + (numpy.exp(-x)))

    training_inputs = numpy.array([[0,0,1],
                [0,1,1],
                [1,0,1],
                [1,1,1]])

    y = numpy.array([[0],
                [1],
                [1],
                [0]])

    numpy.random.seed(1)

    syn0 = 2*numpy.random.random((3,4)) - 1
    syn1 = 2*numpy.random.random((4,1)) - 1

    for j in range(60000):
        l0 = training_inputs
        l1 = nonlin(numpy.dot(l0, syn0))
        l2 = nonlin(numpy.dot(l1, syn1))

        l2_error = y -l2
        if(j % 10000) == 0:
            print ("Error:" + str(numpy.mean(numpy.abs(l2_error))))

        l2_delta = l2_error * nonlin(l2, deriv=True)

        l1_error = l2_delta.dot(syn1.T)

        l1_delta = l1_error * nonlin(l1, deriv=True)

        syn1 += l1.T.dot(l2_delta)
        syn0 += l0.T.dot(l1_delta)

    print ("Output after training")
    print (l2)
