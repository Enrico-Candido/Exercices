nome = input("Qual é o seu nome: ")

if len(nome) <= 4:
    print("Seu nome é curto.")
elif len(nome) <= 6:
    print("Seu nome é mediano.")
else:
    print("Seu nome é grande")
