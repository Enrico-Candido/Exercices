aux = 0
while aux < 1:
    numero = input("Digite um número inteiro: ")
    if numero.isnumeric():
        numero = int(numero)
        if 1 <= numero <= 10:
            for i in range(11):
                if i == numero:
                    print("{}muito mais".format(numero * "Incomodam "))
                    aux += 1
        else:
            print("Digite um número entre 1 e 10")
    else:
        print("Digite um número entre 1 e 10")


