using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Noite de Terror ---");

        string[] meses = {
            "O Zumbi", "O Assassino", "O Psicopata", "O Alienígena", "O Carniceiro", "O Matador",
            "O Vampiro", "O Maluco", "O Vingador", "O Monstro", "O Bruxo", "O Demônio"
        };

        string[] dias = {
            "",
            "Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído", "Macabro",
            "Sombrio", "Sem Cabeça", "Desconhecido", "Inconsciente", "Oculto", "Esquecido",
            "Lúgubre", "Invocado", "Caído", "Costurado", "Amaldiçoado", "Anormal",
            "Perturbado", "Sanguinário", "Tenebroso", "Imortal", "Ressuscitado",
            "do Pântano", "da Encruzilhada", "do Porão", "do Velho Poço", "sem Perdão",
            "do Cemitério", "da Meia-Noite", "da Lua Cheia"
        };

        int dia, mes;

        Console.Write("Qual o dia de nascimento da vítima (1 a 31): ");
        while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
        {
            Console.Write("Dia inválido! Digite um valor entre 1 e 31: ");
        }

        Console.Write("Qual o mês de nascimento da vítima (1 a 12): ");
        while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
        {
            Console.Write("Mês inválido! Digite um valor entre 1 e 12: ");
        }

        string monstro = meses[mes - 1];
        string sobrenome = dias[dia];

        Console.WriteLine($"\nFuja! Lá vem {monstro} {sobrenome}!");
    }
}