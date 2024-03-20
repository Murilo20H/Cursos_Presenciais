using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Digite o tamanho da tabela: ");
    int tamanhoTabela = int.Parse(Console.ReadLine());

    Console.Write("\nDigite a letra que será colocada na tabela quando a linha e coluna forem ímpar: ");
    string letra = Console.ReadLine();

    for(int coluna = 0; coluna < tamanhoTabela; coluna++)
    {    
      if(coluna == 0)
      {
        Console.Write("      ");
        for(int contador = 1; contador <= tamanhoTabela; contador++)
        {
          if(contador < 10)
          {
            Console.Write($"0{contador}  ");
          }
          else
          {
            Console.Write($"{contador}  ");
          }
        }
        Console.Write("\n");
      }
      else
      {
        Console.Write("    ");
        for(int contador = 0; contador < tamanhoTabela; contador++)
        {
          if(contador == 0)
          {
            Console.Write("-----");
          }
          else
          {
            Console.Write("----");
          }
        }
        Console.Write("\n");
      }
      if ((coluna + 1) < 10)
      {
        Console.Write("0" + (coluna + 1) + "  |");
      }
      else
      {
        Console.Write((coluna + 1) + "  |");
      }
      for(int linha = 0; linha < tamanhoTabela; linha++)
      {
        if(linha % 2 == 1 && coluna % 2 == 1)
        {
            Console.Write($" {letra} ");
        }
        else
        {
            Console.Write("   ");
        }
        Console.Write("|");
      }
      Console.Write("\n");
    }
    Console.Write("    ");
      for(int contador = 0; contador < tamanhoTabela; contador++)
      {
        if(contador == 0)
        {
          Console.Write("-----");
        }
        else
        {
          Console.Write("----");
        }
      }
      Console.Write("\n");
  }
}