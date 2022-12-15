numero = input("Digite um número inteiro: ")
# Sem validação para número negativo
if not numero.isnumeric():
  print("Não é um número inteiro")
else:
  numero = int(numero)
  if not numero % 2 == 0:
    print(f"{numero} é ímpar")
  else:
    print(f"{numero} é par")