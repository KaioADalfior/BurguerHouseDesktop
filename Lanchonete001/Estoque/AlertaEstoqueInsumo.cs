namespace Lanchonete001.Estoque
{
    /// <summary>
    /// Representa um insumo que zerou ou ficou negativo depois que um item
    /// de pedido consumiu sua receita (ingredientes_receita). Usado para
    /// avisar o atendente na hora de lançar o pedido, para que ele possa
    /// perguntar ao cliente se aceita trocar o insumo por outro.
    /// </summary>
    public class AlertaEstoqueInsumo
    {
        public string NomeInsumo { get; set; }

        /// <summary>Quantidade do insumo após a baixa. Pode ser negativa (faltou insumo).</summary>
        public decimal QuantidadeAposConsumo { get; set; }

        public string Descricao => QuantidadeAposConsumo < 0
            ? $"faltam {System.Math.Abs(QuantidadeAposConsumo):0.###} para atender este pedido"
            : "o estoque chegou a zero com este pedido";
    }
}