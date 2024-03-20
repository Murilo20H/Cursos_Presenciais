using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
  static void Main(string[] args)
  {
    int regressivo = 50;
    for(int progressivo = 0; progressivo <= 50; progressivo++)
    {
      Console.WriteLine($"{progressivo} - {regressivo}");
      regressivo--;
    }
  }
}
