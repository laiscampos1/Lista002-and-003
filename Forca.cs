using System;

public class Forca
{
    static void Main(string[] args)
    {
        Console.Write("Qual a palavra secreta? ");
        string palavraSecreta = Console.ReadLine(); 

        Console.Write("Qual letra deseja verificar? ");
        char letra = Console.ReadKey().KeyChar; 
        Console.WriteLine();

        if (palavraSecreta.Contains(letra.ToString())) 
        {
            Console.WriteLine($"A letra '{letra}' existe na palavra secreta.");
        }
        else
        {
            Console.WriteLine($"A letra '{letra}' não existe na palavra secreta.");
        }
    }
}