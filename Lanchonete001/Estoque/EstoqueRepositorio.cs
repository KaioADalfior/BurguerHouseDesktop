using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Estoque
{
    /// <summary>
    /// Fonte única de dados de Insumos, compartilhada entre a tela de Estoque
    /// e o Cardápio (Lanches/Bebidas), que consome os insumos nas receitas.
    ///
    /// Hoje os dados vivem em memória (lista estática). Quando o projeto for
    /// para banco de dados, basta trocar a implementação interna deste
    /// repositório (por ex. lendo de um DbContext) — nada na UI precisa mudar,
    /// pois UcEstoque, UcLanches e UcBebidas só conhecem esta classe.
    /// </summary>
    public static class EstoqueRepositorio
    {
        public static List<Insumo> Insumos { get; private set; }

        static EstoqueRepositorio()
        {
            Insumos = new List<Insumo>
            {
                new Insumo { Nome = "Bacon (fatia)",          Categoria = "Carnes",                    QuantidadeAtual = 48,   Unidade = "un", QuantidadeMinima = 20,  PrecoUnitario = 0.80m },
                new Insumo { Nome = "Pão brioche",            Categoria = "Pães",                       QuantidadeAtual = 15,   Unidade = "un", QuantidadeMinima = 30,  PrecoUnitario = 1.20m },
                new Insumo { Nome = "Hambúrguer 150g",        Categoria = "Carnes",                     QuantidadeAtual = 60,   Unidade = "un", QuantidadeMinima = 25,  PrecoUnitario = 4.50m },
                new Insumo { Nome = "Queijo prato (fatia)",   Categoria = "Laticínios",                 QuantidadeAtual = 8,    Unidade = "un", QuantidadeMinima = 20,  PrecoUnitario = 0.60m },
                new Insumo { Nome = "Alface",                 Categoria = "Vegetais",                   QuantidadeAtual = 2.5m, Unidade = "kg", QuantidadeMinima = 3,   PrecoUnitario = 6.00m },
                new Insumo { Nome = "Tomate",                 Categoria = "Vegetais",                   QuantidadeAtual = 4m,   Unidade = "kg", QuantidadeMinima = 3,   PrecoUnitario = 7.00m },
                new Insumo { Nome = "Molho especial",         Categoria = "Molhos",                     QuantidadeAtual = 3m,   Unidade = "L",  QuantidadeMinima = 1,   PrecoUnitario = 18.00m },
                new Insumo { Nome = "Refrigerante (ml)",      Categoria = "Bebidas/Insumos líquidos",   QuantidadeAtual = 12,   Unidade = "L",  QuantidadeMinima = 10,  PrecoUnitario = 6.00m },
                new Insumo { Nome = "Suco natural (ml)",      Categoria = "Bebidas/Insumos líquidos",   QuantidadeAtual = 8,    Unidade = "L",  QuantidadeMinima = 5,   PrecoUnitario = 9.00m },
                new Insumo { Nome = "Água mineral",           Categoria = "Bebidas/Insumos líquidos",   QuantidadeAtual = 40,   Unidade = "un", QuantidadeMinima = 20,  PrecoUnitario = 1.50m },
                new Insumo { Nome = "Copo descartável 300ml", Categoria = "Embalagens",                 QuantidadeAtual = 200,  Unidade = "un", QuantidadeMinima = 100, PrecoUnitario = 0.15m },
                new Insumo { Nome = "Copo descartável 500ml", Categoria = "Embalagens",                 QuantidadeAtual = 150,  Unidade = "un", QuantidadeMinima = 100, PrecoUnitario = 0.20m },
            };
        }

        public static Insumo BuscarPorNome(string nome)
        {
            return Insumos.FirstOrDefault(i => i.Nome == nome);
        }

        public static List<string> ListarNomes()
        {
            return Insumos.Select(i => i.Nome).OrderBy(n => n).ToList();
        }
    }
}