using Lanchonete001.BancoDados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Lanchonete001.Usuarios
{
    /// <summary>
    /// Acesso a dados de usuários e cargos, direto no MySQL via ConexaoBanco.
    /// Substitui o antigo login fixo ("user"/"user") do FrmLogin.
    /// </summary>
    public static class UsuarioRepositorio
    {
        public static List<Cargo> ListarCargos()
        {
            var cargos = new List<Cargo>();

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand("SELECT id, nome, descricao FROM cargos ORDER BY nome", conexao))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    cargos.Add(new Cargo
                    {
                        Id = leitor.GetInt32("id"),
                        Nome = leitor.GetString("nome"),
                        Descricao = leitor.IsDBNull(leitor.GetOrdinal("descricao")) ? null : leitor.GetString("descricao")
                    });
                }
            }

            return cargos;
        }

        /// <summary>Lista usuários (com nome do cargo via JOIN), com filtro opcional por texto e por cargo.</summary>
        public static List<Usuario> Listar(string termoBusca = null, int? cargoId = null)
        {
            var usuarios = new List<Usuario>();

            const string sql = @"
                SELECT u.id, u.nome, u.usuario, u.cargo_id, c.nome AS cargo_nome, u.ativo, u.criado_em
                FROM usuarios u
                INNER JOIN cargos c ON c.id = u.cargo_id
                WHERE (@termo IS NULL OR u.nome LIKE @termo OR u.usuario LIKE @termo)
                  AND (@cargoId IS NULL OR u.cargo_id = @cargoId)
                ORDER BY u.nome";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@termo", string.IsNullOrWhiteSpace(termoBusca) ? (object)DBNull.Value : "%" + termoBusca.Trim() + "%");
                cmd.Parameters.AddWithValue("@cargoId", cargoId.HasValue ? (object)cargoId.Value : DBNull.Value);

                using (var leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                        usuarios.Add(MapearUsuario(leitor));
                }
            }

            return usuarios;
        }

        /// <summary>
        /// Confere usuário e senha diretamente no banco (usado pelo FrmLogin).
        /// Retorna o usuário autenticado, ou null se usuário/senha inválidos,
        /// ou se o usuário estiver inativo.
        /// </summary>
        public static Usuario Autenticar(string nomeUsuario, string senhaTextoPuro)
        {
            const string sql = @"
                SELECT u.id, u.nome, u.usuario, u.senha, u.cargo_id, c.nome AS cargo_nome, u.ativo, u.criado_em
                FROM usuarios u
                INNER JOIN cargos c ON c.id = u.cargo_id
                WHERE u.usuario = @usuario
                LIMIT 1";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@usuario", nomeUsuario);

                using (var leitor = cmd.ExecuteReader())
                {
                    if (!leitor.Read()) return null;

                    bool ativo = leitor.GetBoolean("ativo");
                    string senhaArmazenada = leitor.GetString("senha");

                    if (!ativo) return null;
                    // Comparação em texto puro (sem hash) - app de teste por enquanto.
                    if (!string.Equals(senhaTextoPuro, senhaArmazenada, StringComparison.Ordinal)) return null;

                    return MapearUsuario(leitor);
                }
            }
        }

        /// <summary>Verifica se já existe outro usuário com esse login (para validação de formulário).</summary>
        public static bool ExisteNomeUsuario(string nomeUsuario, int? ignorarId = null)
        {
            const string sql = @"SELECT COUNT(1) FROM usuarios WHERE usuario = @usuario AND (@ignorarId IS NULL OR id <> @ignorarId)";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@usuario", nomeUsuario);
                cmd.Parameters.AddWithValue("@ignorarId", ignorarId.HasValue ? (object)ignorarId.Value : DBNull.Value);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        /// <summary>Insere um novo usuário. Senha salva em texto puro (app de teste, sem hash). Retorna o Id gerado.</summary>
        public static int Inserir(Usuario usuario, string senhaTextoPuro)
        {
            const string sql = @"
                INSERT INTO usuarios (nome, usuario, senha, cargo_id, ativo)
                VALUES (@nome, @usuario, @senha, @cargoId, @ativo);
                SELECT LAST_INSERT_ID();";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@usuario", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@senha", senhaTextoPuro);
                cmd.Parameters.AddWithValue("@cargoId", usuario.CargoId);
                cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        /// <summary>
        /// Atualiza dados do usuário. Se novaSenhaTextoPuro vier nulo/vazio,
        /// a senha atual é mantida (não sobrescreve com uma string vazia). Senha salva em texto puro.
        /// </summary>
        public static void Atualizar(Usuario usuario, string novaSenhaTextoPuro)
        {
            string sql = @"
                UPDATE usuarios
                SET nome = @nome, usuario = @usuario, cargo_id = @cargoId, ativo = @ativo"
                + (string.IsNullOrWhiteSpace(novaSenhaTextoPuro) ? "" : ", senha = @senha")
                + " WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@usuario", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@cargoId", usuario.CargoId);
                cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);
                cmd.Parameters.AddWithValue("@id", usuario.Id);

                if (!string.IsNullOrWhiteSpace(novaSenhaTextoPuro))
                    cmd.Parameters.AddWithValue("@senha", novaSenhaTextoPuro);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Ativa ou inativa um usuário (usado no botão de "Ativar/Inativar" da grid).</summary>
        public static void AlterarAtivo(int id, bool ativo)
        {
            const string sql = "UPDATE usuarios SET ativo = @ativo WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@ativo", ativo);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        private static Usuario MapearUsuario(MySqlDataReader leitor)
        {
            return new Usuario
            {
                Id = leitor.GetInt32("id"),
                Nome = leitor.GetString("nome"),
                NomeUsuario = leitor.GetString("usuario"),
                CargoId = leitor.GetInt32("cargo_id"),
                CargoNome = leitor.GetString("cargo_nome"),
                Ativo = leitor.GetBoolean("ativo"),
                CriadoEm = leitor.GetDateTime("criado_em")
            };
        }
    }
}