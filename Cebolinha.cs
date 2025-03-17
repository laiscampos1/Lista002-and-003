using System;

public class Cebolinha
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua frase: ");
        string frase = Console.ReadLine();

        string fraseCebolinha = frase.Replace("r", "l").Replace("R", "L");

        Console.WriteLine($"Sua frase ficará: {fraseCebolinha}");
    }
}

