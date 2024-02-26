using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escolha um dos países para visitar:\n[1] - País do vento\n[2] - País do fogo\n");
        int paisEscolhido = int.Parse(Console.ReadLine());

        if(paisEscolhido == 1)
        {
            Console.Write("\nVocê escolheu o país do vento!\nEscolha um ponto de exploração para visitar:\n[1] - Aldeia da areia\n[2] - Mina\n[3] - Caatinga\n");
            int pontoDeExploracao = int.Parse(Console.ReadLine());

            if(pontoDeExploracao == 1)
            {
                Console.WriteLine("\nBem vindo à Aldeia da Areia!");
            }
            else if(pontoDeExploracao == 2)
            {
                Console.WriteLine("\nVocê chegou à mina!");
            }
            else if(pontoDeExploracao == 3)
            {
                Console.WriteLine("\nAqui fica a Caatinga!");
            }
            else
            {
                Console.WriteLine("\nLocal inexistente!");
            }
        }
        else if(paisEscolhido == 2)
        {
            Console.Write("\nVocê escolheu o país do fogo!\nEscolha um ponto de exploração para visitar:\n[1] - Aldeia da folha\n[2] - Floresta da morte\n");
            int pontoDeExploracao = int.Parse(Console.ReadLine());
            
            if(pontoDeExploracao == 1)
            {
                Console.WriteLine("\nBem vindo à Aldeia da Folha!");
            }
            else if(pontoDeExploracao == 2)
            {
                Console.WriteLine("\nVocê chegou à Floresta da Morte!");
            }
            else
            {
                Console.WriteLine("\nLocal inexistente!");
            }
        }
        else
        {
            Console.WriteLine("Local inexistente!");
        }
    }
}