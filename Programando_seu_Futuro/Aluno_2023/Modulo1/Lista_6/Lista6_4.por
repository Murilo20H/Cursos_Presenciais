programa
{
	const inteiro tamanhoDaMatriz = 5
	inteiro matriz[tamanhoDaMatriz][tamanhoDaMatriz]
	funcao logico temBalista(inteiro numero)
	{
		para(inteiro linha = 0; linha < tamanhoDaMatriz; linha++)
		{
			para(inteiro coluna = 0; coluna < tamanhoDaMatriz; coluna++)
			{
				matriz[linha][coluna] = sorteia(0, 9)
			}
		}
		para(inteiro linha = 0; linha < tamanhoDaMatriz; linha++)
		{
			para(inteiro coluna = 0; coluna < tamanhoDaMatriz; coluna++)
			{
				se(matriz[linha][coluna] == 0)
				{
					retorne verdadeiro
				}
			}
		}
		retorne falso
	}
	funcao inicio()
	{
		escreva("Lista 6: exercício 4\n")
		se(temBalista(tamanhoDaMatriz) == verdadeiro)
		{
			escreva("Fique atento! existem balistas no tabuleiro")
		}
		senao
		{
			escreva("Não há balistas no tabuleiro")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 323; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {matriz, 4, 9, 6};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */