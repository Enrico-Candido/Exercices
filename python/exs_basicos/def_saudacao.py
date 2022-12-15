"""
Crie uma função que exiba uma saudação com os parâmetros saudação e nome
"""


def saud(saudacao, nome):
    print(saudacao, nome)  # print(f'{saudacao} {nome}')


var = saud('Olá, seja bem-vindo', 'Enrico')
print(var, type(var))  # Será retornado o tipo None
