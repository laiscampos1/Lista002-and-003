using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a altura do retângulo (1-10): ");
        int altura = int.Parse(Console.ReadLine());

        Console.Write("Digite a largura do retângulo (1-10): ");
        int largura = int.Parse(Console.ReadLine());

        Console.WriteLine("\nContorno do retângulo:");

        
        Console.WriteLine(new string('*', largura));

        
        for (int i = 2; i < altura; i++)
        {
            Console.Write("*");
            Console.Write(new string(' ', largura - 2)); 
            Console.WriteLine("*"); 
        }

        if (altura > 1)
        {
            Console.WriteLine(new string('*', largura));
        }
    }
}