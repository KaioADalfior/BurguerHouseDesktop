namespace Lanchonete001.Usuarios
{
    /// <summary>
    /// Um cargo/função da lanchonete (Dono, Gerente, Cozinha, Garçom, Financeiro...),
    /// atribuído a um ou mais usuários. Espelha a tabela "cargos" do banco.
    /// </summary>
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        /// <summary>Faz ComboBox (DisplayMember = "Nome") e ToString() mostrarem o nome do cargo.</summary>
        public override string ToString()
        {
            return Nome;
        }
    }
}