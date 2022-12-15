"""
Cria uma função que receba 2 números. O primeiro é um valor e o segundo é um percentual. Retorne o valor do primeiro
número somado do aumento de percentual do mesmo.
"""


def aumento_percentual(valor, percentual):
    return valor + valor * percentual / 100


ap = aumento_percentual(100, 50)
print(ap)
ap = aumento_percentual(100, 10)
print(ap)
ap = aumento_percentual(15, 100)
print(ap)
ap = aumento_percentual(900, 50)
print(ap)
