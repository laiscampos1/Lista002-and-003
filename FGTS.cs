using System;

public class FGTS
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cálculo do FGTS do funcionário");

        Console.Write("Digite o valor de seu salário: ");
        double salario = Convert.ToDouble(Console.ReadLine()); 

        double fgts = salario * 0.08; 

        Console.WriteLine($"O FGTS sobre um salário de R$ {salario:F2} é R$ {fgts:F2}");
    }
}
