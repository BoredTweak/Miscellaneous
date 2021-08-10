x = lambda a, b, c : a + b + c

def kwarg_test(**kwargs):
    for kwarg in kwargs:
        print(kwarg)

y = lambda *args: list(map(print, *args))

if(__name__ == "__main__"):
    print(x(1,2,3))
    # print(x(1,"banana",3))
    print(x("1","banana","3"))
    y("1", "2", "3")
    kwarg_test(a=1, b=2, c=3)