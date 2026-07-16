using Lanchonete001.BancoDados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Estoque
{
    /// <summary>
    /// Acesso a dados de Insumos, direto no MySQL via ConexaoBanco.
    /// Substitui a antiga lista estática em memória. Compartilhado entre a
    /// tela de Estoque e o Cardápio (Lanches/Bebidas), que consulta os
    /// insumos disponíveis nas receitas.
    /// </summary>
    public static class EstoqueRepositorio
    {
        /// <summary>Lista insumos do banco, com filtro opcional por texto e por categoria.</summary>
        public static List<Insumo> Listar(string termoBusca = null, string categoria = null)
        {
            var insumos = new List<Insumo>();

            const string sql = @"
                SELECT id, nome, categoria, quantidade_atual, unidade, quantidade_minima, preco_unitario
                FROM insumos
                WHERE (@termo IS NULL OR nome LIKE @termo)
                  AND (@categoria IS NULL OR categoria = @categoria)
                ORDER BY nome";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@termo", string.IsNullOrWhiteSpace(termoBusca) ? (object)DBNull.Value : "%" + termoBusca.Trim() + "%");
                cmd.Parameters.AddWithValue("@categoria", string.IsNullOrWhiteSpace(categoria) ? (object)DBNull.Value : categoria);

                using (var leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                        insumos.Add(MapearInsumo(leitor));
                }
            }

            return insumos;
        }

        /// <summary>Busca um insumo específico pelo nome (usado pelo Cardápio ao montar receitas).</summary>
        public static Insumo BuscarPorNome(string nome)
        {
            const string sql = @"
                SELECT id, nome, categoria, quantidade_atual, unidade, quantidade_minima, preco_unitario
                FROM insumos
                WHERE nome = @nome
                LIMIT 1";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);

                using (var leitor = cmd.ExecuteReader())
                {
                    if (!leitor.Read()) return null;
                    return MapearInsumo(leitor);
                }
            }
        }

        /// <summary>Lista só os nomes dos insumos (usado em combos do Cardápio).</summary>
        public static List<string> ListarNomes()
        {
            var nomes = new List<string>();
            const string sql = "SELECT nome FROM insumos ORDER BY nome";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                    nomes.Add(leitor.GetString("nome"));
            }

            return nomes;
        }

        /// <summary>Verifica se já existe outro insumo com esse nome (para validação de formulário).</summary>
        public static bool ExisteNome(string nome, int? ignorarId = null)
        {
            const string sql = @"SELECT COUNT(1) FROM insumos WHERE nome = @nome AND (@ignorarId IS NULL OR id <> @ignorarId)";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@ignorarId", ignorarId.HasValue ? (object)ignorarId.Value : DBNull.Value);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        /// <summary>Insere um novo insumo. Retorna o Id gerado.</summary>
        public static int Inserir(Insumo insumo)
        {
            const string sql = @"
                INSERT INTO insumos (nome, categoria, quantidade_atual, unidade, quantidade_minima, preco_unitario)
                VALUES (@nome, @categoria, @qtdAtual, @unidade, @qtdMinima, @preco);
                SELECT LAST_INSERT_ID();";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", insumo.Nome);
                cmd.Parameters.AddWithValue("@categoria", insumo.Categoria);
                cmd.Parameters.AddWithValue("@qtdAtual", insumo.QuantidadeAtual);
                cmd.Parameters.AddWithValue("@unidade", insumo.Unidade);
                cmd.Parameters.AddWithValue("@qtdMinima", insumo.QuantidadeMinima);
                cmd.Parameters.AddWithValue("@preco", insumo.PrecoUnitario);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        /// <summary>Atualiza os dados de um insumo existente.</summary>
        public static void Atualizar(Insumo insumo)
        {
            const string sql = @"
                UPDATE insumos
                SET nome = @nome,
                    categoria = @categoria,
                    quantidade_atual = @qtdAtual,
                    unidade = @unidade,
                    quantidade_minima = @qtdMinima,
                    preco_unitario = @preco
                WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", insumo.Nome);
                cmd.Parameters.AddWithValue("@categoria", insumo.Categoria);
                cmd.Parameters.AddWithValue("@qtdAtual", insumo.QuantidadeAtual);
                cmd.Parameters.AddWithValue("@unidade", insumo.Unidade);
                cmd.Parameters.AddWithValue("@qtdMinima", insumo.QuantidadeMinima);
                cmd.Parameters.AddWithValue("@preco", insumo.PrecoUnitario);
                cmd.Parameters.AddWithValue("@id", insumo.Id);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Remove um insumo do banco (ex.: botão de excluir na grid, se implementado futuramente).</summary>
        public static void Excluir(int id)
        {
            const string sql = "DELETE FROM insumos WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        private static Insumo MapearInsumo(MySqlDataReader leitor)
        {
            return new Insumo
            {
                Id = leitor.GetInt32("id"),
                Nome = leitor.GetString("nome"),
                Categoria = leitor.GetString("categoria"),
                QuantidadeAtual = leitor.GetDecimal("quantidade_atual"),
                Unidade = leitor.GetString("unidade"),
                QuantidadeMinima = leitor.GetDecimal("quantidade_minima"),
                PrecoUnitario = leitor.GetDecimal("preco_unitario")
            };
        }
    }
}