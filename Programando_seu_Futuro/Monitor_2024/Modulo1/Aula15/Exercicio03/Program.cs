using System;
struct Heroi
{
    public int id;
    public string nome;
    public int level;
}
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 3;
        Heroi[] herois = new Heroi[TAMANHO_VETOR];
        for (int contador = 0; contador < herois.Length; contador++) 
        {
            herois[contador].id = int.Parse(Console.ReadLine());
            herois[contador].nome = Console.ReadLine();
            herois[contador].level = int.Parse(Console.ReadLine());
        }
    
        GroupLevelUp(herois);
        
        for (int contador = 0; contador < herois.Length; contador++) 
        {
            Console.WriteLine(herois[contador].id);
            Console.WriteLine(herois[contador].nome);
            Console.WriteLine(herois[contador].level);
        }
    }

    public static void GroupLevelUp(Heroi[] herois) 
    {
        for (int contador = 0; contador < herois.Length; contador++) 
        {
            herois[contador].level = herois[contador].level + 1;
        }
    }
}
// Quando você passa uma struct como parâmetro em C#, uma cópia da struct é passada para a função. No entanto, ao modificar a cópia dentro da função, a modificação será refletida na estrutura original, não em uma cópia separada.

// Portanto, quando você chama a função GroupLevelUp(herois), está passando uma cópia do array herois. Mas, como Heroi é uma struct, as alterações feitas nos elementos do array dentro da função GroupLevelUp serão refletidas no array original.

// Em resumo, mesmo que uma cópia do array herois seja passada para a função GroupLevelUp, as alterações feitas dentro da função serão feitas no array original, porque cada elemento da struct é copiado por valor e não por referência.