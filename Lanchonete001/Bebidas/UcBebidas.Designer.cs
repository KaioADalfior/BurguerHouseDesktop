using Lanchonete001.UI;

namespace Lanchonete001.Bebidas
{
    partial class UcBebidas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Lanchonete001.UI.RoundedPanel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardTotal = new Lanchonete001.UI.RoundedPanel();
            this.lblCaptionTotal = new System.Windows.Forms.Label();
            this.lblTotalItens = new System.Windows.Forms.Label();
            this.pnlCardIndisponiveis = new Lanchonete001.UI.RoundedPanel();
            this.lblCaptionIndisponiveis = new System.Windows.Forms.Label();
            this.lblIndisponiveis = new System.Windows.Forms.Label();
            this.pnlCardMargem = new Lanchonete001.UI.RoundedPanel();
            this.lblCaptionMargem = new System.Windows.Forms.Label();
            this.lblMargemMedia = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.tlpToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.cboFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.pnlSearch = new Lanchonete001.UI.RoundedPanel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.btnNovoBebida = new Lanchonete001.UI.RoundedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.pnlCardIndisponiveis.SuspendLayout();
            this.pnlCardMargem.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.tlpToolbar.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlHeader.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderThickness = 0;
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.CornerRadius = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(747, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(227, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gerencie as bebidas do cardápio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblTitulo.Location = new System.Drawing.Point(32, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bebidas";
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlCards.Controls.Add(this.pnlCardTotal);
            this.pnlCards.Controls.Add(this.pnlCardIndisponiveis);
            this.pnlCards.Controls.Add(this.pnlCardMargem);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 70);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(32, 12, 0, 16);
            this.pnlCards.Size = new System.Drawing.Size(747, 120);
            this.pnlCards.TabIndex = 1;
            this.pnlCards.WrapContents = false;
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardTotal.BorderThickness = 1;
            this.pnlCardTotal.Controls.Add(this.lblCaptionTotal);
            this.pnlCardTotal.Controls.Add(this.lblTotalItens);
            this.pnlCardTotal.CornerRadius = 16;
            this.pnlCardTotal.Location = new System.Drawing.Point(32, 12);
            this.pnlCardTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(210, 92);
            this.pnlCardTotal.TabIndex = 0;
            // 
            // lblCaptionTotal
            // 
            this.lblCaptionTotal.AutoSize = true;
            this.lblCaptionTotal.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionTotal.Location = new System.Drawing.Point(18, 16);
            this.lblCaptionTotal.Name = "lblCaptionTotal";
            this.lblCaptionTotal.Size = new System.Drawing.Size(122, 23);
            this.lblCaptionTotal.TabIndex = 0;
            this.lblCaptionTotal.Text = "Total de Bebidas";
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.AutoSize = true;
            this.lblTotalItens.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblTotalItens.Location = new System.Drawing.Point(18, 44);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(38, 48);
            this.lblTotalItens.TabIndex = 1;
            this.lblTotalItens.Text = "0";
            // 
            // pnlCardIndisponiveis
            // 
            this.pnlCardIndisponiveis.BackColor = System.Drawing.Color.White;
            this.pnlCardIndisponiveis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardIndisponiveis.BorderThickness = 1;
            this.pnlCardIndisponiveis.Controls.Add(this.lblCaptionIndisponiveis);
            this.pnlCardIndisponiveis.Controls.Add(this.lblIndisponiveis);
            this.pnlCardIndisponiveis.CornerRadius = 16;
            this.pnlCardIndisponiveis.Location = new System.Drawing.Point(258, 12);
            this.pnlCardIndisponiveis.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardIndisponiveis.Name = "pnlCardIndisponiveis";
            this.pnlCardIndisponiveis.Size = new System.Drawing.Size(210, 92);
            this.pnlCardIndisponiveis.TabIndex = 1;
            // 
            // lblCaptionIndisponiveis
            // 
            this.lblCaptionIndisponiveis.AutoSize = true;
            this.lblCaptionIndisponiveis.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionIndisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionIndisponiveis.Location = new System.Drawing.Point(18, 16);
            this.lblCaptionIndisponiveis.Name = "lblCaptionIndisponiveis";
            this.lblCaptionIndisponiveis.Size = new System.Drawing.Size(100, 23);
            this.lblCaptionIndisponiveis.TabIndex = 0;
            this.lblCaptionIndisponiveis.Text = "Indisponíveis";
            // 
            // lblIndisponiveis
            // 
            this.lblIndisponiveis.AutoSize = true;
            this.lblIndisponiveis.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(54)))));
            this.lblIndisponiveis.Location = new System.Drawing.Point(18, 44);
            this.lblIndisponiveis.Name = "lblIndisponiveis";
            this.lblIndisponiveis.Size = new System.Drawing.Size(38, 48);
            this.lblIndisponiveis.TabIndex = 1;
            this.lblIndisponiveis.Text = "0";
            // 
            // pnlCardMargem
            // 
            this.pnlCardMargem.BackColor = System.Drawing.Color.White;
            this.pnlCardMargem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardMargem.BorderThickness = 1;
            this.pnlCardMargem.Controls.Add(this.lblCaptionMargem);
            this.pnlCardMargem.Controls.Add(this.lblMargemMedia);
            this.pnlCardMargem.CornerRadius = 16;
            this.pnlCardMargem.Location = new System.Drawing.Point(484, 12);
            this.pnlCardMargem.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardMargem.Name = "pnlCardMargem";
            this.pnlCardMargem.Size = new System.Drawing.Size(210, 92);
            this.pnlCardMargem.TabIndex = 2;
            // 
            // lblCaptionMargem
            // 
            this.lblCaptionMargem.AutoSize = true;
            this.lblCaptionMargem.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionMargem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionMargem.Location = new System.Drawing.Point(18, 16);
            this.lblCaptionMargem.Name = "lblCaptionMargem";
            this.lblCaptionMargem.Size = new System.Drawing.Size(113, 23);
            this.lblCaptionMargem.TabIndex = 0;
            this.lblCaptionMargem.Text = "Margem Média";
            // 
            // lblMargemMedia
            // 
            this.lblMargemMedia.AutoSize = true;
            this.lblMargemMedia.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargemMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblMargemMedia.Location = new System.Drawing.Point(18, 44);
            this.lblMargemMedia.Name = "lblMargemMedia";
            this.lblMargemMedia.Size = new System.Drawing.Size(87, 48);
            this.lblMargemMedia.TabIndex = 1;
            this.lblMargemMedia.Text = "0,0%";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlToolbar.Controls.Add(this.tlpToolbar);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 190);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(32, 8, 32, 12);
            this.pnlToolbar.Size = new System.Drawing.Size(747, 56);
            this.pnlToolbar.TabIndex = 2;
            // 
            // tlpToolbar
            // 
            this.tlpToolbar.ColumnCount = 5;
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpToolbar.Controls.Add(this.cboFiltroCategoria, 0, 0);
            this.tlpToolbar.Controls.Add(this.pnlSearch, 2, 0);
            this.tlpToolbar.Controls.Add(this.btnNovoBebida, 4, 0);
            this.tlpToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToolbar.Location = new System.Drawing.Point(32, 8);
            this.tlpToolbar.Name = "tlpToolbar";
            this.tlpToolbar.RowCount = 1;
            this.tlpToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToolbar.Size = new System.Drawing.Size(683, 36);
            this.tlpToolbar.TabIndex = 0;
            // 
            // cboFiltroCategoria
            // 
            this.cboFiltroCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFiltroCategoria.BackColor = System.Drawing.Color.White;
            this.cboFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltroCategoria.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.cboFiltroCategoria.FormattingEnabled = true;
            this.cboFiltroCategoria.Location = new System.Drawing.Point(3, 4);
            this.cboFiltroCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFiltroCategoria.Name = "cboFiltroCategoria";
            this.cboFiltroCategoria.Size = new System.Drawing.Size(204, 31);
            this.cboFiltroCategoria.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.Controls.Add(this.txtBusca);
            this.pnlSearch.Controls.Add(this.picBuscar);
            this.pnlSearch.CornerRadius = 12;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(226, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(271, 36);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusca.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.txtBusca.Location = new System.Drawing.Point(44, 9);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(215, 20);
            this.txtBusca.TabIndex = 1;
            // 
            // picBuscar
            // 
            this.picBuscar.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_search_25;
            this.picBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBuscar.Location = new System.Drawing.Point(14, 8);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(20, 20);
            this.picBuscar.TabIndex = 0;
            this.picBuscar.TabStop = false;
            // 
            // btnNovoBebida
            // 
            this.btnNovoBebida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.btnNovoBebida.CornerRadius = 12;
            this.btnNovoBebida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoBebida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovoBebida.FlatAppearance.BorderSize = 0;
            this.btnNovoBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoBebida.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoBebida.ForeColor = System.Drawing.Color.White;
            this.btnNovoBebida.Location = new System.Drawing.Point(513, 0);
            this.btnNovoBebida.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoBebida.Name = "btnNovoBebida";
            this.btnNovoBebida.Size = new System.Drawing.Size(170, 36);
            this.btnNovoBebida.TabIndex = 2;
            this.btnNovoBebida.Text = "+  Nova Bebida";
            this.btnNovoBebida.UseVisualStyleBackColor = false;
            this.btnNovoBebida.Click += new System.EventHandler(this.btnNovoBebida_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 48;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 246);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 52;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 331);
            this.dataGridView1.TabIndex = 3;
            // 
            // UcBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UcBebidas";
            this.Size = new System.Drawing.Size(747, 577);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            this.pnlCardIndisponiveis.ResumeLayout(false);
            this.pnlCardIndisponiveis.PerformLayout();
            this.pnlCardMargem.ResumeLayout(false);
            this.pnlCardMargem.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.tlpToolbar.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Lanchonete001.UI.RoundedPanel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.FlowLayoutPanel pnlCards;
        private Lanchonete001.UI.RoundedPanel pnlCardTotal;
        private System.Windows.Forms.Label lblCaptionTotal;
        private System.Windows.Forms.Label lblTotalItens;
        private Lanchonete001.UI.RoundedPanel pnlCardIndisponiveis;
        private System.Windows.Forms.Label lblCaptionIndisponiveis;
        private System.Windows.Forms.Label lblIndisponiveis;
        private Lanchonete001.UI.RoundedPanel pnlCardMargem;
        private System.Windows.Forms.Label lblCaptionMargem;
        private System.Windows.Forms.Label lblMargemMedia;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TableLayoutPanel tlpToolbar;
        private System.Windows.Forms.ComboBox cboFiltroCategoria;
        private Lanchonete001.UI.RoundedPanel pnlSearch;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private Lanchonete001.UI.RoundedButton btnNovoBebida;

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}