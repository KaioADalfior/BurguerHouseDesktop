using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Produtos
{
    /// <summary>
    /// Fonte única de dados dos lanches cadastrados, em memória por
    /// enquanto (sem banco de dados ainda) — mesmo espírito do
    /// MesaRepositorio. Uma tela de cadastro (ex.: UcProdutos) pode ler e
    /// escrever aqui; o FrmPedidoMesa só lê a lista para popular o combo.
    /// </summary>
    public static class ProdutoRepositorio
    {
        public static List<Produto> Produtos { get; } = new List<Produto>();

        private static int _proximoId = 1;

        static ProdutoRepositorio()
        {
            // Alguns lanches de exemplo, só para o combo já nascer com
            // opções e o fluxo do FrmPedidoMesa poder ser testado de
            // ponta a ponta. Pode apagar/ajustar à vontade, ou remover
            // este construtor assim que houver uma tela de cadastro real.
            Adicionar("X-Burguer", 18.90m, "Lanches");
            Adicionar("X-Bacon", 21.90m, "Lanches");
            Adicionar("X-Salada", 19.90m, "Lanches");
            Adicionar("Batata Frita", 12.00m, "Porções");
            Adicionar("Refrigerante Lata", 6.00m, "Bebidas");
            Adicionar("Suco Natural", 8.50m, "Bebidas");
        }

        /// <summary>Cadastra um novo produto e devolve o objeto criado (com Id preenchido).</summary>
        public static Produto Adicionar(string nome, decimal preco, string categoria = null)
        {
            var produto = new Produto
            {
                Id = _proximoId++,
                Nome = nome,
                Preco = preco,
                Categoria = categoria,
                Ativo = true
            };

            Produtos.Add(produto);
            return produto;
        }

        /// <summary>Atualiza os dados de um produto já cadastrado.</summary>
        public static void Atualizar(int id, string nome, decimal preco, string categoria = null)
        {
            var produto = ObterPorId(id);
            if (produto == null) return;

            produto.Nome = nome;
            produto.Preco = preco;
            produto.Categoria = categoria;
        }

        /// <summary>
        /// Remove definitivamente o produto da lista. Prefira Inativar()
        /// se o produto já tiver sido usado em pedidos/relatórios antigos.
        /// </summary>
        public static void Remover(int id)
        {
            var produto = ObterPorId(id);
            if (produto != null)
            {
                Produtos.Remove(produto);
            }
        }

        /// <summary>Marca/desmarca o produto como ativo, sem apagar o cadastro.</summary>
        public static void DefinirAtivo(int id, bool ativo)
        {
            var produto = ObterPorId(id);
            if (produto != null)
            {
                produto.Ativo = ativo;
            }
        }

        public static Produto ObterPorId(int id)
        {
            return Produtos.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>Lista só os produtos ativos — a que o ComboBox do FrmPedidoMesa deveria usar.</summary>
        public static List<Produto> ObterAtivos()
        {
            return Produtos.Where(p => p.Ativo).OrderBy(p => p.Nome).ToList();
        }
    }
}