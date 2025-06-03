using System;

public class VerificaParImpar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("ímpar");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}