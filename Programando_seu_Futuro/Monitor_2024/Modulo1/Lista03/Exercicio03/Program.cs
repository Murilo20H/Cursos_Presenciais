using System;

class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_TENTATIVAS = 3;
        string senhaCorreta = "123senha";
        string nomeUsuarioCorreto = "admin";
        int contador = 1;

        do
        {
            Console.Write("\nDigite o seu nome de usuário: ");
            string nomeUsuarioDigitado = Console.ReadLine();
            
            Console.Write("Digite a sua senha: ");
            string senhaDigitada = Console.ReadLine();
            
            if (nomeUsuarioCorreto == nomeUsuarioDigitado && senhaCorreta == senhaDigitada)
            {
                Console.Write("\nLogin realizado com sucesso");
                break;
            }
            contador++;
        }
        while (contador <= QUANTIDADE_TENTATIVAS);
        
        if (contador >  QUANTIDADE_TENTATIVAS)
        {
            Console.Write("\nSua conta foi bloqueada");
        }
    }
}