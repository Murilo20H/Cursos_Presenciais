programa
{
	
	funcao logico fazerLogin(cadeia nomeDigitado, cadeia senhaDigitada)
	{
		se(nomeDigitado == "admin" e senhaDigitada == "123")
		{
			retorne verdadeiro
		}
		retorne falso
	}
	funcao inicio()
	{
		cadeia nomeDigitado, senhaDigitada
		escreva("Lista 6: exercício 5\n")
		escreva("Verificação de conta, digite seu nome de usuário: ")
		leia(nomeDigitado)
		escreva("Digite sua senha: ")
		leia(senhaDigitada)
		se(fazerLogin(nomeDigitado, senhaDigitada) == verdadeiro)
		{
			escreva("Login Realizado com sucesso!")
		}
		senao
		{
			escreva("Usuário ou senha incompatível!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 591; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */