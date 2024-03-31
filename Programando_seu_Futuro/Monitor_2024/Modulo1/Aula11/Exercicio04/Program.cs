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
			string[] nomes = new string[5];
			int[] idades = new int[5];
			bool[] ehCasado = new bool[5];
		  for(int contador = 0; contador < 5; contador++)
		  {
		    nomes[contador] = Console.ReadLine();
		    idades[contador] = int.Parse(Console.ReadLine());
		    ehCasado[contador] = bool.Parse(Console.ReadLine());
		  }
		  
		  Console.WriteLine("As pessoas casadas sao:");
		  for(int contador = 0; contador < 5; contador++)
		  {
  		  if (ehCasado[contador])
  		  {
          Console.WriteLine(nomes[contador] + ", de " + idades[contador] + " anos");
  	    }
		  }
		  
		}
	}
}