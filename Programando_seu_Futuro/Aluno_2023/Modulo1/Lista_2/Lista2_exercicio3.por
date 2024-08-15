programa
{
	
	funcao inicio()
	{
		escreva("Lista 2: exercício 3\n")
		escreva("Digite Filomena ou Joselito para ver a rotina: ")
		cadeia filhos
		leia(filhos)
		se(filhos == "Filomena"){
			limpa()
			escreva("Rotina de Filomena:\n")
			escreva("1. Escola das 07h às 12h\n")
			escreva("2. Almoço das 12h às 13h\n")
			escreva("3. Futebol das 14h às 16h\n")
			escreva("4. Dever de casa das 16h às 18h\n")
		}
		se(filhos == "Joselito"){
			limpa()
			escreva("Rotina do Joselito:\n")
			escreva("1. Escola das 07h às 12:30\n")
			escreva("2. Almoço das 13h às 14h\n")
			escreva("3. Natação das 14h às 16h\n")
			escreva("4. Reforço escolar das 16h às 19h")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 165; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */