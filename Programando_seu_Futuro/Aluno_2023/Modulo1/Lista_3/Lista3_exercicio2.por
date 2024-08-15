programa
{
	inclua biblioteca Matematica
	
	funcao inicio()
	{
		escreva("Lista 3: exercício 2\n")
		real idade1, idade2, idade3
		escreva("Idade da pessoa 1: ")
		leia(idade1)
		escreva("Idade da pessoa 2: ")
		leia(idade2)
		escreva("Idade da pessoa 3: ")
		leia(idade3)
		real idade1e2 = Matematica.maior_numero(idade1, idade2)
		real maiorNumero = Matematica.maior_numero(idade1e2, idade3)
		escreva("Maior das três idades é: " + maiorNumero)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 62; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */