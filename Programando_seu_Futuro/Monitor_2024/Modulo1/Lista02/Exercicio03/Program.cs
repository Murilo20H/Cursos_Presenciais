using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome da criança: ");
        string nomeCrianca = Console.ReadLine();
        
        if(nomeCrianca == "Filomena")
        {
            Console.WriteLine("Rotina de Filomena:\n1. Escola das 07h as 12h\n2. Almoço das 12h as 13\n3. Futebol das 14h as 16h\n4. Dever de casa das 16h as 18h");
        }
        else if(nomeCrianca == "Joselito")
        {
            Console.WriteLine("Rotina de Joselito:\n1. Escola das 07h as 12:30\n2. Almoço das 13h as 14h\n3. Natação das 14h as 16h\n4. Reforço escolar das 16h as 19h");
        }
        else
        {
            Console.WriteLine("Nome invalido");
        }
    }
}