print('Olá Mundo!')

continuar = True
valor_final = '0'

while continuar:
    if valor_final == '0':
        escolha = input('Deseja continuar? (S/N): ').upper()
        if escolha == 'N':
            break
    i = 0
    primeiro = int(input('Digite o primeiro valor: '))
    segundo = int(input('Digite o segundo valor: '))
    lista_de_valores = [primeiro, segundo]
    escolha = input('Tem algum outro valor?(S/N) ').upper()
    while escolha == 'S':
        lista_de_valores.append(int(input(f'Digite o novo valor: ')))
        escolha = input('Tem algum outro valor?(S/N) ').upper()

    while True:
        operacao = input('Escolha a operação:'
                         '\n(1) Soma +'
                         '\n(2) Subtração -'
                         '\n(3) Multiplicação x'
                         '\n(4) Divisão /: ')
        if operacao == '1':
            print('Soma')
            while i < len(lista_de_valores):
                valor_final += lista_de_valores[i]
                i += 1
            print(f'Resultado da soma: {valor_final}')
            lista_de_valores.clear()
            escolha = input('Quer manter esse resultado(S/N)? ').upper()
            if escolha == 'S':
                lista_de_valores.append(valor_final)
            break
        elif operacao == '2':
            print('Subtração')
            while i < len(lista_de_valores):
                if i == 0:
                    valor_final = lista_de_valores[i]
                else:
                    valor_final -= lista_de_valores[i]
                i += 1
            print(f'Resultado da substração: {valor_final}')
            lista_de_valores.clear()
            escolha = input('Quer manter esse resultado(S/N)? ').upper()
            if escolha == 'S':
                lista_de_valores.append(valor_final)
            break
        elif operacao == '3':
            print('Multiplicação')
            while i < len(lista_de_valores):
                if i == 0:
                    valor_final = lista_de_valores[i]
                else:
                    valor_final *= lista_de_valores[i]
                i += 1
            print(f'Resultado da multiplicação: {valor_final}')
            lista_de_valores.clear()
            escolha = input('Quer manter esse resultado(S/N)? ').upper()
            if escolha == 'S':
                lista_de_valores.append(valor_final)
            break
        elif operacao == '4':
            print('Divisão')
            while i < len(lista_de_valores):
                if i == 0:
                    valor_final = lista_de_valores[i]
                else:
                    valor_final /= lista_de_valores[i]
                i += 1
            print(f'Resultado da divisão: {valor_final}')
            lista_de_valores.clear()
            escolha = input('Quer manter esse resultado(S/N)? ').upper()
            if escolha == 'S':
                lista_de_valores.append(valor_final)
            break
        else:
            print('Não entendi a opção!')
