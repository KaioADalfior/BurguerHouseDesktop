using System.Drawing;
using System.Windows.Forms;
using Lanchonete001.UI;

namespace Lanchonete001.Usuarios
{
    partial class UcUsuarios
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Lanchonete001.UI.RoundedPanel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardTotal = new Lanchonete001.UI.RoundedPanel();
            this.pnlIconTotal = new Lanchonete001.UI.RoundedPanel();
            this.picIconTotal = new System.Windows.Forms.PictureBox();
            this.lblCaptionTotal = new System.Windows.Forms.Label();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.pnlCardAtivos = new Lanchonete001.UI.RoundedPanel();
            this.pnlIconAtivos = new Lanchonete001.UI.RoundedPanel();
            this.picIconAtivos = new System.Windows.Forms.PictureBox();
            this.lblCaptionAtivos = new System.Windows.Forms.Label();
            this.lblUsuariosAtivos = new System.Windows.Forms.Label();
            this.pnlCardInativos = new Lanchonete001.UI.RoundedPanel();
            this.pnlIconInativos = new Lanchonete001.UI.RoundedPanel();
            this.picIconInativos = new System.Windows.Forms.PictureBox();
            this.lblCaptionInativos = new System.Windows.Forms.Label();
            this.lblUsuariosInativos = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.tlpToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.cboFiltroCargo = new System.Windows.Forms.ComboBox();
            this.pnlSearch = new Lanchonete001.UI.RoundedPanel();
            this.txtBuscaUsuario = new System.Windows.Forms.TextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.btnNovoUsuario = new Lanchonete001.UI.RoundedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.pnlIconTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconTotal)).BeginInit();
            this.pnlCardAtivos.SuspendLayout();
            this.pnlIconAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconAtivos)).BeginInit();
            this.pnlCardInativos.SuspendLayout();
            this.pnlIconInativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconInativos)).BeginInit();
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
            this.lblSubtitulo.Size = new System.Drawing.Size(279, 23);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gerencie os usuários e cargos do sistema";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblTitulo.Location = new System.Drawing.Point(32, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 48);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Usuários";
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlCards.Controls.Add(this.pnlCardTotal);
            this.pnlCards.Controls.Add(this.pnlCardAtivos);
            this.pnlCards.Controls.Add(this.pnlCardInativos);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 70);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(32, 12, 0, 16);
            this.pnlCards.Size = new System.Drawing.Size(747, 152);
            this.pnlCards.TabIndex = 1;
            this.pnlCards.WrapContents = false;
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardTotal.BorderThickness = 1;
            this.pnlCardTotal.Controls.Add(this.pnlIconTotal);
            this.pnlCardTotal.Controls.Add(this.lblCaptionTotal);
            this.pnlCardTotal.Controls.Add(this.lblTotalUsuarios);
            this.pnlCardTotal.CornerRadius = 16;
            this.pnlCardTotal.Location = new System.Drawing.Point(32, 12);
            this.pnlCardTotal.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(210, 120);
            this.pnlCardTotal.TabIndex = 0;
            // 
            // pnlIconTotal
            // 
            this.pnlIconTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(209)))));
            this.pnlIconTotal.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIconTotal.BorderThickness = 0;
            this.pnlIconTotal.Controls.Add(this.picIconTotal);
            this.pnlIconTotal.CornerRadius = 24;
            this.pnlIconTotal.Location = new System.Drawing.Point(18, 20);
            this.pnlIconTotal.Name = "pnlIconTotal";
            this.pnlIconTotal.Size = new System.Drawing.Size(48, 48);
            this.pnlIconTotal.TabIndex = 0;
            // 
            // picIconTotal
            // 
            this.picIconTotal.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_users_38;
            this.picIconTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconTotal.Location = new System.Drawing.Point(12, 12);
            this.picIconTotal.Name = "picIconTotal";
            this.picIconTotal.Size = new System.Drawing.Size(24, 24);
            this.picIconTotal.TabIndex = 0;
            this.picIconTotal.TabStop = false;
            // 
            // lblCaptionTotal
            // 
            this.lblCaptionTotal.AutoSize = true;
            this.lblCaptionTotal.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionTotal.Location = new System.Drawing.Point(76, 32);
            this.lblCaptionTotal.Name = "lblCaptionTotal";
            this.lblCaptionTotal.Size = new System.Drawing.Size(126, 23);
            this.lblCaptionTotal.TabIndex = 1;
            this.lblCaptionTotal.Text = "Total de Usuários";
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.lblTotalUsuarios.Location = new System.Drawing.Point(18, 74);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(38, 48);
            this.lblTotalUsuarios.TabIndex = 2;
            this.lblTotalUsuarios.Text = "0";
            // 
            // pnlCardAtivos
            // 
            this.pnlCardAtivos.BackColor = System.Drawing.Color.White;
            this.pnlCardAtivos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardAtivos.BorderThickness = 1;
            this.pnlCardAtivos.Controls.Add(this.pnlIconAtivos);
            this.pnlCardAtivos.Controls.Add(this.lblCaptionAtivos);
            this.pnlCardAtivos.Controls.Add(this.lblUsuariosAtivos);
            this.pnlCardAtivos.CornerRadius = 16;
            this.pnlCardAtivos.Location = new System.Drawing.Point(258, 12);
            this.pnlCardAtivos.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardAtivos.Name = "pnlCardAtivos";
            this.pnlCardAtivos.Size = new System.Drawing.Size(210, 120);
            this.pnlCardAtivos.TabIndex = 1;
            // 
            // pnlIconAtivos
            // 
            this.pnlIconAtivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.pnlIconAtivos.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIconAtivos.BorderThickness = 0;
            this.pnlIconAtivos.Controls.Add(this.picIconAtivos);
            this.pnlIconAtivos.CornerRadius = 24;
            this.pnlIconAtivos.Location = new System.Drawing.Point(18, 20);
            this.pnlIconAtivos.Name = "pnlIconAtivos";
            this.pnlIconAtivos.Size = new System.Drawing.Size(48, 48);
            this.pnlIconAtivos.TabIndex = 0;
            // 
            // picIconAtivos
            // 
            this.picIconAtivos.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_avatar_38;
            this.picIconAtivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconAtivos.Location = new System.Drawing.Point(12, 12);
            this.picIconAtivos.Name = "picIconAtivos";
            this.picIconAtivos.Size = new System.Drawing.Size(24, 24);
            this.picIconAtivos.TabIndex = 0;
            this.picIconAtivos.TabStop = false;
            // 
            // lblCaptionAtivos
            // 
            this.lblCaptionAtivos.AutoSize = true;
            this.lblCaptionAtivos.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionAtivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionAtivos.Location = new System.Drawing.Point(76, 32);
            this.lblCaptionAtivos.Name = "lblCaptionAtivos";
            this.lblCaptionAtivos.Size = new System.Drawing.Size(114, 23);
            this.lblCaptionAtivos.TabIndex = 1;
            this.lblCaptionAtivos.Text = "Usuários Ativos";
            // 
            // lblUsuariosAtivos
            // 
            this.lblUsuariosAtivos.AutoSize = true;
            this.lblUsuariosAtivos.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosAtivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblUsuariosAtivos.Location = new System.Drawing.Point(18, 74);
            this.lblUsuariosAtivos.Name = "lblUsuariosAtivos";
            this.lblUsuariosAtivos.Size = new System.Drawing.Size(38, 48);
            this.lblUsuariosAtivos.TabIndex = 2;
            this.lblUsuariosAtivos.Text = "0";
            // 
            // pnlCardInativos
            // 
            this.pnlCardInativos.BackColor = System.Drawing.Color.White;
            this.pnlCardInativos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlCardInativos.BorderThickness = 1;
            this.pnlCardInativos.Controls.Add(this.pnlIconInativos);
            this.pnlCardInativos.Controls.Add(this.lblCaptionInativos);
            this.pnlCardInativos.Controls.Add(this.lblUsuariosInativos);
            this.pnlCardInativos.CornerRadius = 16;
            this.pnlCardInativos.Location = new System.Drawing.Point(484, 12);
            this.pnlCardInativos.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlCardInativos.Name = "pnlCardInativos";
            this.pnlCardInativos.Size = new System.Drawing.Size(210, 120);
            this.pnlCardInativos.TabIndex = 2;
            // 
            // pnlIconInativos
            // 
            this.pnlIconInativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(213)))), ((int)(((byte)(208)))));
            this.pnlIconInativos.BorderColor = System.Drawing.Color.Transparent;
            this.pnlIconInativos.BorderThickness = 0;
            this.pnlIconInativos.Controls.Add(this.picIconInativos);
            this.pnlIconInativos.CornerRadius = 24;
            this.pnlIconInativos.Location = new System.Drawing.Point(18, 20);
            this.pnlIconInativos.Name = "pnlIconInativos";
            this.pnlIconInativos.Size = new System.Drawing.Size(48, 48);
            this.pnlIconInativos.TabIndex = 0;
            // 
            // picIconInativos
            // 
            this.picIconInativos.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_error_32;
            this.picIconInativos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIconInativos.Location = new System.Drawing.Point(12, 12);
            this.picIconInativos.Name = "picIconInativos";
            this.picIconInativos.Size = new System.Drawing.Size(24, 24);
            this.picIconInativos.TabIndex = 0;
            this.picIconInativos.TabStop = false;
            // 
            // lblCaptionInativos
            // 
            this.lblCaptionInativos.AutoSize = true;
            this.lblCaptionInativos.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionInativos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.lblCaptionInativos.Location = new System.Drawing.Point(76, 32);
            this.lblCaptionInativos.Name = "lblCaptionInativos";
            this.lblCaptionInativos.Size = new System.Drawing.Size(126, 23);
            this.lblCaptionInativos.TabIndex = 1;
            this.lblCaptionInativos.Text = "Usuários Inativos";
            // 
            // lblUsuariosInativos
            // 
            this.lblUsuariosInativos.AutoSize = true;
            this.lblUsuariosInativos.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosInativos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(54)))));
            this.lblUsuariosInativos.Location = new System.Drawing.Point(18, 74);
            this.lblUsuariosInativos.Name = "lblUsuariosInativos";
            this.lblUsuariosInativos.Size = new System.Drawing.Size(38, 48);
            this.lblUsuariosInativos.TabIndex = 2;
            this.lblUsuariosInativos.Text = "0";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.pnlToolbar.Controls.Add(this.tlpToolbar);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 222);
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
            this.tlpToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpToolbar.Controls.Add(this.cboFiltroCargo, 0, 0);
            this.tlpToolbar.Controls.Add(this.pnlSearch, 2, 0);
            this.tlpToolbar.Controls.Add(this.btnNovoUsuario, 4, 0);
            this.tlpToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToolbar.Location = new System.Drawing.Point(32, 8);
            this.tlpToolbar.Name = "tlpToolbar";
            this.tlpToolbar.RowCount = 1;
            this.tlpToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToolbar.Size = new System.Drawing.Size(683, 36);
            this.tlpToolbar.TabIndex = 0;
            // 
            // cboFiltroCargo
            // 
            this.cboFiltroCargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFiltroCargo.BackColor = System.Drawing.Color.White;
            this.cboFiltroCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltroCargo.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.cboFiltroCargo.FormattingEnabled = true;
            this.cboFiltroCargo.Location = new System.Drawing.Point(3, 4);
            this.cboFiltroCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFiltroCargo.Name = "cboFiltroCargo";
            this.cboFiltroCargo.Size = new System.Drawing.Size(204, 31);
            this.cboFiltroCargo.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.Controls.Add(this.txtBuscaUsuario);
            this.pnlSearch.Controls.Add(this.picBuscar);
            this.pnlSearch.CornerRadius = 12;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(226, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(261, 36);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtBuscaUsuario
            // 
            this.txtBuscaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaUsuario.BackColor = System.Drawing.Color.White;
            this.txtBuscaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscaUsuario.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.txtBuscaUsuario.Location = new System.Drawing.Point(44, 9);
            this.txtBuscaUsuario.Name = "txtBuscaUsuario";
            this.txtBuscaUsuario.Size = new System.Drawing.Size(205, 20);
            this.txtBuscaUsuario.TabIndex = 1;
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
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.btnNovoUsuario.CornerRadius = 12;
            this.btnNovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoUsuario.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNovoUsuario.Location = new System.Drawing.Point(503, 0);
            this.btnNovoUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(180, 36);
            this.btnNovoUsuario.TabIndex = 2;
            this.btnNovoUsuario.Text = "+  Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 48;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 278);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 52;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 299);
            this.dataGridView1.TabIndex = 3;
            // 
            // UcUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UcUsuarios";
            this.Size = new System.Drawing.Size(747, 577);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            this.pnlIconTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconTotal)).EndInit();
            this.pnlCardAtivos.ResumeLayout(false);
            this.pnlCardAtivos.PerformLayout();
            this.pnlIconAtivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconAtivos)).EndInit();
            this.pnlCardInativos.ResumeLayout(false);
            this.pnlCardInativos.PerformLayout();
            this.pnlIconInativos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconInativos)).EndInit();
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
        private Lanchonete001.UI.RoundedPanel pnlIconTotal;
        private System.Windows.Forms.PictureBox picIconTotal;
        private System.Windows.Forms.Label lblCaptionTotal;
        private System.Windows.Forms.Label lblTotalUsuarios;

        private Lanchonete001.UI.RoundedPanel pnlCardAtivos;
        private Lanchonete001.UI.RoundedPanel pnlIconAtivos;
        private System.Windows.Forms.PictureBox picIconAtivos;
        private System.Windows.Forms.Label lblCaptionAtivos;
        private System.Windows.Forms.Label lblUsuariosAtivos;

        private Lanchonete001.UI.RoundedPanel pnlCardInativos;
        private Lanchonete001.UI.RoundedPanel pnlIconInativos;
        private System.Windows.Forms.PictureBox picIconInativos;
        private System.Windows.Forms.Label lblCaptionInativos;
        private System.Windows.Forms.Label lblUsuariosInativos;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TableLayoutPanel tlpToolbar;
        private System.Windows.Forms.ComboBox cboFiltroCargo;
        private Lanchonete001.UI.RoundedPanel pnlSearch;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.TextBox txtBuscaUsuario;
        private Lanchonete001.UI.RoundedButton btnNovoUsuario;

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}