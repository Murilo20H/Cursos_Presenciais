programa
{
	inclua biblioteca Matematica
	inclua biblioteca Util
	
	funcao inicio()
	{
		escreva("Lista 5: exercício 4\n")
		const inteiro tamanhoDaMatriz = 3
		inteiro diagonalPrincipal = 0
		inteiro diagonalSecundaria = 0
		inteiro matriz[tamanhoDaMatriz][tamanhoDaMatriz]
		para(inteiro linha=0; linha < tamanhoDaMatriz; linha++)
		{
			para(inteiro coluna=0; coluna < tamanhoDaMatriz; coluna++)
			{
				matriz[linha][coluna] = Util.sorteia(0, 10)
			}
		}
		para(inteiro linha=0; linha < tamanhoDaMatriz; linha++)
		{
			para(inteiro coluna=0; coluna < tamanhoDaMatriz; coluna++)
			{
				se(coluna + linha == (tamanhoDaMatriz - 1))
				{
					diagonalSecundaria = diagonalSecundaria + matriz[linha][coluna]
				}
				se(coluna == linha)
				{
					diagonalPrincipal = diagonalPrincipal + matriz[linha][coluna]
				}
			}
		}
		real maiorNumero = Matematica.maior_numero(diagonalPrincipal, diagonalSecundaria)
		escreva("Aposta, qual diagonal é maior:\ndigite 1 para diagonal principal e 2 para diagonal secundária\n")
		inteiro aposta
		leia(aposta)
		se(maiorNumero == diagonalPrincipal e aposta == 1)
		{
			limpa()
			escreva("Pontuação, 1 = " + diagonalPrincipal + ", 2 = " + diagonalSecundaria)
			escreva("\nApostou bem, ganhou o jogo!")
		}
		senao se(maiorNumero == diagonalSecundaria e aposta == 2)
		{
			limpa()
			escreva("Pontuação, 1 = " + diagonalPrincipal + ", 2 = " + diagonalSecundaria)
			escreva("\nApostou bem, ganhou o jogo!")
		}
		senao se(maiorNumero == diagonalPrincipal e aposta == 2)
		{
			limpa()
			escreva("Pontuação, 1 = " + diagonalPrincipal + ", 2 = " + diagonalSecundaria)
			escreva("\nApostou mal, perdeu o jogo!")
		}
		senao se(maiorNumero == diagonalSecundaria e aposta == 1)
		{
			limpa()
			escreva("Pontuação, 1 = " + diagonalPrincipal + ", 2 = " + diagonalSecundaria)
			escreva("\nApostou mal, perdeu o jogo!")
		}
		senao
		{
			limpa()
			escreva("Dados Inválidos!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 633; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {diagonalPrincipal, 10, 10, 17}-{diagonalSecundaria, 11, 10, 18}-{matriz, 12, 10, 6}-{aposta, 36, 10, 6};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */