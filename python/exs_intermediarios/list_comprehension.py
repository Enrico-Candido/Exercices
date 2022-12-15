string = '0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789'

auxiliar = 10

lista = '.'.join([
    string[indice: indice + auxiliar]
    for indice in range(0, len(string), auxiliar)
])
print(lista)
    