"""
Fizz Buzz — Se o parâmetro da função for divísível por 3, retorne Fizz, se for divisível por 5 retorne Buzz, se for
divisível por 3 e por 5 retorne FizzBuzz, se não for divisível por nenhum, retorne o próprio número
"""
from random import randint


def fizzbuzz(valor):
    if valor % 3 == 0 and valor % 5 == 0:
        return f'FizzBuzz, {valor} é divisível por 3 e por 5'
    if valor % 3 == 0:
        return f'Fizz, {valor} é divisível por 3'
    if valor % 5 == 0:
        return f'Buzz, {valor} é divisível por 5'
    return f'{valor}, NÃO é é divisível por 3 nem por 5'


for i in range(10):
    aleatorio = randint(0, 100)
    print(fizzbuzz(aleatorio))
