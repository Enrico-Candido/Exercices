carrinho = []

carrinho.append(('Produto1', 30.5))
carrinho.append(('Produto2', '20'))
carrinho.append(('Produto3', 50))
carrinho.append(('Produto4', -50))
carrinho.append(('Produto5', 20))

lista = sum([float(x[1]) for x in carrinho])
print(lista)

lista2 = sum([float(y) for x, y in carrinho])
print(lista2)
