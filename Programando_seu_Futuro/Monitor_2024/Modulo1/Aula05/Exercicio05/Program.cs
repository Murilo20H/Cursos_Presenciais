using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a idade da pessoa 1: ");
        int idade1 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite a idade da pessoa 2: ");
        int idade2 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite a idade da pessoa 3: ");
        int idade3 = int.Parse(Console.ReadLine());

        if(idade1 > idade2 && idade1 > idade3)
        {
            Console.WriteLine("A maior das três idades é: " + idade1);
        }
        else if(idade2 > idade1 && idade2 > idade3)
        {
            Console.WriteLine("A maior das três idades é: " + idade2);
        }
        else if(idade3 > idade1 && idade3 > idade2)
        {
            Console.WriteLine("A maior das três idades é: " + idade3);
        }
        else
        {
            Console.WriteLine("As idades são iguais");
        }
    }
}