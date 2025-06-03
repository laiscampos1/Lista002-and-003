using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Informe o salário por hora: R$ ");
        double salarioHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o total de horas trabalhadas: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o número de horas extras: ");
        double horasExtras = Convert.ToDouble(Console.ReadLine());

        double salarioTotal = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);

        Console.WriteLine($"\nSalário total: R$ {salarioTotal:F2}");
    }

    static double CalcularSalario(double salarioHora, double horasTrabalhadas, double horasExtras)
    {
        double valorHorasNormais = salarioHora * horasTrabalhadas;
        double valorHorasExtras = horasExtras * (salarioHora * 1.4); // 40% a mais

        return valorHorasNormais + valorHorasExtras;
    }
}
