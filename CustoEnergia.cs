using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de Consumo de Energia");

        Console.Write("Consumo do aparelho (em kWh/mês): ");
        double consumoMensal = double.Parse(Console.ReadLine());

        Console.Write("Horas de uso por dia: ");
        double horasUsoDiario = double.Parse(Console.ReadLine());

        Console.Write("Custo da energia (em R$/kWh): ");
        double custoKWh = double.Parse(Console.ReadLine());

        double consumoDiario = consumoMensal / 30;
        double consumoReal = consumoDiario * horasUsoDiario;
        double custoEstimado = consumoReal * custoKWh * 30;

        Console.WriteLine($"\nCusto estimado: R$ {custoEstimado:F2}");
        Console.ReadKey();
    }
}
