programa
{
	inclua biblioteca Util
	
	funcao inicio()
	{
		escreva("Lista 4: exercício 2")
		inteiro tabuada
		escreva("\nDigite a tabuada desejada: ")
		leia(tabuada)
		para(inteiro contadorExterno = 1; contadorExterno <= tabuada; contadorExterno++)
		{
			escreva("\n\nTabuada do: " + contadorExterno)
			Util.aguarde(200)
			para(inteiro contadorInterno = 1; contadorInterno <= 10; contadorInterno++)
			{
				inteiro resultado = contadorInterno * contadorExterno
				escreva("\n" + "\t" + contadorExterno + " x " + contadorInterno + " = " + resultado)
				Util.aguarde(100)
			}
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 75; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */