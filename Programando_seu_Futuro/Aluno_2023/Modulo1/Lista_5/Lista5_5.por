programa
{
	
	funcao inicio()
	{
		escreva("Lista 5: exercício 5\n")
		const inteiro quantidadeDeLinhas = 4
		const inteiro quantidadeDeColunas = 4
		inteiro somatorio = 0
		inteiro matriz[quantidadeDeLinhas][quantidadeDeColunas]
		para(inteiro linha=0; linha < quantidadeDeLinhas; linha++)
		{
			para(inteiro coluna=0; coluna < quantidadeDeColunas; coluna++)
			{
				escreva("Digite o valor da linha " + (linha + 1) + " e coluna " + (coluna + 1) + ": ")
				leia(matriz[linha][coluna])
			}
		}
		limpa()
		escreva("Digite o número a ação desejada:")
		escreva("\n1- Imprimir todos os elementos da matriz;")
		escreva("\n2 - Somar todos os elementos e exibir o resultado;")
		escreva("\n3 - Somar todos os elementos da terceira linha e exibir o resultado;")
		escreva("\n4 - Somar os elementos da diagonal principal;")
		escreva("\n5 - Somar todos os elementos de índice par da segunda linha.\n")
		inteiro digite
		leia(digite)
		se(digite == 1)
		{
			para(inteiro linha=0; linha < quantidadeDeLinhas; linha++)
			{
				para(inteiro coluna=0; coluna < quantidadeDeColunas; coluna++)
				{
				escreva("|" + matriz[linha][coluna] + "|")
				}
			escreva("\n")
			}
		}
		senao se(digite == 2)
		{
			para(inteiro linha=0; linha < quantidadeDeLinhas; linha++)
			{
				para(inteiro coluna=0; coluna < quantidadeDeColunas; coluna++)
				{
				somatorio = somatorio + matriz[linha][coluna]
				}
			}
			escreva("Resultado da soma dos elementos da matriz: " + somatorio)
		}
		senao se(digite == 3)
		{
			para(inteiro linha=0; linha < quantidadeDeLinhas; linha++)
			{
				para(inteiro coluna=0; coluna < quantidadeDeColunas; coluna++)
				{
					se(linha == 2)
					{
						somatorio = somatorio + matriz[linha][coluna]
					}
				}
			}
			escreva("Resultado da soma dos elementos da 3° linha da matriz: " + somatorio)
		}
		senao se(digite == 4)
		{
			para(inteiro linha=0; linha < quantidadeDeLinhas; linha++)
			{
				para(inteiro coluna=0; coluna < quantidadeDeColunas; coluna++)
				{
					se(linha == coluna)
					{
						somatorio = somatorio + matriz[linha][coluna]
					}
				}
			}
			escreva("Resultado da soma dos elementos da diagonal da matriz: " + somatorio)
		}
		senao se(digite == 5)
		{
			para(inteiro linha=0; linha < quantidadeDeLinhas; linha++)
			{
				para(inteiro coluna=0; coluna < quantidadeDeColunas; coluna++)
				{
					se(linha == 1)
					{
						se(coluna % 2 == 0)
						{
							somatorio = somatorio + matriz[linha][coluna]
						}
					}
				}
			}
			escreva("Resultado da soma dos elementos pares da segunda linha da matriz: " + somatorio)
		}
		senao
		{
			escreva("Dados Inválidos!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 453; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {matriz, 10, 10, 6};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */