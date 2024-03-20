using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main(string[] args)
	{
		int somatorio = 0;
	  
	  int numero = int.Parse(Console.ReadLine());
		 
	  if (numero > 0)
	  {
		  for(int contador = 0; contador <= numero; contador++)
		  {
		    if(contador % 2 == 1)
	      {
	        somatorio += contador;
		    }
		  }
	    Console.WriteLine("O somatorio de todos numeros impares eh: " + somatorio);
	  }
		else if (numero < 0)
		{
		  for(int contador = 0; contador >= numero; contador--)
		  {
		    if(contador % 2 == 0)
	      {
          Console.WriteLine(contador);
	      }
	    }
	  }
	  else
	  {
	    Console.WriteLine("nada a fazer aqui");
	  }
	}
}
