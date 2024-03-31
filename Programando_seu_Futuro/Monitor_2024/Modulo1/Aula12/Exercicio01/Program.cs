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
		  const int LINHAS = 3;
		  const int COLUNAS = 3;
		  char[,] letras = new char[LINHAS, COLUNAS];
			for (int linha = 0; linha < LINHAS; linha++) 
			{
			  for (int coluna = 0; coluna < COLUNAS; coluna++) 
			  {
			    letras[linha, coluna] = char.Parse(Console.ReadLine());
			  }
			}
			
			for (int linha = (LINHAS - 1); linha >= 0; linha--) 
			{
			  for (int coluna = (COLUNAS - 1); coluna >= 0; coluna--) 
			  {
			    Console.WriteLine(letras[linha, coluna]);
			  }
			  Console.WriteLine();
			}
		}
	}
}