using Lanchonete001.Estoque;
using MySql.Data.MySqlClient;
using System;
using System.Linq;

namespace Lanchonete001.BancoDados
{
    /// <summary>Números já calculados para os 4 cards do topo do Dashboard.</summary>
    public class DashboardResumo
    {
        public decimal VendasHoje { get; set; }
        public int PedidosHoje { get; set; }
        public int MesasOcupadas { get; set; }
        public int TotalMesas { get; set; }
        public int ItensEstoqueBaixo { get; set; }

        public int PercentualOcupacao => TotalMesas == 0
            ? 0
            : (int)Math.Round(MesasOcupadas * 100m / TotalMesas);
    }

    /// <summary>
    /// Consultas agregadas usadas só pelo Dashboard (Form1). Não repete a
    /// lógica dos outros repositórios (Mesas, Estoque) além do necessário:
    /// para estoque baixo, reaproveita o EstoqueRepositorio já existente.
    /// </summary>
    public static class DashboardRepositorio
    {
        public static DashboardResumo ObterResumo()
        {
            var resumo = new DashboardResumo();

            // Soma dos pedidos FECHADOS hoje (venda já concluída, igual ao
            // Pedido A do seed: fechado_em preenchido). Agrupa por pedido
            // para descontar o valor de "desconto" uma única vez por pedido,
            // e não proporcionalmente por item.
            const string sqlVendas = @"
                SELECT COALESCE(SUM(sub.total_pedido), 0) FROM (
                    SELECT p.id, SUM(ip.preco_unitario * ip.quantidade) - p.desconto AS total_pedido
                    FROM pedidos p
                    INNER JOIN itens_pedido ip ON ip.pedido_id = p.id
                    WHERE p.fechado_em IS NOT NULL
                      AND DATE(p.fechado_em) = CURDATE()
                    GROUP BY p.id, p.desconto
                ) sub";

            // Quantos pedidos foram ABERTOS hoje (independente de já ter fechado)
            const string sqlPedidos = @"
                SELECT COUNT(*) FROM pedidos WHERE DATE(aberto_em) = CURDATE()";

            // Total de mesas e quantas não estão livres (Ocupada ou Fechando)
            const string sqlMesas = @"
                SELECT COUNT(*) AS total,
                       SUM(CASE WHEN status <> 'Livre' THEN 1 ELSE 0 END) AS ocupadas
                FROM mesas";

            using (var conexao = ConexaoBanco.ObterConexao())
            {
                using (var cmd = new MySqlCommand(sqlVendas, conexao))
                {
                    resumo.VendasHoje = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                using (var cmd = new MySqlCommand(sqlPedidos, conexao))
                {
                    resumo.PedidosHoje = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new MySqlCommand(sqlMesas, conexao))
                using (var leitor = cmd.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        resumo.TotalMesas = leitor.GetInt32("total");
                        resumo.MesasOcupadas = leitor.IsDBNull(leitor.GetOrdinal("ocupadas"))
                            ? 0
                            : leitor.GetInt32("ocupadas");
                    }
                }
            }

            // Reaproveita o repositório de Estoque já existente, em vez de
            // duplicar a regra de "estoque baixo" (quantidade < mínima) aqui.
            resumo.ItensEstoqueBaixo = EstoqueRepositorio.Listar().Count(i => i.EstoqueBaixo);

            return resumo;
        }
    }
}