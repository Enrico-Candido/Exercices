print()

perguntas = {
    'pergunta1': {
        'pergunta': '2 + 2',
        'respostas': {'a': '0', 'b': '3', 'c': '4', 'd': '5'},
        'resposta_certa': 'c',
    },
    'pergunta2': {
        'pergunta': '3 * 7',
        'respostas': {'a': '21', 'b': '30', 'c': '23', 'd': '25'},
        'resposta_certa': 'a',
    },
    'pergunta3': {
        'pergunta': '2 ** 4',
        'respostas': {'a': '8', 'b': '9', 'c': '15', 'd': '16'},
        'resposta_certa': 'd',
    },
    'pergunta4': {
        'pergunta': '23 - 24',
        'respostas': {'a': '0', 'b': '-1', 'c': '4', 'd': '2'},
        'resposta_certa': 'b',
    },
}

respostas_certas = 0
for pk, pv in perguntas.items():
    print(f'{pk}: {pv["pergunta"]}')
    print('Alternativas')
    for rk, rv in pv['respostas'].items():
        print(f'[{rk}]: {rv}')
    resposta_usuario = input('Sua resposta: ')

    if resposta_usuario == pv['resposta_certa']:
        print('BOAAA!! VOCÊ ACERTOU!!!')
        respostas_certas += 1
    else:
        print('IXIII!! ESSA VOCÊ ERROU!!')
    print()

qtde_perguntas = len(perguntas)
porcentagem_acerto = respostas_certas / qtde_perguntas * 100

print(f'Respostas corretas: {respostas_certas}.')
print(f'Sua porcentagem de acerto foi {porcentagem_acerto}%.')
