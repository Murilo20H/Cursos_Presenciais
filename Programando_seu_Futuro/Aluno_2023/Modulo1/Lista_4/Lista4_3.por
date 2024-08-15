programa
{
	inclua biblioteca Texto
	
	funcao inicio()
	{
		escreva("Lista 4: exercício 3")
		inteiro altura
		escreva("\nAltura do triângulo: ")
		leia(altura)
		para(inteiro contadorExterno = 1; contadorExterno <= altura; contadorExterno++)
		{
			escreva("*")
			para(inteiro contadorInterno = 2; contadorInterno <= contadorExterno; contadorInterno++)
			{
				escreva("*")
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
 * @POSICAO-CURSOR = 80; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {altura, 8, 10, 6};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */