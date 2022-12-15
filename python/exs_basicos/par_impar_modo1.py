numero = input("Digite um número inteiro: ")
# Sem validação para número negativo
if numero.isdecimal():
    numero = int(numero)
    if (numero % 2) == 0:
        print(f"{numero} é PAR")
    else:
        print(f"{numero} é ÍMPAR")
else:
    print("Não foi digitado um número inteiro")
