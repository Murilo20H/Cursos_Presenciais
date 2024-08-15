programa
{
	
	funcao logico numeroPar(inteiro numero)
	{
		se(numero % 2 == 0)
		{
			retorne verdadeiro
		}
		retorne falso
	}
	funcao inicio()
	{
		inteiro numero
		escreva("Lista 6: exercício 2\n")
		escreva("Digite um número: ")
		leia(numero)
		limpa()
		escreva("Seu número é par: ")
		escreva(numeroPar(numero))
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 290; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */