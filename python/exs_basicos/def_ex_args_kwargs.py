def mestre(funcao, *args, **kwargs):
    return funcao(*args, **kwargs)


def fala_oi(nome='Thiago'):
    return f'Oi {nome}'


def saudacao(nome, saud):
    return f'{saud} {nome}'


executando_1 = mestre(fala_oi, 'Enrico')

executando_6 = mestre(fala_oi)

# executando_7 = mestre(saudacao)

executando_2 = mestre(saudacao, 'Enrico', 'teste')

executando_3 = mestre(saudacao, nome='Enrico', saud='Bom dia')

executando_4 = mestre(saudacao, 'Euds', saud='Bom dia')

executando_5 = mestre(saudacao, saud='Bom dia', nome='Kenia')

print(executando_1)
print(executando_2)
print(executando_3)
print(executando_4)
print(executando_5)
print(executando_6)
