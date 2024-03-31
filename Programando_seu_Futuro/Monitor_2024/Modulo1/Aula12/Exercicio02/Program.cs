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
			const int LINHAS = 8;
		  const int COLUNAS = 8;
		  int[,] matriz = new int[LINHAS, COLUNAS];
			for (int linha = 0; linha < LINHAS; linha++) 
			{
			  for (int coluna = 0; coluna < COLUNAS; coluna++) 
			  {
			    if (linha == coluna)
			    {
			      matriz[linha, coluna] = 1;
			    }
			    else
			    {
			      matriz[linha, coluna] = 0;
			    }
			  }
			}
			
			for (int linha = 0; linha < LINHAS; linha++) 
			{
			  for (int coluna = 0; coluna < COLUNAS; coluna++) 
			  {
			    Console.Write(matriz[linha, coluna]);
			  }
			  Console.WriteLine();
			}
		}
	}
}