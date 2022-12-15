lista_a = [1, 2, 3, 4, 5, 6]
lista_b = [1, 2, 3, 4, 10, 2, 8]

lista_menor = []
lista_c = []

if len(lista_a) < len(lista_b):
    lista_menor = lista_a
else:
    lista_menor = lista_b

for i in range(len(lista_menor)):
    lista_c.append(lista_a[i] + lista_b[i])

print(lista_c)
