import os

lista_compras = list()

while True:
    input_usuario = input('Selecione uma opcao \n[i]nserir [a]pagar [l]istar: ')
    if input_usuario == 'l':
        if len(lista_compras) == 0:
            print('Nada para listar')
        else:
            for indice, produto in enumerate(lista_compras):
                print(indice, produto)
        print()

    elif input_usuario == 'i':
        input_produto = input('Produto: ')
        lista_compras.append(input_produto)
        os.system('cls')
    
    elif input_usuario == 'a':
        try:
            if len(lista_compras) == 0:
                print('Lista vazia, nao ha o que apagar')
            else:
                input_apaga = input('Escolha o indice para apagar: ')
                if int(input_apaga) > len(lista_compras)-1 or int(input_apaga) < 0:
                    print('Indice nao existe')
                else:
                    lista_compras.pop(int(input_apaga))
                    os.system('cls')
            print()
        except ValueError: 
           print('Digite um indice valido\n')
        except:
            print('Erro desconhecido\n')
           
    else:
        print('Escolha uma das opcoes validas')
        print()
