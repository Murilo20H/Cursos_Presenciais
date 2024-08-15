programa
{
	
	funcao inicio()
	{
		escreva("Lista 4: exercício 1")
		cadeia senha, nomeDeUsuario
		inteiro contador = 0
		faca
		{
			escreva("\nDigite seu nome de usúario: ")
			leia(nomeDeUsuario)
			escreva("Digite sua senha: ")
			leia(senha)
			contador++
			se(nomeDeUsuario == "admin" e senha == "123")
			{
				escreva("\nLogin realizado com sucesso")
			}
			senao se(contador > 2)
			{
				escreva("\nSua conta foi bloqueada")
				pare
			}
		}
		enquanto(nomeDeUsuario != "admin" ou senha != "123")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 56; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {senha, 7, 9, 5}-{nomeDeUsuario, 7, 16, 13}-{contador, 8, 10, 8};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */