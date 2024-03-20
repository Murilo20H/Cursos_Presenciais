using System;

public class Program
{
    public static void Main(string[] args)
    {
        int tamanho = 9;
        for (int contadorExterno = tamanho; contadorExterno >= 1; contadorExterno--)
        {
            for (int contadorInterno = 1; contadorInterno <= contadorExterno; contadorInterno++)
            {
                Console.Write(contadorInterno);
            }
            Console.Write("\n");
        }
    }
}