programa
{
	
	funcao inicio()
	{
		escreva("Lista 5: exercício 2\n")
		const inteiro quantidadeLinhas = 3
		const inteiro quantidadeColunas = 3
		inteiro matriz[quantidadeLinhas][quantidadeColunas]
		para(inteiro linha=0; linha < quantidadeLinhas; linha++)
		{
			para(inteiro coluna=0; coluna < quantidadeColunas; coluna++)
			{
					escreva("Digite o valor da linha " + linha + " e coluna " + coluna + ": ")
					leia(matriz[linha][coluna])
			}
		}
		limpa()
		para(inteiro linha=0; linha < quantidadeLinhas; linha++)
		{
			para(inteiro coluna=0; coluna < quantidadeColunas; coluna++)
			{
				se(coluna % 2 == 1)
				{
					escreva("|" + matriz[linha][coluna] * 3 + "|")
				}
				senao
				{
					escreva("|" + matriz[linha][coluna] * 2 + "|")
				}
			}
			escreva("\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 377; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {matriz, 9, 10, 6};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */