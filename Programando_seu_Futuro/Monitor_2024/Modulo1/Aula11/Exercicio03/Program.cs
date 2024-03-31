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
		  string[] nomes = new string[4];
		  bool temJose = false;
		  for(int contador = 0; contador < 4; contador++)
		  {
		    nomes[contador] = Console.ReadLine();
		    if (nomes[contador] == "Jose")
		    {
		      temJose = true;
		    }
		  }
		  
		  if (temJose)
		  {
        Console.Write("Jose foi encontrado na lista");
	    }
	    else
	    {
	      Console.Write("Jose nao foi encontrado na lista");
	    }
  	}
	}
}