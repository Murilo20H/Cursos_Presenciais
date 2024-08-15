programa
{
	inclua biblioteca Matematica
	inclua biblioteca Util
	
	funcao inteiro verificaMaiorNumero(inteiro vetor[], inteiro tamanhoDoVetor)
	{
		inteiro resultado = 0
		para(inteiro contador = 0; contador < tamanhoDoVetor; contador++)
		{
			se(contador == 0)
			{
				resultado = vetor[contador]
			}
			senao se(vetor[contador] > resultado)
			{
				resultado = vetor[contador]
			}
		}
		retorne resultado
	}
	funcao inteiro verificaMenorNumero(inteiro vetor[], inteiro tamanhoDoVetor)
	{
		inteiro resultado = 0
		para(inteiro contador = 0; contador < tamanhoDoVetor; contador++)
		{
			se(contador == 0)
			{
				resultado = vetor[contador]
			}
			senao se(vetor[contador] < resultado)
			{
				resultado = vetor[contador]
			}
		}
		retorne resultado
	}
	funcao inteiro realizaSomatorio(inteiro vetor[], inteiro tamanhoDoVetor)
	{
		inteiro resultado = 0
		para(inteiro contador = 0; contador < tamanhoDoVetor; contador++)
		{
			resultado = resultado + vetor[contador]
		}
		retorne resultado
	}
	funcao real realizaMedia(inteiro vetor[], inteiro tamanhoDoVetor)
	{
		real soma = 0.0
		real mediaDoVetor
		para(inteiro contador = 0; contador < tamanhoDoVetor; contador++)
		{
			soma = soma + vetor[contador]
		}
		mediaDoVetor = soma / tamanhoDoVetor
		retorne Matematica.arredondar(mediaDoVetor, 2)
	}
	funcao inicio()
	{
		const inteiro tamanhoDoVetor = 10
		inteiro vetor[tamanhoDoVetor]
		para(inteiro contador = 0; contador < tamanhoDoVetor; contador++)
		{
			vetor[contador] = sorteia(0, 99)
		}
		inteiro maiorNumero = verificaMaiorNumero(vetor, tamanhoDoVetor)
		inteiro menorNumero = verificaMenorNumero(vetor, tamanhoDoVetor)
		inteiro somatorio = realizaSomatorio(vetor, tamanhoDoVetor)
		real media = realizaMedia(vetor, tamanhoDoVetor)
		escreva("Lista 6: exercício 3\n")
		escreva("Foram gerados aleatoriamente 4 vetores\n")
		Util.aguarde(1000)
		limpa()
		escreva("O maior número do vetor: ")
		escreva(maiorNumero)
		Util.aguarde(500)
		escreva("\nO menor número do vetor: ")
		escreva(menorNumero)
		Util.aguarde(500)
		escreva("\nO somatório dos números do vetor: ")
		escreva(somatorio)
		Util.aguarde(500)
		escreva("\nA média dos números do vetor: ")
		escreva(media)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 2208; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */