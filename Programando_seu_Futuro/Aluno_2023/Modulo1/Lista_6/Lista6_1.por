programa
{
	inclua biblioteca Matematica
	
	funcao real maiorNumero(real numero1, real numero2, real numero3)
	{
		real resultado = Matematica.maior_numero(numero1, numero2)
		real resultadoFinal = Matematica.maior_numero(numero3, resultado)
		retorne resultadoFinal
	}
	funcao inicio()
	{
		real numero1, numero2, numero3
		escreva("Lista 6: exercício 1\n")
		escreva("Escreva três números:\n")
		escreva("1° número: ")
		leia(numero1)
		escreva("2° número: ")
		leia(numero2)
		escreva("3° número: ")
		leia(numero3)
		limpa()
		escreva("O maior número é: ")
		escreva(maiorNumero(numero1, numero2, numero3))
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 618; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */