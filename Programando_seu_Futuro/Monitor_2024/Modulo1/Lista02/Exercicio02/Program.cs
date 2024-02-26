using System;

class Program
{
    static void Main(string[] args)
    {
        const int quantidadeNotas = 4;

        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());
        
        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());
        
        double media = (nota1 + nota2 + nota3 + nota4) / quantidadeNotas;
        
        if(media >= 5)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if(media < 5 && media >= 3)
        {
            Console.WriteLine("Aluno em recuperacao");
        }
        else if(media < 3)
        {
            Console.WriteLine("Aluno reprovado");
        }
    }
}