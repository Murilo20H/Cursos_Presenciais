using System;

class Program
{
    static void Main(string[] args)
    {
        const string RESPOSTA_CORRETA = "Karpov";
        const int PONTUACAO_INCIAL = 100;
        const int NUMERO_MAXIMO_TENTATIVAS = 3;

        int contadorTentativas = 1;
        
        do
        {
            Console.Write("\n[Dica] - Foi campeão mundial de xadrez");       
            Console.Write("\nDigite o valor do campo: ");       
            string repostaUsuario = Console.ReadLine();
            
            if (repostaUsuario == RESPOSTA_CORRETA)
            {
                double pontuacaoFinal = PONTUACAO_INCIAL / contadorTentativas;
                Console.Write("\nVocê acertou!! A sua pontuação foi " + pontuacaoFinal);
                break;
            }
            contadorTentativas++;
        } 
        while (contadorTentativas <= NUMERO_MAXIMO_TENTATIVAS);

        if (contadorTentativas > NUMERO_MAXIMO_TENTATIVAS)
        {
            Console.Write("\nGame over!");
        }
    }
}