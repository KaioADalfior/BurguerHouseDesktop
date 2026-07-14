using Lanchonete001.Mesas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace Lanchonete001.Impressao
{
    /// <summary>
    /// Retrato "congelado" do fechamento de conta, usado só para impressão.
    /// É montado a partir do Pedido antes dele ser limpo por
    /// MesaRepositorio.FecharConta, então a impressão não depende do
    /// estado da mesa depois de fechada.
    /// </summary>
    public class DadosComanda
    {
        public int MesaNumero { get; set; }
        public List<ItemPedidoMesa> Itens { get; set; } = new List<ItemPedidoMesa>();
        public decimal Subtotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal Troco { get; set; }
        public DateTime DataHora { get; set; } = DateTime.Now;
    }

    /// <summary>
    /// Monta e imprime a comanda de fechamento em formato de cupom,
    /// no padrão de bobina térmica de 80mm usada em lanchonetes.
    /// Abre uma pré-visualização antes de imprimir de fato.
    /// </summary>
    public static class ImpressoraComanda
    {
        private const string NomeEstabelecimento = "LANCHONETE";
        private const string Endereco = "Rua Exemplo, 123 - Centro";
        private const string Telefone = "(22) 99999-9999";

        private static readonly CultureInfo CulturaBR = new CultureInfo("pt-BR");

        // Fontes usadas no cupom
        private static readonly Font FonteTitulo = new Font("Arial", 15F, FontStyle.Bold);
        private static readonly Font FonteInfoLoja = new Font("Arial", 8F, FontStyle.Regular);
        private static readonly Font FonteSecao = new Font("Arial", 9.5F, FontStyle.Bold);
        private static readonly Font FonteTexto = new Font("Arial", 9F, FontStyle.Regular);
        private static readonly Font FonteTextoBold = new Font("Arial", 9F, FontStyle.Bold);
        private static readonly Font FonteItemDetalhe = new Font("Arial", 7.5F, FontStyle.Italic);
        private static readonly Font FonteTotal = new Font("Arial", 13F, FontStyle.Bold);
        private static readonly Font FonteRodape = new Font("Arial", 8.5F, FontStyle.Italic);

        private class Bloco
        {
            public float Altura;
            public Action<Graphics, RectangleF> Desenhar;
        }

        public static void Imprimir(DadosComanda dados)
        {
            var doc = new PrintDocument();
            doc.DocumentName = $"Comanda - Mesa {dados.MesaNumero:00}";

            // Papel estreito, no padrão de bobina térmica 80mm
            // (valores em centésimos de polegada). Ajuste aqui se a
            // impressora usada for de rolo 58mm ou folha A4.
            doc.DefaultPageSettings.PaperSize = new PaperSize("Comanda 80mm", 315, 1200);
            doc.DefaultPageSettings.Margins = new Margins(12, 12, 12, 12);
            doc.OriginAtMargins = true;

            var blocos = MontarBlocos(dados);
            int indice = 0;

            doc.PrintPage += (s, e) => DesenharPagina(e, blocos, ref indice);

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document = doc;
                preview.Text = "Pré-visualização da Comanda - Mesa " + dados.MesaNumero.ToString("00");
                preview.Width = 650;
                preview.Height = 800;
                preview.StartPosition = FormStartPosition.CenterScreen;
                preview.ShowIcon = false;
                preview.ShowDialog();
            }
        }

        private static void DesenharPagina(PrintPageEventArgs e, List<Bloco> blocos, ref int indice)
        {
            float y = e.MarginBounds.Top;

            while (indice < blocos.Count)
            {
                var bloco = blocos[indice];

                if (y + bloco.Altura > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                var area = new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, bloco.Altura);
                bloco.Desenhar(e.Graphics, area);
                y += bloco.Altura;
                indice++;
            }

            e.HasMorePages = false;
        }

        private static List<Bloco> MontarBlocos(DadosComanda dados)
        {
            var blocos = new List<Bloco>();

            using (var bmp = new Bitmap(1, 1))
            using (var gMedida = Graphics.FromImage(bmp))
            {
                // ----- Cabeçalho -----
                blocos.Add(Texto(NomeEstabelecimento, FonteTitulo, StringAlignment.Center, 4));
                blocos.Add(Texto(Endereco, FonteInfoLoja, StringAlignment.Center, 1));
                blocos.Add(Texto(Telefone, FonteInfoLoja, StringAlignment.Center, 6));
                blocos.Add(Separador());

                // ----- Mesa / Data -----
                blocos.Add(DuasColunas("Mesa", dados.MesaNumero.ToString("00"), FonteSecao, FonteSecao, 2));
                blocos.Add(DuasColunas("Data/Hora", dados.DataHora.ToString("dd/MM/yyyy HH:mm"), FonteTexto, FonteTexto, 6));
                blocos.Add(Separador());

                // ----- Itens -----
                blocos.Add(Texto("ITENS DO PEDIDO", FonteSecao, StringAlignment.Near, 4));

                foreach (var item in dados.Itens)
                {
                    string descricao = $"{item.Quantidade}x {item.NomeProduto}";
                    string valor = item.Subtotal.ToString("C2", CulturaBR);
                    blocos.Add(DuasColunas(descricao, valor, FonteTexto, FonteTexto, 2));

                    if (item.Quantidade > 1)
                    {
                        string unitario = "(" + item.PrecoUnitario.ToString("C2", CulturaBR) + " cada)";
                        blocos.Add(Texto(unitario, FonteItemDetalhe, StringAlignment.Near, 4));
                    }
                }

                blocos.Add(Separador());

                // ----- Totais -----
                blocos.Add(DuasColunas("Subtotal", dados.Subtotal.ToString("C2", CulturaBR), FonteTexto, FonteTexto, 3));

                if (dados.Desconto > 0)
                {
                    blocos.Add(DuasColunas("Desconto", "- " + dados.Desconto.ToString("C2", CulturaBR), FonteTexto, FonteTexto, 3));
                }

                blocos.Add(SeparadorDuplo());
                blocos.Add(DuasColunas("TOTAL", dados.Total.ToString("C2", CulturaBR), FonteTotal, FonteTotal, 8));
                blocos.Add(Separador());

                // ----- Pagamento -----
                blocos.Add(DuasColunas("Forma de Pagamento", DescricaoForma(dados.FormaPagamento), FonteTexto, FonteTextoBold, 3));

                if (dados.FormaPagamento == FormaPagamento.Dinheiro)
                {
                    blocos.Add(DuasColunas("Valor Recebido", dados.ValorRecebido.ToString("C2", CulturaBR), FonteTexto, FonteTexto, 2));
                    blocos.Add(DuasColunas("Troco", dados.Troco.ToString("C2", CulturaBR), FonteTexto, FonteTextoBold, 6));
                }

                blocos.Add(Separador());

                // ----- Rodapé -----
                blocos.Add(Texto("Obrigado pela preferência!", FonteRodape, StringAlignment.Center, 2));
                blocos.Add(Texto("Volte sempre :)", FonteRodape, StringAlignment.Center, 10));
            }

            return blocos;
        }

        // ---------- Helpers de montagem de bloco ----------

        private static Bloco Texto(string texto, Font fonte, StringAlignment alinhamento, float espacoDepois)
        {
            float altura = fonte.GetHeight() + espacoDepois;
            return new Bloco
            {
                Altura = altura,
                Desenhar = (g, rect) =>
                {
                    using (var formato = new StringFormat { Alignment = alinhamento })
                        g.DrawString(texto, fonte, Brushes.Black, rect, formato);
                }
            };
        }

        private static Bloco DuasColunas(string esquerda, string direita, Font fonteEsq, Font fonteDir, float espacoDepois)
        {
            float altura = Math.Max(fonteEsq.GetHeight(), fonteDir.GetHeight()) + espacoDepois;
            return new Bloco
            {
                Altura = altura,
                Desenhar = (g, rect) =>
                {
                    using (var formatoEsq = new StringFormat { Alignment = StringAlignment.Near })
                        g.DrawString(esquerda, fonteEsq, Brushes.Black, rect, formatoEsq);

                    using (var formatoDir = new StringFormat { Alignment = StringAlignment.Far })
                        g.DrawString(direita, fonteDir, Brushes.Black, rect, formatoDir);
                }
            };
        }

        private static Bloco Separador()
        {
            return new Bloco
            {
                Altura = 10f,
                Desenhar = (g, rect) =>
                {
                    float meio = rect.Top + rect.Height / 2f;
                    using (var caneta = new Pen(Color.Black, 1f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                        g.DrawLine(caneta, rect.Left, meio, rect.Right, meio);
                }
            };
        }

        private static Bloco SeparadorDuplo()
        {
            return new Bloco
            {
                Altura = 12f,
                Desenhar = (g, rect) =>
                {
                    float meio = rect.Top + rect.Height / 2f;
                    using (var caneta = new Pen(Color.Black, 2f))
                        g.DrawLine(caneta, rect.Left, meio, rect.Right, meio);
                }
            };
        }

        private static string DescricaoForma(FormaPagamento forma)
        {
            switch (forma)
            {
                case FormaPagamento.Dinheiro: return "Dinheiro";
                case FormaPagamento.CartaoDebito: return "Cartão de Débito";
                case FormaPagamento.CartaoCredito: return "Cartão de Crédito";
                case FormaPagamento.Pix: return "Pix";
                default: return forma.ToString();
            }
        }
    }
}