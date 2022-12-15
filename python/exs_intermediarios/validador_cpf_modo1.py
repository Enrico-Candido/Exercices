cpf = input("Digite um CPF, apenas números: ")
# não trata cpf's com números iguais (ex.: 11111111111)
while len(cpf) < 11 or len(cpf) > 11:
    print('CPF digitado incorretamente.'
          'Digite novamente: ')
    cpf = input("Digite um CPF: ")

cpf_tratativa_1 = cpf[:9]

multiplicador = 10
soma = 0
for valor in cpf_tratativa_1:
    valor = int(valor)
    contador = valor * multiplicador
    multiplicador -= 1
    soma += contador

soma_tratada = 11 - (soma % 11)
if soma_tratada > 9:
    soma_tratada = 0

cpf_tratativa_1 = list(cpf_tratativa_1)
cpf_tratativa_1.append(soma_tratada)

multiplicador2 = 11
soma2 = 0
for valor in cpf_tratativa_1:
    valor = int(valor)
    contador = valor * multiplicador2
    multiplicador2 -= 1
    soma2 += contador

soma_tratada2 = 11 - (soma2 % 11)
if soma_tratada2 > 9:
    soma_tratada2 = 0

cpf_tratativa_1 = list(cpf_tratativa_1)
cpf_tratativa_1.append(soma_tratada2)

string = ''
for numero in cpf_tratativa_1:
    numero = str(numero)
    string += numero

if string == cpf:
    print('CPF Válido.')
else:
    print('CPF inválido.')
