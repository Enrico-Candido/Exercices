# Modo 'pythonico'

lista_a = [1, 2, 3, 4, 5, 6]
lista_b = [1, 2, 3, 4, 5, 7, 8, 6]

lista_soma = [x + y for x, y in zip(lista_a, lista_b)]
print(lista_soma)
