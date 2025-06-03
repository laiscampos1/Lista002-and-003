using System;
using System.Collections.Generic;

class Program
{
    class Produto
    {
        public string GTIN { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoVarejo { get; set; }
        public decimal? PrecoAtacado { get; set; }
        public int? UnidadesAtacado { get; set; }
    }

    class ItemCompra
    {
        public string GTIN { get; set; }
        public int Quantidade { get; set; }
        public decimal Parcial { get; set; }
    }

    static void Main()
    {
        var catalogo = new List<Produto>
        {
            new Produto { GTIN = "7891024110348", Descricao = "SABONETE OLEO DE ARGAN 90G PALMOLIVE", PrecoVarejo = 2.88m, PrecoAtacado = 2.51m, UnidadesAtacado = 12 },
            new Produto { GTIN = "7891048038017", Descricao = "CHÁ DE CAMOMILA DR.OETKER", PrecoVarejo = 4.40m, PrecoAtacado = 4.37m, UnidadesAtacado = 3 },
            new Produto { GTIN = "7896066334509", Descricao = "TORRADA TRADICIONAL WICKBOLD PACOTE 140G", PrecoVarejo = 5.19m, PrecoAtacado = null, UnidadesAtacado = null },
            new Produto { GTIN = "7891700203142", Descricao = "BEBIDA À BASE DE SOJA MAÇÃ ADES CAIXA 200ML", PrecoVarejo = 2.39m, PrecoAtacado = 2.38m, UnidadesAtacado = 6 },
            new Produto { GTIN = "7894321711263", Descricao = "ACHOCOLATADO PÓ ORIGINAL TODDY POTE 400G", PrecoVarejo = 9.79m, PrecoAtacado = null, UnidadesAtacado = null },
            new Produto { GTIN = "7896001250611", Descricao = "ADOÇANTE LÍQUIDO SUCRALOSE LINEA CAIXA 25ML", PrecoVarejo = 9.89m, PrecoAtacado = 9.10m, UnidadesAtacado = 10 },
            new Produto { GTIN = "7793306013029", Descricao = "CEREAL MATINAL CHOCOLATE KELLOGGS SUCRILHOS CAIXA 320G", PrecoVarejo = 12.79m, PrecoAtacado = 12.35m, UnidadesAtacado = 3 },
            new Produto { GTIN = "7896004400914", Descricao = "COCO RALADO SOCOCO 50G", PrecoVarejo = 4.20m, PrecoAtacado = 4.05m, UnidadesAtacado = 6 },
            new Produto { GTIN = "7898080640017", Descricao = "LEITE UHT INTEGRAL 1L COM TAMPA ITALAC", PrecoVarejo = 6.99m, PrecoAtacado = 6.89m, UnidadesAtacado = 12 },
            new Produto { GTIN = "7891025301516", Descricao = "DANONINHO PETIT SUISSE COM POLPA DE MORANGO 360G DANONE", PrecoVarejo = 12.99m, PrecoAtacado = null, UnidadesAtacado = null },
            new Produto { GTIN = "7891030003115", Descricao = "CREME DE LEITE LEVE 200G MOCOCA", PrecoVarejo = 3.12m, PrecoAtacado = 3.09m, UnidadesAtacado = 4 }
        };

        var compras = new List<ItemCompra>
        {
            new ItemCompra { GTIN = "7891048038017", Quantidade = 1, Parcial = 4.40m },
            new ItemCompra { GTIN = "7896004400914", Quantidade = 4, Parcial = 16.80m },
            new ItemCompra { GTIN = "7891030003115", Quantidade = 1, Parcial = 3.12m },
            new ItemCompra { GTIN = "7891024110348", Quantidade = 6, Parcial = 17.28m },
            new ItemCompra { GTIN = "7898080640017", Quantidade = 24, Parcial = 167.76m },
            new ItemCompra { GTIN = "7896004400914", Quantidade = 8, Parcial = 33.60m },
            new ItemCompra { GTIN = "7891700203142", Quantidade = 8, Parcial = 19.12m },
            new ItemCompra { GTIN = "7891048038017", Quantidade = 1, Parcial = 4.40m },
            new ItemCompra { GTIN = "7793306013029", Quantidade = 3, Parcial = 38.37m },
            new ItemCompra { GTIN = "7896066334509", Quantidade = 2, Parcial = 10.38m }
        };

        var comprasAgrupadas = new Dictionary<string, ItemCompra>();
        foreach (var item in compras)
        {
            if (comprasAgrupadas.ContainsKey(item.GTIN))
            {
                comprasAgrupadas[item.GTIN].Quantidade += item.Quantidade;
                comprasAgrupadas[item.GTIN].Parcial += item.Parcial;
            }
            else
            {
                comprasAgrupadas[item.GTIN] = new ItemCompra
                {
                    GTIN = item.GTIN,
                    Quantidade = item.Quantidade,
                    Parcial = item.Parcial
                };
            }
        }

        var descontos = new Dictionary<string, decimal>();
        decimal subtotal = 0;
        decimal totalDescontos = 0;

        foreach (var item in comprasAgrupadas)
        {
            subtotal += item.Value.Parcial;
            
            var produto = catalogo.Find(p => p.GTIN == item.Key);
            if (produto?.PrecoAtacado != null && produto.UnidadesAtacado != null)
            {
                int lotesAtacado = item.Value.Quantidade / produto.UnidadesAtacado.Value;
                if (lotesAtacado > 0)
                {
                    decimal desconto = (produto.PrecoVarejo - produto.PrecoAtacado.Value) * 
                                     produto.UnidadesAtacado.Value * lotesAtacado;
                    descontos[produto.GTIN] = desconto;
                    totalDescontos += desconto;
                }
            }
        }

        Console.WriteLine("--- Desconto no Atacado ---\n");
        Console.WriteLine("Descontos:");

        foreach (var desconto in descontos)
        {
            Console.WriteLine($"{desconto.Key}\tR$ {desconto.Value:F2}");
        }

        Console.WriteLine($"\n(+) Subtotal  =    R$ {subtotal:F2}");
        Console.WriteLine($"(-) Descontos =      R$ {totalDescontos:F2}");
        Console.WriteLine($"(=) Total     =    R$ {subtotal - totalDescontos:F2}");
    }
}