using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Churrasco ---\n");

        
        Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
        int adultosComAlcool = Convert.ToInt32(Console.ReadLine());

        Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
        int adultosSemAlcool = Convert.ToInt32(Console.ReadLine());

        Console.Write("Crianças........................................: ");
        int criancas = Convert.ToInt32(Console.ReadLine());

        
        double carne = (adultosComAlcool + adultosSemAlcool) * 0.4 + criancas * 0.2; 
        double acompanhamentos = (adultosComAlcool + adultosSemAlcool + criancas) * 0.2;
        double cerveja = adultosComAlcool * 2.0; 
        double refrigerante = (adultosSemAlcool * 0.5) + (criancas * 0.5); 
        double agua = (adultosComAlcool + adultosSemAlcool + criancas) * 0.4; 

     
        Console.WriteLine("\n--- Quantidade necessária ---");
        Console.WriteLine($"Carne.............: {carne:F1}kg");
        Console.WriteLine($"Acompanhamentos...: {acompanhamentos:F1}kg");
        Console.WriteLine($"Cerveja...........: {cerveja:F1}l");
        Console.WriteLine($"Refrigerante......: {refrigerante:F1}l");
        Console.WriteLine($"Água..............: {agua:F1}l");
    }
}
