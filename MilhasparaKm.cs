using System;

public class ConversorMilhasKmSimples
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Milhas para Quilômetros");

        Console.Write("Digite a distância em milhas: ");
        string valorMilhas = Console.ReadLine();
        double milhas = double.Parse(valorMilhas);

        double quilometros = milhas * 1.609;

        Console.WriteLine(milhas + " milhas é igual a " + quilometros + " quilômetros");
        Console.ReadKey(); 
    }
}
