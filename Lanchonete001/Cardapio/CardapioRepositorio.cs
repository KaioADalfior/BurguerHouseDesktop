using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Cardapio
{
    /// <summary>
    /// Fonte única de dados do cardápio (lanches + bebidas), em memória por
    /// enquanto o projeto não tem banco de dados. UcLanches e UcBebidas leem
    /// e escrevem aqui, cada uma filtrando pelo seu Tipo.
    /// </summary>
    public static class CardapioRepositorio
    {
        public static List<ItemCardapio> Itens { get; private set; }

        static CardapioRepositorio()
        {
            Itens = new List<ItemCardapio>
            {
                new ItemCardapio
                {
                    Nome = "X-Bacon",
                    Categoria = "Hambúrgueres",
                    Descricao = "Pão brioche, hambúrguer, queijo prato e bacon",
                    PrecoVenda = 22.90m,
                    Tipo = TipoItemCardapio.Lanche,
                    Ingredientes = new List<IngredienteReceita>
                    {
                        new IngredienteReceita { NomeInsumo = "Pão brioche",          Quantidade = 1,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Hambúrguer 150g",      Quantidade = 1,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Queijo prato (fatia)", Quantidade = 2,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Bacon (fatia)",        Quantidade = 3,     Unidade = "un" },
                    }
                },
                new ItemCardapio
                {
                    Nome = "X-Salada",
                    Categoria = "Hambúrgueres",
                    Descricao = "Pão brioche, hambúrguer, queijo prato, alface e tomate",
                    PrecoVenda = 19.90m,
                    Tipo = TipoItemCardapio.Lanche,
                    Ingredientes = new List<IngredienteReceita>
                    {
                        new IngredienteReceita { NomeInsumo = "Pão brioche",          Quantidade = 1,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Hambúrguer 150g",      Quantidade = 1,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Queijo prato (fatia)", Quantidade = 1,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Alface",               Quantidade = 0.05m, Unidade = "kg" },
                        new IngredienteReceita { NomeInsumo = "Tomate",               Quantidade = 0.08m, Unidade = "kg" },
                    }
                },
                new ItemCardapio
                {
                    Nome = "X-Tudo",
                    Categoria = "Hambúrgueres",
                    Descricao = "Dois hambúrgueres, queijo em dobro, bacon, salada e molho especial",
                    PrecoVenda = 28.90m,
                    Tipo = TipoItemCardapio.Lanche,
                    Ingredientes = new List<IngredienteReceita>
                    {
                        new IngredienteReceita { NomeInsumo = "Pão brioche",          Quantidade = 1,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Hambúrguer 150g",      Quantidade = 2,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Queijo prato (fatia)", Quantidade = 2,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Bacon (fatia)",        Quantidade = 4,     Unidade = "un" },
                        new IngredienteReceita { NomeInsumo = "Alface",               Quantidade = 0.05m, Unidade = "kg" },
                        new IngredienteReceita { NomeInsumo = "Tomate",               Quantidade = 0.08m, Unidade = "kg" },
                        new IngredienteReceita { NomeInsumo = "Molho especial",       Quantidade = 0.03m, Unidade = "L"  },
                    }
                },
                new ItemCardapio
                {
                    Nome = "Refrigerante 300ml",
                    Categoria = "Refrigerantes",
                    Descricao = "Copo de refrigerante gelado, 300ml",
                    PrecoVenda = 7.50m,
                    Tipo = TipoItemCardapio.Bebida,
                    Ingredientes = new List<IngredienteReceita>
                    {
                        new IngredienteReceita { NomeInsumo = "Refrigerante (ml)",      Quantidade = 0.3m, Unidade = "L"  },
                        new IngredienteReceita { NomeInsumo = "Copo descartável 300ml", Quantidade = 1,    Unidade = "un" },
                    }
                },
                new ItemCardapio
                {
                    Nome = "Suco Natural 300ml",
                    Categoria = "Sucos",
                    Descricao = "Suco natural gelado, 300ml",
                    PrecoVenda = 9.00m,
                    Tipo = TipoItemCardapio.Bebida,
                    Ingredientes = new List<IngredienteReceita>
                    {
                        new IngredienteReceita { NomeInsumo = "Suco natural (ml)",      Quantidade = 0.3m, Unidade = "L"  },
                        new IngredienteReceita { NomeInsumo = "Copo descartável 300ml", Quantidade = 1,    Unidade = "un" },
                    }
                },
                new ItemCardapio
                {
                    Nome = "Água Mineral 500ml",
                    Categoria = "Águas",
                    Descricao = "Garrafa de água mineral sem gás, 500ml",
                    PrecoVenda = 5.00m,
                    Tipo = TipoItemCardapio.Bebida,
                    Ingredientes = new List<IngredienteReceita>
                    {
                        new IngredienteReceita { NomeInsumo = "Água mineral", Quantidade = 1, Unidade = "un" },
                    }
                },
            };
        }

        public static List<ItemCardapio> ObterLanches() => Itens.Where(i => i.Tipo == TipoItemCardapio.Lanche).ToList();

        public static List<ItemCardapio> ObterBebidas() => Itens.Where(i => i.Tipo == TipoItemCardapio.Bebida).ToList();

        public static void Adicionar(ItemCardapio item) => Itens.Add(item);

        public static void Remover(ItemCardapio item) => Itens.Remove(item);
    }
}