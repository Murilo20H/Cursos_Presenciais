programa
{
	
	funcao inicio()
	{
		escreva("Lista 3: exercício 4\n")
		real preco
		real precoTotal = 0.0
		inteiro numeroProdutos
		inteiro contador = 0
		escreva("Quantos produtos: ")
		leia(numeroProdutos)
		enquanto(contador < numeroProdutos)
		{
			escreva("Digite o preço do item " + (contador + 1) + ": ")
			leia(preco)
			precoTotal = precoTotal + preco
			contador++
		}
		se(precoTotal >= 90.0)
		{
			escreva("\nParabéns! Você ganhou frete grátis em sua compra de valor: R$" + precoTotal)
		}
		senao
		{
			escreva("\nA compra não possui frete grátis")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 458; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */