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
			int[]idades = new int[3];
			idades[0] = int.Parse(Console.ReadLine());
			idades[1] = int.Parse(Console.ReadLine());
			idades[2] = int.Parse(Console.ReadLine());
			Console.WriteLine(idades[2]);
			Console.WriteLine(idades[1]);
			Console.WriteLine(idades[0]);
		}
	}
}