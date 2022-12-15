horario = input("Qual a hora atual (entre 0-23)? ")

if horario.isdigit():
    horario = int(horario)
    if horario <= 11:
        print("Bom dia!")
    elif horario <= 17:
        print("Boa tarde!")
    elif horario <= 23:
        print("Boa noite!")
    else:
        print("Horário deve estar entre 0 e 23")
else:
    print("Digite um valor válido")
