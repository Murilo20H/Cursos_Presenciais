using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome de usuário: ");
        string nomeUsuario = Console.ReadLine();
        
        Console.Write("Digite sua senha: ");
        string senhaUsuario = Console.ReadLine();
        
        if(nomeUsuario == "admin" && senhaUsuario == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas...");
        }
    }
}