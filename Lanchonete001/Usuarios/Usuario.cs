using System;

namespace Lanchonete001.Usuarios
{

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string NomeUsuario { get; set; }

        public string SenhaHash { get; set; }

        public int CargoId { get; set; }

        public string CargoNome { get; set; }

        public bool Ativo { get; set; } = true;
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}