using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_DIAS_JANEIRO = 31;
        int contador = 1;

        while (contador <= NUMERO_DIAS_JANEIRO)
        {
            Console.WriteLine(contador + "º dia de janeiro");
            contador++;
        }
    }
}