using System;

class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_POPULACAO = 3;
        double mediaSalario = 0;
        double mediaFilhos = 0;
        double maiorSalario = 0;
        double somatorioSalario = 0;
        double somatorioFilhos = 0;
        double salario = 0;
        double filhos = 0;

        for (int contador = 1; contador <= QUANTIDADE_POPULACAO; contador++)
        {
            Console.Write("Digite o salário da " + contador + "º pessoa: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de filhos da " + contador + "º pessoa: ");
            filhos = double.Parse(Console.ReadLine());

            somatorioSalario += salario;
            somatorioFilhos += filhos;
            if (contador == 0)
            {
                maiorSalario = salario;
            }
            else if (salario >= maiorSalario)
            {
                maiorSalario = salario;
            }
        }
        mediaSalario = somatorioSalario / QUANTIDADE_POPULACAO;
        mediaFilhos = somatorioFilhos / QUANTIDADE_POPULACAO;

        Console.Write("\nMedia salarial: R$" + Math.Round(mediaSalario, 2));
        Console.Write("\nMedia do numero de filhos por habitante: " + Math.Round(mediaFilhos, 2));
        Console.Write("\nMaior salario: R$" + maiorSalario);
    }
}