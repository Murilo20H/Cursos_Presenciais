programa
{
	
	funcao inicio()
	{
		escreva("Lista 5: exercício 3\n")
		const inteiro quantidadeDeContas = 5
		cadeia nomes[quantidadeDeContas]
		real cpfs[quantidadeDeContas]
		cadeia nomeDigitado
		inteiro cpfDigitado
		para(inteiro contador = 0; contador < quantidadeDeContas ; contador++)
		{
			escreva((contador + 1) + "° nome: ")
			leia(nomes[contador])
			escreva((contador + 1) + "° CPF: ")
			leia(cpfs[contador])
		}
		limpa()
		escreva("Nome do aluno que deseja entrar no laboratório: ")
		leia(nomeDigitado)
		escreva("CPF do aluno que deseja entrar no laboratório: ")
		leia(cpfDigitado)
		para(inteiro contador = 0; contador < quantidadeDeContas; contador++)
		{
			se(nomes[contador] == nomeDigitado e cpfs[contador] == cpfDigitado)
			{
				escreva("Aluno Autorizado")
				pare
			}
			senao se(nomes[contador] != nomeDigitado e cpfs[contador] != cpfDigitado e contador == (quantidadeDeContas - 1))
			{
				escreva("Aluno não matriculado")
				pare
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 980; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */