using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main(string[] args)
	{
	  for(int contador = 120; contador >= 0; contador--)
	  {
      int minutos = contador / 60;
      int segundos = contador % 60;
  	  Console.WriteLine(minutos + ":" + segundos);
	  }
	}
}