using System;

public class NomeCompleto
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = $"{nome} {sobrenome}";
        string nomeCatalogo = $"{sobrenome.ToUpper()}, {nome}";

        Console.WriteLine($"Nome completo: {nomeCompleto}");
        Console.WriteLine($"Nome no catálogo: {nomeCatalogo}");
    }
}