using Lanchonete001.BancoDados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Lanchonete001.Cardapio
{
    /// <summary>
    /// Acesso a dados de Lanches e Bebidas, direto no MySQL (banco BurguerHouse).
    /// Cada item guarda sua receita em ingredientes_receita, referenciando os
    /// insumos do estoque por Id (insumo_id).
    /// </summary>
    public static class CardapioRepositorio
    {
        public static List<ItemCardapio> ObterLanches() => Listar(TipoItemCardapio.Lanche);

        public static List<ItemCardapio> ObterBebidas() => Listar(TipoItemCardapio.Bebida);

        private static List<ItemCardapio> Listar(TipoItemCardapio tipo)
        {
            var itens = new List<ItemCardapio>();

            const string sql = @"
                SELECT id, nome, categoria, descricao, preco_venda, ativo, tipo
                FROM itens_cardapio
                WHERE tipo = @tipo
                ORDER BY nome";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@tipo", tipo.ToString());

                using (var leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                        itens.Add(MapearItem(leitor));
                }
            }

            foreach (var item in itens)
                item.Ingredientes = ListarIngredientes(item.Id);

            return itens;
        }

        private static List<IngredienteReceita> ListarIngredientes(int itemCardapioId)
        {
            var ingredientes = new List<IngredienteReceita>();

            const string sql = @"
                SELECT ir.insumo_id, i.nome AS nome_insumo, ir.quantidade, ir.unidade
                FROM ingredientes_receita ir
                INNER JOIN insumos i ON i.id = ir.insumo_id
                WHERE ir.item_cardapio_id = @itemCardapioId";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@itemCardapioId", itemCardapioId);

                using (var leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        ingredientes.Add(new IngredienteReceita
                        {
                            InsumoId = leitor.GetInt32("insumo_id"),
                            NomeInsumo = leitor.GetString("nome_insumo"),
                            Quantidade = leitor.GetDecimal("quantidade"),
                            Unidade = leitor.GetString("unidade")
                        });
                    }
                }
            }

            return ingredientes;
        }

        /// <summary>Insere um novo item + sua receita. Retorna o Id gerado.</summary>
        public static int Inserir(ItemCardapio item)
        {
            const string sqlItem = @"
                INSERT INTO itens_cardapio (nome, categoria, descricao, preco_venda, ativo, tipo)
                VALUES (@nome, @categoria, @descricao, @preco, @ativo, @tipo);
                SELECT LAST_INSERT_ID();";

            using (var conexao = ConexaoBanco.ObterConexao())
            {
                int itemId;
                using (var cmd = new MySqlCommand(sqlItem, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", item.Nome);
                    cmd.Parameters.AddWithValue("@categoria", item.Categoria);
                    cmd.Parameters.AddWithValue("@descricao", item.Descricao ?? "");
                    cmd.Parameters.AddWithValue("@preco", item.PrecoVenda);
                    cmd.Parameters.AddWithValue("@ativo", item.Ativo);
                    cmd.Parameters.AddWithValue("@tipo", item.Tipo.ToString());

                    itemId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                InserirIngredientes(conexao, itemId, item.Ingredientes);
                item.Id = itemId;
                return itemId;
            }
        }

        /// <summary>Atualiza um item existente e substitui sua receita por completo.</summary>
        public static void Atualizar(ItemCardapio item)
        {
            const string sqlItem = @"
                UPDATE itens_cardapio
                SET nome = @nome, categoria = @categoria, descricao = @descricao,
                    preco_venda = @preco, ativo = @ativo
                WHERE id = @id";

            const string sqlLimpaIngredientes = "DELETE FROM ingredientes_receita WHERE item_cardapio_id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            {
                using (var cmd = new MySqlCommand(sqlItem, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", item.Nome);
                    cmd.Parameters.AddWithValue("@categoria", item.Categoria);
                    cmd.Parameters.AddWithValue("@descricao", item.Descricao ?? "");
                    cmd.Parameters.AddWithValue("@preco", item.PrecoVenda);
                    cmd.Parameters.AddWithValue("@ativo", item.Ativo);
                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(sqlLimpaIngredientes, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.ExecuteNonQuery();
                }

                InserirIngredientes(conexao, item.Id, item.Ingredientes);
            }
        }

        private static void InserirIngredientes(MySqlConnection conexao, int itemCardapioId, List<IngredienteReceita> ingredientes)
        {
            const string sql = @"
                INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
                VALUES (@itemCardapioId, @insumoId, @quantidade, @unidade)";

            foreach (var ing in ingredientes)
            {
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@itemCardapioId", itemCardapioId);
                    cmd.Parameters.AddWithValue("@insumoId", ing.InsumoId);
                    cmd.Parameters.AddWithValue("@quantidade", ing.Quantidade);
                    cmd.Parameters.AddWithValue("@unidade", ing.Unidade);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>Remove o item; a receita some junto por causa do ON DELETE CASCADE.</summary>
        public static void Remover(ItemCardapio item)
        {
            const string sql = "DELETE FROM itens_cardapio WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.ExecuteNonQuery();
            }
        }

        private static ItemCardapio MapearItem(MySqlDataReader leitor)
        {
            return new ItemCardapio
            {
                Id = leitor.GetInt32("id"),
                Nome = leitor.GetString("nome"),
                Categoria = leitor.IsDBNull(leitor.GetOrdinal("categoria")) ? "" : leitor.GetString("categoria"),
                Descricao = leitor.IsDBNull(leitor.GetOrdinal("descricao")) ? "" : leitor.GetString("descricao"),
                PrecoVenda = leitor.GetDecimal("preco_venda"),
                Ativo = leitor.GetBoolean("ativo"),
                Tipo = leitor.GetString("tipo") == "Lanche" ? TipoItemCardapio.Lanche : TipoItemCardapio.Bebida
            };
        }
    }
}