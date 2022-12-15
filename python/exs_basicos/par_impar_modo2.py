numero = input("Digite um número inteiro: ")

try:
    numero = int(numero)
    if (numero % 2) == 0:
        print(f"{numero} é PAR")
    else:
        print(f"{numero} é ÍMPAR")
except:
    print("Não foi digitado um número inteiro")
