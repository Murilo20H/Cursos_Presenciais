using System;

class Program
{
  const int TAMANHO_TABULEIRO = 3;
  static char[,] localEscolhido = new char[TAMANHO_TABULEIRO, TAMANHO_TABULEIRO];
  static bool jogoEncerrado = false;
  static char opcaoJogador = 'X';
  static string linhaDigitada;
  static string colunaDigitada;
  static int linhaEscolhida;
  static int colunaEscolhida;
  static char vencedor = ' ';
  static bool primeiraVez = true;
  static bool digitouErrado = false;
  static bool empate = false;
  static int quantidadeJogadas = 0;
  static void Main(string[] args)
  {
    localEscolhido[0, 0] = ' ';
    localEscolhido[0, 1] = ' ';
    localEscolhido[0, 2] = ' ';
    localEscolhido[1, 0] = ' ';
    localEscolhido[1, 1] = ' ';
    localEscolhido[1, 2] = ' ';
    localEscolhido[2, 0] = ' ';
    localEscolhido[2, 1] = ' ';
    localEscolhido[2, 2] = ' ';

    InicializarJogo();
  }

  public static void InicializarJogo()
  {
    MostrarTabuleiro();
    AcaoJogador();
    
    MostrarTabuleiro();
    AcaoJogador();

    MostrarTabuleiro();
    AcaoJogador();

    MostrarTabuleiro();
    AcaoJogador();
    
    MostrarTabuleiro();
    AcaoJogador();
    VerificarFinalizado();

    MostrarTabuleiro();
    AcaoJogador();
    VerificarFinalizado();

    MostrarTabuleiro();
    AcaoJogador();
    VerificarFinalizado();

    MostrarTabuleiro();
    AcaoJogador();
    VerificarFinalizado();

    MostrarTabuleiro();
    AcaoJogador();
    VerificarFinalizado();
  }

  public static void MostrarTabuleiro()
  {
    Console.Write("\n     A   B   C\n   -------------\n");
    Console.Write($"1  | {localEscolhido[0, 0]} | {localEscolhido[0, 1]} | {localEscolhido[0, 2]} |\n");
    Console.Write("   -------------\n");
    Console.Write($"2  | {localEscolhido[1, 0]} | {localEscolhido[1, 1]} | {localEscolhido[1, 2]} |\n");
    Console.Write("   -------------\n");
    Console.Write($"3  | {localEscolhido[2, 0]} | {localEscolhido[2, 1]} | {localEscolhido[2, 2]} |\n");
    Console.Write("   -------------\n");
  }

  public static void AcaoJogador()
  {
    if(primeiraVez == true)
    {
      Console.Write("Você usará X ou O: ");
      opcaoJogador = char.Parse(Console.ReadLine());
      primeiraVez = false;
    }
      
    Console.Write("Em qual linha você irá jogar (1, 2, 3): ");
    linhaDigitada = Console.ReadLine();

    Console.Write("Em qual coluna você irá jogar (A, B, C): ");
    colunaDigitada = Console.ReadLine();
    

      if (linhaDigitada == "1")
      {
        linhaEscolhida = 0;
      }
      else if (linhaDigitada == "2")
      {
        linhaEscolhida = 1;
      }
      else if (linhaDigitada == "3")
      {
        linhaEscolhida = 2;
      }
      else
      {
        Console.Write("\nVocê digitou uma linha inexistente, digite novamente:\n");
        digitouErrado = true;
      }
    

      if (colunaDigitada == "A" || colunaDigitada == "a")
      {
        colunaEscolhida = 0;
      }
      else if (colunaDigitada == "B" || colunaDigitada == "b")
      {
        colunaEscolhida = 1;
      }
      else if (colunaDigitada == "C" || colunaDigitada == "c")
      {
        colunaEscolhida = 2;
      }
      else
      {
        Console.Write("\nVocê digitou uma coluna inexistente, digite novamente:\n");
        digitouErrado = true;
      }
    

    if (digitouErrado)
    {
      digitouErrado = false;
      VerificarFinalizado();
      MostrarTabuleiro();
      AcaoJogador();
      VerificarFinalizado();
      return;
    }

    for (int linha = 0; linha < TAMANHO_TABULEIRO; linha++)
    {
      for (int coluna = 0; coluna < TAMANHO_TABULEIRO; coluna++)
      {
        if (linha == linhaEscolhida && coluna == colunaEscolhida && localEscolhido[linha, coluna] == ' ')
        {
          localEscolhido[linha, coluna] = opcaoJogador;
          quantidadeJogadas++;
          
          if (opcaoJogador == 'O' || opcaoJogador == 'o')
          {
            opcaoJogador = 'X';
          }
          else if (opcaoJogador == 'X' || opcaoJogador == 'x')
          {
            opcaoJogador = 'O';
          }
        }
        else if (linha == linhaEscolhida && coluna == colunaEscolhida && localEscolhido[linha, coluna] != ' ')
        {
          Console.Write("Local já escolhido, escolha novamente:\n");
        }
      }
    }
  }

  public static void VerificarFinalizado()
  {
    if (localEscolhido[0, 0] != ' ' && localEscolhido[0, 1] != ' ' && localEscolhido[0, 2] != ' ')
    {
      if(localEscolhido[0, 0] == 'X' && localEscolhido[0, 1] == 'X' && localEscolhido[0, 2] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[0, 0] == 'O' && localEscolhido[0, 1] == 'O' && localEscolhido[0, 2] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    }
    else if (localEscolhido[1, 0] != ' ' && localEscolhido[1, 1] != ' ' && localEscolhido[1, 2] != ' ')
    {
      if(localEscolhido[1, 0] == 'X' && localEscolhido[1, 1] == 'X' && localEscolhido[1, 2] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[1, 0] == 'O' && localEscolhido[1, 1] == 'O' && localEscolhido[1, 2] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    }
    else if (localEscolhido[2, 0] != ' ' && localEscolhido[2, 1] != ' ' && localEscolhido[2, 2] != ' ')
    {
      if(localEscolhido[2, 0] == 'X' && localEscolhido[2, 1] == 'X' && localEscolhido[2, 2] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[2, 0] == 'O' && localEscolhido[2, 1] == 'O' && localEscolhido[2, 2] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    }
    else if (localEscolhido[0, 0] != ' ' && localEscolhido[1, 0] != ' ' && localEscolhido[2, 0] != ' ')
    {
      if(localEscolhido[0, 0] == 'X' && localEscolhido[1, 0] == 'X' && localEscolhido[2, 0] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[0, 0] == 'O' && localEscolhido[1, 0] == 'O' && localEscolhido[2, 0] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    }
    else if (localEscolhido[0, 1] != ' ' && localEscolhido[1, 1] != ' ' && localEscolhido[2, 1] != ' ')
    {
      if(localEscolhido[0, 1] == 'X' && localEscolhido[1, 1] == 'X' && localEscolhido[2, 1] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[0, 0] == 'O' && localEscolhido[0, 1] == 'O' && localEscolhido[2, 1] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    } 
    else if (localEscolhido[0, 2] != ' ' && localEscolhido[1, 2] != ' ' && localEscolhido[2, 2] != ' ')
    {
      if(localEscolhido[0, 2] == 'X' && localEscolhido[1, 2] == 'X' && localEscolhido[2, 2] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[0, 2] == 'O' && localEscolhido[1, 2] == 'O' && localEscolhido[2, 2] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    }
    else if (localEscolhido[0, 0] != ' ' && localEscolhido[1, 1] != ' ' && localEscolhido[2, 2] != ' ')
    {
      if(localEscolhido[0, 0] == 'X' && localEscolhido[1, 1] == 'X' && localEscolhido[2, 2] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[0, 0] == 'O' && localEscolhido[1, 1] == 'O' && localEscolhido[2, 2] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    }  
    else if (localEscolhido[0, 2] != ' ' && localEscolhido[1, 1] != ' ' && localEscolhido[2, 0] != ' ')
    {
      if(localEscolhido[0, 2] == 'X' && localEscolhido[1, 1] == 'X' && localEscolhido[2, 0] == 'X')
      {
        jogoEncerrado = true;
        vencedor = 'X';
      }
      else if(localEscolhido[0, 2] == 'O' && localEscolhido[1, 1] == 'O' && localEscolhido[2, 0] == 'O')
      {
        jogoEncerrado = true;
        vencedor = 'O';
      }
    }

    if (jogoEncerrado == true)
    {
      Console.Clear();
      MostrarTabuleiro();
      Console.Write("O jogo terminou, o vencedor foi o jogador do " + vencedor + "!");
      Environment.Exit(0);
    } 
    else if (quantidadeJogadas == 9)
    {
      Console.Clear();
      MostrarTabuleiro();
      Console.Write("O jogo terminou, deu empate!");
      Environment.Exit(0);
    }
  }
}







// using System;

// class Program
// {
//   static void Main(string[] args)
//   {
//     int tamanhoTabuleiro = 3;
//     int contadorAuxiliar = 0;
//     string[,] tabuleiro = new string[tamanhoTabuleiro,tamanhoTabuleiro];
//     int colunaEscolhida = -1;
//     int linhaEscolhida = -1;
//     int[,] localEscolhido = new int[tamanhoTabuleiro,tamanhoTabuleiro];
//     bool jogoEstaFuncionando = true;
//     // Console.Write("Digite o tamanho da tabela: ");
//     // int tamanhoTabuleiro = int.Parse(Console.ReadLine());

//     // Console.Write("\nDigite a letra que será colocada na tabela quando a linha e coluna forem ímpar: ");
//     // string letra = Console.ReadLine();
//     for(contadorAuxiliar = contadorAuxiliar; jogoEstaFuncionando; contadorAuxiliar = contadorAuxiliar)
//     {

//       if(contadorAuxiliar < tamanhoTabuleiro){

//         for(int coluna = 0; coluna < tamanhoTabuleiro; coluna++)
//         {    
//           if(coluna == 0)
//           {
//             Console.Write("      ");
//             for(int contador = 1; contador <= tamanhoTabuleiro; contador++)
//             {
//               if(contador < 10)
//               {
//                 Console.Write($"0{contador}  ");
//               }
//               else
//               {
//                 Console.Write($"{contador}  ");
//               }
//             }
//             Console.Write("\n");
//           }
//           else
//           {
//             Console.Write("    ");
//             for(int contador = 0; contador < tamanhoTabuleiro; contador++)
//             {
//               if(contador == 0)
//               {
//                 Console.Write("-----");
//               }
//               else
//               {
//                 Console.Write("----");
//               }
//             }
//             Console.Write("\n");
//           }
//           if (coluna < 10)
//           {
//             Console.Write("0" + (coluna + 1) + "  |");
//           }
//           else
//           {
//             Console.Write((coluna + 1) + "  |");
//           }
//           for(int linha = 0; linha < tamanhoTabuleiro; linha++)
//           {
//             if(colunaEscolhida == coluna && linhaEscolhida == linha)
//             {
//               if(tabuleiro[coluna,linha] == "x")
//               {
//                 Console.Write("   ");
//               }
//               else if(tabuleiro[coluna, linha] == "o")
//               {
//                 Console.Write("   ");
//               }
//               else
//               {
//                 for(int i = 0; i < (tamanhoTabuleiro * tamanhoTabuleiro); i++)
//                 {
//                   if(i % 2 == 0)
//                   {
//                     Console.Write(" X ");
//                     tabuleiro[coluna,linha] = "x";
//                   }
//                   else
//                   {
//                     Console.Write(" O ");
//                     tabuleiro[coluna,linha] = "o";
//                   }
//                 }
//               }
//               Console.Write("|");
//             }
//           }
//           Console.Write("\n");
//           contadorAuxiliar++;
//         }
//       }
//       else if(contadorAuxiliar > tamanhoTabuleiro && contadorAuxiliar < (tamanhoTabuleiro * 2))
//       {

//         Console.Write("    ");
//           for(int contador = 0; contador < tamanhoTabuleiro; contador++)
//           {
//             if(contador == 0)
//             {
//               Console.Write("-----");
//             }
//             else
//             {
//               Console.Write("----");
//             }
//           }
//           Console.Write("\n");
//           Console.Write("Digite em qual coluna você quer jogar: ");
//           colunaEscolhida = int.Parse(Console.ReadLine());
//           Console.Write("Digite em qual linha você quer jogar: ");
//           linhaEscolhida = int.Parse(Console.ReadLine());
//           for(int i = 0; i <= tamanhoTabuleiro; i++)
//           {
//             for(int j = 0; j <= tamanhoTabuleiro; j++)
//             {
//               if(colunaEscolhida == i && linhaEscolhida == j)
//               {
//                 localEscolhido[i, j] = 1;
//               }
//             }
//           }
//           contadorAuxiliar++;

//       }
//     }
//     if(contadorAuxiliar == 6)
//     {
//       contadorAuxiliar = 0;
//     }

//       // localEscolhido[colunaEscolhida, linhaEscolhida] = 1;
//   }
// }