using System;
struct Enxadrista
{
    public int id;
    public string nome;
    public double rating;
}
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;
        Enxadrista[] enxadristas = new Enxadrista[TAMANHO_VETOR];
        for (int contador = 0; contador < enxadristas.Length; contador++) 
        {
            enxadristas[contador].id = int.Parse(Console.ReadLine());
            enxadristas[contador].nome = Console.ReadLine();
            enxadristas[contador].rating = int.Parse(Console.ReadLine());
        }
        
        for (int contador = enxadristas.Length - 1; contador >= 0; contador--) 
        {
            Console.WriteLine(enxadristas[contador].id);
            Console.WriteLine(enxadristas[contador].nome);
            Console.WriteLine(enxadristas[contador].rating);
        }
    }
}