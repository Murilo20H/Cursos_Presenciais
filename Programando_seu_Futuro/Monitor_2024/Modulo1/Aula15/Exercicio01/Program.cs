using System;
struct Jogo
{
    public int id;
    public string nome;
    public double preco;
}
class Program
{
    static void Main(string[] args)
    {
        Jogo jogo1;
        jogo1.id = int.Parse(Console.ReadLine());
        jogo1.nome = Console.ReadLine();
        jogo1.preco = double.Parse(Console.ReadLine());

        Console.Write(jogo1.id + "\n" + jogo1.nome + "\n" + jogo1.preco);
    }
}