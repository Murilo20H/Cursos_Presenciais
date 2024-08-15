programa
{
	
	funcao inicio()
	{
		escreva("Lista 5: exercício 1\n")
		const inteiro quantidadeDeValores = 10
		inteiro valores[quantidadeDeValores]
		para(inteiro contador = 0; contador < quantidadeDeValores; contador++)
		{
			 escreva((contador + 1) + "° número: ")
			leia(valores[contador])
		}
		limpa()
		escreva("Versão original: ")
		para(inteiro contador = 0; contador < quantidadeDeValores; contador++)
		{
			escreva(valores[contador] + "   ")
		}
		escreva("\nVersão invertida: ")
		para(inteiro contador = quantidadeDeValores; contador > 0; contador--)
		{
			escreva(valores[(contador - 1)] + "   ")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 115; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {quantidadeDeValores, 7, 16, 19}-{valores, 8, 10, 7}-{contador, 9, 15, 8}-{contador, 16, 15, 8}-{contador, 21, 15, 8};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */