using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  const int TAMANHO_MATRIZ = 4;
		  int somatorio = 0;
		  int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
			for (int linha = 0; linha < TAMANHO_MATRIZ; linha++) 
			{
			  for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++) 
			  {
			    matriz[linha, coluna] = int.Parse(Console.ReadLine());
			  }
			}
			
			for (int linha = 0; linha < TAMANHO_MATRIZ; linha++) 
			{
			  for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++) 
			  {
			    somatorio += matriz[linha, coluna];
			  }
			}
			Console.WriteLine("A soma de todos os elementos da matriz eh: " + somatorio);
		}
	}
}