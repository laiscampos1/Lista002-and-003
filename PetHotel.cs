using System;

public class PetHotel
{
    static void Main(string[] args)
    {
        
        ConsoleColor corBorda = ConsoleColor.Red;
        ConsoleColor corTitulo = ConsoleColor.Cyan;
        ConsoleColor corDados = ConsoleColor.Yellow;

        
        Console.Write("Espécie: ");
        string especie = Console.ReadLine();

        Console.Write("Raça: ");
        string raca = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Pelagem/cor: ");
        string pelagem = Console.ReadLine();

        Console.ForegroundColor = corBorda;
        Console.WriteLine("+=========================================================+");

        Console.ForegroundColor = corTitulo;
        Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");

        Console.ForegroundColor = corBorda;
        Console.WriteLine("+=========================================================+");

        Console.ForegroundColor = corDados;
        Console.WriteLine($"| Espécie: ............{especie,-15} | Raça: ............{raca,-15} |");

        Console.ForegroundColor = corBorda;
        Console.WriteLine("+=========================================================+");

        Console.ForegroundColor = corDados;
        Console.WriteLine($"| Atende pela alcunha de: ...........................{nome,-15} |");
        Console.WriteLine($"| Idade: {idade:00} ano(s) | Pelagem/cor: ...............{pelagem,-15} |");

        Console.ForegroundColor = corBorda;
        Console.WriteLine("+=========================================================+");


    }
}