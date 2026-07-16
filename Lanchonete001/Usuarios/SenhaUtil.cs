using System;
using System.Security.Cryptography;
using System.Text;

namespace Lanchonete001.Usuarios
{
    /// <summary>
    /// Utilitário de hash de senha (SHA-256 + tempero fixo da instalação).
    /// Sem dependências externas, para não exigir mais pacotes NuGet além do MySql.Data.
    ///
    /// Observação: para um sistema em produção, o ideal é usar um hash com salt por
    /// usuário e custo ajustável (ex.: biblioteca BCrypt.Net-Next), em vez de SHA-256
    /// puro. Mantido simples aqui para não adicionar mais dependências ao projeto.
    /// </summary>
    public static class SenhaUtil
    {
        // Em produção, mova este "tempero" para o App.config ou variável de ambiente;
        // nunca deixe uma chave assim fixa em um repositório público.
        private const string TEMPERO = "BurguerHouse#2026";

        /// <summary>Gera o hash (hexadecimal) de uma senha em texto puro.</summary>
        public static string GerarHash(string senhaTextoPuro)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytesEntrada = Encoding.UTF8.GetBytes(TEMPERO + (senhaTextoPuro ?? string.Empty));
                byte[] hash = sha256.ComputeHash(bytesEntrada);

                var construtor = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                    construtor.Append(b.ToString("x2"));

                return construtor.ToString();
            }
        }

        /// <summary>Confere se a senha em texto puro corresponde ao hash armazenado.</summary>
        public static bool ConferirSenha(string senhaTextoPuro, string hashArmazenado)
        {
            if (string.IsNullOrEmpty(hashArmazenado)) return false;

            string hashDigitado = GerarHash(senhaTextoPuro);
            return string.Equals(hashDigitado, hashArmazenado, StringComparison.OrdinalIgnoreCase);
        }
    }
}