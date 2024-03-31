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
		  int[] idades = new int[5];
		  int numeroDigitado;
		  int contador = 0;
		  while(contador < 5)
		  {
		    numeroDigitado = int.Parse(Console.ReadLine());
		    if (numeroDigitado % 2 == 0)
		    {
		      idades[contador] = numeroDigitado;
		      contador++;
		    }
		  }
		  for(contador = 0; contador < 5; contador++)
		  {
		    Console.WriteLine(idades[contador]);
		  }
		}
	}
}