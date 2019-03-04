def cons(a, b):
    def pair(f):
        return f(a, b)
    return pair

def car(f):
    def left(a, b):
        return a
    return f(left)

def cdr(f):
    def right(a, b):
        return b
    return f(right)

a, b = (int(n) for n in input().split(','))
print(car(cons(a,b)))
print(cdr(cons(a,b)))
