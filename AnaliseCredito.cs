using System;

public class AnaliseCredito
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual o valor do empréstimo desejado?");
        if (!decimal.TryParse(Console.ReadLine(), out decimal valorEmprestimo))
        {
            Console.WriteLine("Valor do empréstimo inválido.");
            return;
        }

        Console.WriteLine("Em quantas parcelas deseja pagar?");
        if (!int.TryParse(Console.ReadLine(), out int quantidadeParcelas) || quantidadeParcelas <= 0)
        {
            Console.WriteLine("Quantidade de parcelas inválida.");
            return;
        }

        Console.WriteLine("Qual a sua renda mensal comprovada?");
        if (!decimal.TryParse(Console.ReadLine(), out decimal rendaMensal))
        {
            Console.WriteLine("Renda mensal inválida.");
            return;
        }

        decimal valorParcela = valorEmprestimo / quantidadeParcelas;
        decimal limiteParcela = 0.30m * rendaMensal;

        Console.WriteLine($"Valor da parcela: {valorParcela:C2}");
        Console.WriteLine($"Limite de 30% da renda: {limiteParcela:C2}");

        if (valorParcela <= limiteParcela)
        {
            Console.WriteLine("Empréstimo APROVADO!");
        }
        else
        {
            Console.WriteLine("Empréstimo NÃO APROVADO. O valor da parcela excede 30% da sua renda.");
        }
    }
}