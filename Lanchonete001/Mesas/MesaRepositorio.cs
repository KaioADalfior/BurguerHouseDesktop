using Lanchonete001.BancoDados;
using Lanchonete001.Cardapio;
using Lanchonete001.Estoque;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete001.Mesas
{
    public static class MesaRepositorio
    {
        // -----------------------------------------------------------------
        // Leitura
        // -----------------------------------------------------------------

        /// <summary>Lista todas as mesas, cada uma já com seu pedido em aberto (se houver).</summary>
        public static List<Mesa> ObterMesas()
        {
            var mesas = new List<Mesa>();

            const string sql = "SELECT id, numero, status FROM mesas ORDER BY numero";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    mesas.Add(new Mesa
                    {
                        Id = leitor.GetInt32("id"),
                        Numero = leitor.GetInt32("numero"),
                        Status = (StatusMesa)Enum.Parse(typeof(StatusMesa), leitor.GetString("status"))
                    });
                }
            }

            foreach (var mesa in mesas)
                mesa.Pedido = BuscarPedidoAberto(mesa.Id);

            return mesas;
        }

        /// <summary>Busca o pedido em aberto (fechado_em IS NULL) de uma mesa, com os itens já carregados.</summary>
        private static PedidoMesa BuscarPedidoAberto(int mesaId)
        {
            PedidoMesa pedido = null;

            const string sql = @"
                SELECT id, mesa_id, desconto, enviado_para_cozinha, status_preparo, forma_pagamento
                FROM pedidos
                WHERE mesa_id = @mesaId AND fechado_em IS NULL
                ORDER BY aberto_em DESC
                LIMIT 1";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@mesaId", mesaId);

                using (var leitor = cmd.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        pedido = new PedidoMesa
                        {
                            Id = leitor.GetInt32("id"),
                            MesaId = leitor.GetInt32("mesa_id"),
                            Desconto = leitor.GetDecimal("desconto"),
                            EnviadoParaCozinha = leitor.GetBoolean("enviado_para_cozinha"),
                            StatusPreparo = (StatusPreparoPedido)Enum.Parse(typeof(StatusPreparoPedido), leitor.GetString("status_preparo")),
                            FormaPagamento = leitor.IsDBNull(leitor.GetOrdinal("forma_pagamento"))
                                ? (FormaPagamento?)null
                                : (FormaPagamento)Enum.Parse(typeof(FormaPagamento), leitor.GetString("forma_pagamento"))
                        };
                    }
                }
            }

            if (pedido != null)
                pedido.Itens = ListarItensPedido(pedido.Id);

            return pedido;
        }

        private static List<ItemPedidoMesa> ListarItensPedido(int pedidoId)
        {
            var itens = new List<ItemPedidoMesa>();

            const string sql = @"
                SELECT ip.id, ip.item_cardapio_id, ic.nome AS nome_produto, ip.preco_unitario, ip.quantidade
                FROM itens_pedido ip
                INNER JOIN itens_cardapio ic ON ic.id = ip.item_cardapio_id
                WHERE ip.pedido_id = @pedidoId";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@pedidoId", pedidoId);

                using (var leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        itens.Add(new ItemPedidoMesa
                        {
                            Id = leitor.GetInt32("id"),
                            ItemCardapioId = leitor.GetInt32("item_cardapio_id"),
                            NomeProduto = leitor.GetString("nome_produto"),
                            PrecoUnitario = leitor.GetDecimal("preco_unitario"),
                            Quantidade = leitor.GetInt32("quantidade")
                        });
                    }
                }
            }

            return itens;
        }

        // -----------------------------------------------------------------
        // Quantidade de mesas
        // -----------------------------------------------------------------

        public static void DefinirQuantidade(int quantidade)
        {
            if (quantidade < 0) quantidade = 0;

            var mesas = ListarMesasBasico();

            if (mesas.Count > quantidade)
            {
                var paraRemover = mesas
                    .OrderByDescending(m => m.numero)
                    .Take(mesas.Count - quantidade);

                foreach (var mesa in paraRemover)
                    RemoverMesaSeSemHistorico(mesa.id);
            }

            if (mesas.Count < quantidade)
            {
                int proximoNumero = mesas.Count > 0 ? mesas.Max(m => m.numero) + 1 : 1;

                for (int i = mesas.Count; i < quantidade; i++)
                {
                    InserirMesa(proximoNumero);
                    proximoNumero++;
                }
            }
        }

        private static List<(int id, int numero)> ListarMesasBasico()
        {
            var lista = new List<(int id, int numero)>();

            const string sql = "SELECT id, numero FROM mesas";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            using (var leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                    lista.Add((leitor.GetInt32("id"), leitor.GetInt32("numero")));
            }

            return lista;
        }

        private static void InserirMesa(int numero)
        {
            const string sql = "INSERT INTO mesas (numero, status) VALUES (@numero, 'Livre')";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Remove a mesa apenas se ela não tiver histórico de pedidos —
        /// pedidos.mesa_id é ON DELETE RESTRICT, então uma mesa que já foi
        /// usada não pode ser apagada. Nesse caso, a exclusão é ignorada
        /// silenciosamente (a mesa continua existindo no banco).
        /// </summary>
        private static void RemoverMesaSeSemHistorico(int id)
        {
            const string sql = "DELETE FROM mesas WHERE id = @id";

            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex) when (ex.Number == 1451) // FK constraint fails
            {
                // Mesa já tem pedidos vinculados; mantém o registro.
            }
        }

        // -----------------------------------------------------------------
        // Ciclo de vida do pedido
        // -----------------------------------------------------------------

        public static void GarantirPedidoAberto(Mesa mesa)
        {
            if (mesa.Pedido != null) return;

            const string sqlInsert = @"
                INSERT INTO pedidos (mesa_id, desconto, enviado_para_cozinha, status_preparo)
                VALUES (@mesaId, 0, 0, 'AguardandoPreparo');
                SELECT LAST_INSERT_ID();";

            const string sqlMesa = "UPDATE mesas SET status = 'Ocupada' WHERE id = @id";

            int pedidoId;

            using (var conexao = ConexaoBanco.ObterConexao())
            {
                using (var cmd = new MySqlCommand(sqlInsert, conexao))
                {
                    cmd.Parameters.AddWithValue("@mesaId", mesa.Id);
                    pedidoId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new MySqlCommand(sqlMesa, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", mesa.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            mesa.Pedido = new PedidoMesa { Id = pedidoId, MesaId = mesa.Id };
            mesa.Status = StatusMesa.Ocupada;
        }

        public static void FecharConta(Mesa mesa)
        {
            if (mesa.Pedido == null) return;

            const string sqlPedido = @"
                UPDATE pedidos
                SET desconto = @desconto, forma_pagamento = @forma, fechado_em = NOW()
                WHERE id = @id";

            const string sqlMesa = "UPDATE mesas SET status = 'Livre' WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            {
                using (var cmd = new MySqlCommand(sqlPedido, conexao))
                {
                    cmd.Parameters.AddWithValue("@desconto", mesa.Pedido.Desconto);
                    cmd.Parameters.AddWithValue("@forma",
                        mesa.Pedido.FormaPagamento.HasValue ? mesa.Pedido.FormaPagamento.Value.ToString() : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", mesa.Pedido.Id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(sqlMesa, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", mesa.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            mesa.Pedido = null;
            mesa.Status = StatusMesa.Livre;
        }

        /// <summary>Envia o pedido da mesa para a fila do Kanban (UcPedidos).</summary>
        public static void EnviarParaCozinha(Mesa mesa)
        {
            if (mesa.Pedido == null || mesa.Pedido.Itens.Count == 0) return;

            const string sql = @"
                UPDATE pedidos
                SET enviado_para_cozinha = 1, status_preparo = 'AguardandoPreparo'
                WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@id", mesa.Pedido.Id);
                cmd.ExecuteNonQuery();
            }

            mesa.Pedido.EnviadoParaCozinha = true;
            mesa.Pedido.StatusPreparo = StatusPreparoPedido.AguardandoPreparo;
        }

        /// <summary>Avança o pedido pra próxima coluna do Kanban.</summary>
        public static void AvancarStatusPreparo(PedidoMesa pedido)
        {
            StatusPreparoPedido novoStatus;
            switch (pedido.StatusPreparo)
            {
                case StatusPreparoPedido.AguardandoPreparo: novoStatus = StatusPreparoPedido.EmPreparo; break;
                case StatusPreparoPedido.EmPreparo: novoStatus = StatusPreparoPedido.Entregue; break;
                case StatusPreparoPedido.Entregue: novoStatus = StatusPreparoPedido.Finalizado; break;
                default: return;
            }

            const string sql = "UPDATE pedidos SET status_preparo = @status WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@status", novoStatus.ToString());
                cmd.Parameters.AddWithValue("@id", pedido.Id);
                cmd.ExecuteNonQuery();
            }

            pedido.StatusPreparo = novoStatus;

            if (novoStatus == StatusPreparoPedido.Finalizado)
            {
                const string sqlMesa = "UPDATE mesas SET status = 'Fechando' WHERE id = @id";

                using (var conexao = ConexaoBanco.ObterConexao())
                using (var cmd = new MySqlCommand(sqlMesa, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", pedido.MesaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void TransferirPedido(Mesa origem, Mesa destino)
        {
            if (origem.Pedido == null) return;

            const string sqlPedido = "UPDATE pedidos SET mesa_id = @destinoId WHERE id = @pedidoId";
            const string sqlDestino = "UPDATE mesas SET status = 'Ocupada' WHERE id = @id";
            const string sqlOrigem = "UPDATE mesas SET status = 'Livre' WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            {
                using (var cmd = new MySqlCommand(sqlPedido, conexao))
                {
                    cmd.Parameters.AddWithValue("@destinoId", destino.Id);
                    cmd.Parameters.AddWithValue("@pedidoId", origem.Pedido.Id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(sqlDestino, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", destino.Id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(sqlOrigem, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", origem.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            origem.Pedido.MesaId = destino.Id;
            destino.Pedido = origem.Pedido;
            destino.Status = StatusMesa.Ocupada;

            origem.Pedido = null;
            origem.Status = StatusMesa.Livre;
        }

        // -----------------------------------------------------------------
        // Itens do pedido
        // -----------------------------------------------------------------

        /// <summary>
        /// Lança um item no pedido (ou incrementa se já existir). Retorna a
        /// lista de insumos que zeraram/ficaram negativos na receita desse
        /// item, para a tela avisar o atendente.
        /// </summary>
        public static List<AlertaEstoqueInsumo> AdicionarItem(PedidoMesa pedido, ItemCardapio itemCardapio)
        {
            var existente = pedido.Itens.FirstOrDefault(i => i.ItemCardapioId == itemCardapio.Id);
            if (existente != null)
            {
                return AtualizarQuantidadeItem(existente, existente.Quantidade + 1);
            }

            const string sql = @"
                INSERT INTO itens_pedido (pedido_id, item_cardapio_id, preco_unitario, quantidade)
                VALUES (@pedidoId, @itemCardapioId, @preco, 1);
                SELECT LAST_INSERT_ID();";

            int novoId;

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@pedidoId", pedido.Id);
                cmd.Parameters.AddWithValue("@itemCardapioId", itemCardapio.Id);
                cmd.Parameters.AddWithValue("@preco", itemCardapio.PrecoVenda);

                novoId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            pedido.Itens.Add(new ItemPedidoMesa
            {
                Id = novoId,
                ItemCardapioId = itemCardapio.Id,
                NomeProduto = itemCardapio.Nome,
                PrecoUnitario = itemCardapio.PrecoVenda,
                Quantidade = 1
            });

            return AjustarEstoquePorReceita(itemCardapio.Id, 1); // consome a receita da 1ª unidade
        }

        /// <summary>Aumenta 1 unidade do item. Retorna alertas de estoque, se houver.</summary>
        public static List<AlertaEstoqueInsumo> AumentarQuantidade(PedidoMesa pedido, ItemPedidoMesa item)
        {
            return AtualizarQuantidadeItem(item, item.Quantidade + 1);
        }

        /// <summary>
        /// Diminui 1 unidade do item (devolve estoque). Se a quantidade cair
        /// a zero, o item é removido do pedido. Nunca gera alerta de estoque,
        /// pois só devolve insumos.
        /// </summary>
        public static void DiminuirQuantidade(PedidoMesa pedido, ItemPedidoMesa item)
        {
            if (item.Quantidade <= 1)
            {
                RemoverItem(pedido, item);
                return;
            }

            AtualizarQuantidadeItem(item, item.Quantidade - 1); // retorno descartado: devolução nunca alerta
        }

        /// <summary>Remove o item do pedido e devolve todo o estoque reservado para ele.</summary>
        public static void RemoverItem(PedidoMesa pedido, ItemPedidoMesa item)
        {
            const string sql = "DELETE FROM itens_pedido WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.ExecuteNonQuery();
            }

            pedido.Itens.Remove(item);

            AjustarEstoquePorReceita(item.ItemCardapioId, -item.Quantidade); // devolve tudo
        }

        /// <summary>
        /// Atualiza a quantidade de um item já lançado e ajusta o estoque
        /// pela diferença (delta positivo consome, negativo devolve).
        /// Retorna os alertas de estoque gerados pelo ajuste.
        /// </summary>
        private static List<AlertaEstoqueInsumo> AtualizarQuantidadeItem(ItemPedidoMesa item, int novaQuantidade)
        {
            int delta = novaQuantidade - item.Quantidade; // + consome, - devolve

            const string sql = "UPDATE itens_pedido SET quantidade = @quantidade WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@quantidade", novaQuantidade);
                cmd.Parameters.AddWithValue("@id", item.Id);
                cmd.ExecuteNonQuery();
            }

            item.Quantidade = novaQuantidade;

            return AjustarEstoquePorReceita(item.ItemCardapioId, delta);
        }

        /// <summary>
        /// Aplica a variação de estoque de todos os insumos da receita de um
        /// item do cardápio (ingredientes_receita). variacaoQuantidade
        /// positivo = consome estoque; negativo = devolve estoque.
        /// Retorna os insumos que, após a baixa, zeraram ou ficaram
        /// negativos — só quando está consumindo (nunca ao devolver).
        /// </summary>
        private static List<AlertaEstoqueInsumo> AjustarEstoquePorReceita(int itemCardapioId, int variacaoQuantidade)
        {
            var alertas = new List<AlertaEstoqueInsumo>();
            if (variacaoQuantidade == 0) return alertas;

            const string sqlIngredientes = @"
                SELECT ir.insumo_id, ir.quantidade AS qtd_por_unidade,
                       i.nome AS nome_insumo, i.quantidade_atual
                FROM ingredientes_receita ir
                INNER JOIN insumos i ON i.id = ir.insumo_id
                WHERE ir.item_cardapio_id = @itemCardapioId";

            const string sqlAtualizarInsumo = @"
                UPDATE insumos
                SET quantidade_atual = @novaQuantidade
                WHERE id = @insumoId";

            using (var conexao = ConexaoBanco.ObterConexao())
            {
                var ingredientes = new List<(int insumoId, decimal qtdPorUnidade, string nome, decimal qtdAtual)>();

                using (var cmd = new MySqlCommand(sqlIngredientes, conexao))
                {
                    cmd.Parameters.AddWithValue("@itemCardapioId", itemCardapioId);

                    using (var leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            ingredientes.Add((
                                leitor.GetInt32("insumo_id"),
                                leitor.GetDecimal("qtd_por_unidade"),
                                leitor.GetString("nome_insumo"),
                                leitor.GetDecimal("quantidade_atual")
                            ));
                        }
                    }
                }

                foreach (var ingrediente in ingredientes)
                {
                    decimal quantidadeConsumida = ingrediente.qtdPorUnidade * variacaoQuantidade;
                    decimal novaQuantidade = ingrediente.qtdAtual - quantidadeConsumida;

                    using (var cmd = new MySqlCommand(sqlAtualizarInsumo, conexao))
                    {
                        cmd.Parameters.AddWithValue("@novaQuantidade", novaQuantidade);
                        cmd.Parameters.AddWithValue("@insumoId", ingrediente.insumoId);
                        cmd.ExecuteNonQuery();
                    }

                    // Só avisa quando está CONSUMINDO (variacao > 0) e o resultado
                    // zera ou fica negativo. Ao devolver estoque (variacao < 0) nunca
                    // gera alerta, mesmo que o valor "suba" de negativo pra zero.
                    if (variacaoQuantidade > 0 && novaQuantidade <= 0)
                    {
                        alertas.Add(new AlertaEstoqueInsumo
                        {
                            NomeInsumo = ingrediente.nome,
                            QuantidadeAposConsumo = novaQuantidade
                        });
                    }
                }
            }

            return alertas;
        }

        public static void AtualizarDesconto(PedidoMesa pedido, decimal valor)
        {
            const string sql = "UPDATE pedidos SET desconto = @desconto WHERE id = @id";

            using (var conexao = ConexaoBanco.ObterConexao())
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@desconto", valor);
                cmd.Parameters.AddWithValue("@id", pedido.Id);
                cmd.ExecuteNonQuery();
            }

            pedido.Desconto = valor;
        }
    }
}