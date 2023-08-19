programa
{
	
	funcao inicio()
	{
		real numero1
		real numero2
		inteiro operacao
		inteiro cont = 0
		caracter decisao
		escreva("Olá Mundo!!\n")
		enquanto(verdadeiro){
			se(cont != 0){
				escreva("Deseja continuar?(S/N): ")
				leia(decisao)
				se(decisao == 'n' ou decisao == 'N'){
					pare
				}
				cont = 0
			}
			senao{
				escreva("Digite o primeiro número: ")
				leia(numero1)
				escreva("Digite o segundo número: ")
				leia(numero2)
				escreva("Qual será a operação?\n"
					,"Soma(1)\n",
					"Subtração(2)\n",
					"Multiplicação(3)\n",
					"Divisão(4): ")
				leia(operacao)
				se(operacao == 1){
					escreva("A Soma de ", numero1, " com ", numero2, " é = ", numero1+numero2, "\n")
					cont = 1
			}
				senao se(operacao == 2){
					escreva("A Subtração de ", numero1, " com ", numero2, " é = ", numero1-numero2, "\n")
					cont = 1
			}
				senao se(operacao == 3){
					escreva("A Multiplicação de ", numero1, " com ", numero2, " é = ", numero1*numero2, "\n")
					cont = 1
			}
				senao se(operacao == 4){
					escreva("A Divisão de ", numero1, " com ", numero2, " é = ", numero1/numero2, "\n")
					cont = 1
			}
				senao{
					escreva("Não entendi a escolha!!\n")
					cont = 1
			}
			}
			
		}
		
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 823; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */