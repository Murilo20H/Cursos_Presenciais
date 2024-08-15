programa
{
	
	funcao inicio()
	{
		escreva("Lista 3: exercício 1\n")
		cadeia escolha1, escolha2
		escreva("Jogador 1\nEscolha pedra, papel ou tesoura: ")
		leia(escolha1)
		escreva("Jogador 2\nEscolha pedra, papel ou tesoura: ")
		leia(escolha2)
		limpa()
		se(escolha1 == "pedra" e escolha2 == "tesoura")
		{
			escreva("Vitória do jogador 1")
		}
		senao se(escolha1 == "papel" e escolha2 == "pedra")
		{
			escreva("Vitória do jogador 1")
		}
		senao se(escolha1 == "tesoura" e escolha2 == "papel")
		{
			escreva("Vitória do jogador 1")
		}
		senao se(escolha1 == escolha2)
		{
			escreva("Empatou...")
		}
		senao
		{
			escreva("Vitória do jogador 2")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 262; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */