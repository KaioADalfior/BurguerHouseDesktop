using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Lanchonete001.BancoDados
{
    public static class ConexaoBanco
    {
        private const string SERVIDOR_PADRAO = "localhost";
        private const string BANCO_PADRAO = "BurguerHouse";
        private const string USUARIO_PADRAO = "root";
        private const string SENHA_PADRAO = "root";

        private static string ConnectionString
        {
            get
            {
                var configurada = ConfigurationManager.ConnectionStrings["BurguerHouse"];
                if (configurada != null && !string.IsNullOrWhiteSpace(configurada.ConnectionString))
                    return configurada.ConnectionString;

                return string.Format(
                    "Server={0};Database={1};Uid={2};Pwd={3};",
                    SERVIDOR_PADRAO, BANCO_PADRAO, USUARIO_PADRAO, SENHA_PADRAO);
            }
        }

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(ConnectionString);
            conexao.Open();
            return conexao;
        }

        public static bool TestarConexao(out string mensagemErro)
        {
            try
            {
                using (var conexao = ObterConexao())
                {
                    mensagemErro = null;
                    return conexao.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                return false;
            }
        }
    }
}