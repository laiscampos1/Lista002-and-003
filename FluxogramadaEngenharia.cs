using System;

public class FluxogramaEngenharia
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Fluxograma da Engenharia ---");

        Console.Write("O objeto está se movendo (S/N)? ");
        string estaMovendoInput = Console.ReadLine()?.ToUpper();

        if (estaMovendoInput == "N")
        {
            Console.Write("Deveria? (S/N)? ");
            string deveriaMoverInput = Console.ReadLine()?.ToUpper();

            if (deveriaMoverInput == "S")
            {
                Console.WriteLine("\nUse WD-40.");
            }
            else if (deveriaMoverInput == "N")
            {
                Console.WriteLine("\nÓtimo!");
            }
            else
            {
                Console.WriteLine("\nResposta inválida.");
            }
        }
        else if (estaMovendoInput == "S")
        {
            Console.Write("Deveria? (S/N)? ");
            string deveriaMoverInput = Console.ReadLine()?.ToUpper();

            if (deveriaMoverInput == "N")
            {
                Console.WriteLine("\nUse Silver Tape.");
            }
            else if (deveriaMoverInput == "S")
            {
                Console.WriteLine("\nAlgo está muito errado...");
            }
            else
            {
                Console.WriteLine("\nResposta inválida.");
            }
        }
        else
        {
            Console.WriteLine("\nResposta inválida.");
        }

        Console.WriteLine("--- Fluxograma da Engenharia ---");
    }
}