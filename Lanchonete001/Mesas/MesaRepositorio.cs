using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Mesas
{
    /// <summary>
    /// Fonte única de dados das mesas, em memória por enquanto (sem banco
    /// de dados ainda). O UcMesas define a quantidade e lê daqui; o
    /// FrmPedidoMesa lê/escreve o pedido de uma mesa específica.
    /// </summary>
    public static class MesaRepositorio
    {
        public static List<Mesa> Mesas { get; } = new List<Mesa>();

        /// <summary>
        /// Ajusta a lista de mesas para ter exatamente "quantidade" itens.
        /// Mesas excedentes são removidas a partir do maior número (perde
        /// o pedido em aberto, se houver — é o comportamento esperado ao
        /// reduzir a quantidade configurada pelo estabelecimento).
        /// </summary>
        public static void DefinirQuantidade(int quantidade)
        {
            if (quantidade < 0) quantidade = 0;

            while (Mesas.Count > quantidade)
            {
                Mesas.RemoveAt(Mesas.Count - 1);
            }

            int proximoNumero = Mesas.Count > 0 ? Mesas.Max(m => m.Numero) + 1 : 1;
            while (Mesas.Count < quantidade)
            {
                Mesas.Add(new Mesa { Numero = proximoNumero });
                proximoNumero++;
            }
        }

        /// <summary>Garante que a mesa tenha um pedido em aberto e marque-a como ocupada.</summary>
        public static void GarantirPedidoAberto(Mesa mesa)
        {
            if (mesa.Pedido == null)
            {
                mesa.Pedido = new PedidoMesa();
            }

            if (mesa.Status == StatusMesa.Livre)
            {
                mesa.Status = StatusMesa.Ocupada;
            }
        }

        /// <summary>Encerra o pedido da mesa e a libera.</summary>
        public static void FecharConta(Mesa mesa)
        {
            mesa.Pedido = null;
            mesa.Status = StatusMesa.Livre;
        }
    }
}