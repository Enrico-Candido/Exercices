numero = float(input("Digite um número: "))
# Sem validação para letra
if numero % 1 == 0:
    if numero % 2 == 0:
        print(f"{numero} é par")
    else:
        print(f"{numero} é impar")
else:
    print("Não é um número inteiro")
