using System.Windows.Forms;

namespace Lanchonete001.Estoque
{
    partial class UcEstoque
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalInsumos = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.lblEstoqueBaixo = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.lvlValorMesas = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblValorEstoque = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscaInsumo = new System.Windows.Forms.TextBox();
            this.btnNovoInsumo = new System.Windows.Forms.Button();
            this.cboFiltroCategoriaInsumo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.lvlValorMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 55);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 56);
            this.label14.TabIndex = 5;
            this.label14.Text = "Estoque";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.flowLayoutPanel1.Controls.Add(this.panel13);
            this.flowLayoutPanel1.Controls.Add(this.panel16);
            this.flowLayoutPanel1.Controls.Add(this.lvlValorMesas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(747, 137);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.panel13.Controls.Add(this.label16);
            this.panel13.Controls.Add(this.lblTotalInsumos);
            this.panel13.Controls.Add(this.pictureBox18);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(230, 119);
            this.panel13.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(60, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 28);
            this.label16.TabIndex = 7;
            this.label16.Text = "Total de Insumos";
            // 
            // lblTotalInsumos
            // 
            this.lblTotalInsumos.AutoSize = true;
            this.lblTotalInsumos.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInsumos.Location = new System.Drawing.Point(14, 67);
            this.lblTotalInsumos.Name = "lblTotalInsumos";
            this.lblTotalInsumos.Size = new System.Drawing.Size(190, 37);
            this.lblTotalInsumos.TabIndex = 5;
            this.lblTotalInsumos.Text = "lblTotalInsumos";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_box_32;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox18.Location = new System.Drawing.Point(20, 20);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(32, 32);
            this.pictureBox18.TabIndex = 4;
            this.pictureBox18.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.panel16.Controls.Add(this.label);
            this.panel16.Controls.Add(this.lblEstoqueBaixo);
            this.panel16.Controls.Add(this.pictureBox17);
            this.panel16.Location = new System.Drawing.Point(254, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(230, 119);
            this.panel16.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(60, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 28);
            this.label.TabIndex = 7;
            this.label.Text = "Estoque Baixo";
            // 
            // lblEstoqueBaixo
            // 
            this.lblEstoqueBaixo.AutoSize = true;
            this.lblEstoqueBaixo.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueBaixo.Location = new System.Drawing.Point(14, 67);
            this.lblEstoqueBaixo.Name = "lblEstoqueBaixo";
            this.lblEstoqueBaixo.Size = new System.Drawing.Size(188, 37);
            this.lblEstoqueBaixo.TabIndex = 5;
            this.lblEstoqueBaixo.Text = "lblEstoqueBaixo";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_error_32;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox17.Location = new System.Drawing.Point(20, 20);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(32, 32);
            this.pictureBox17.TabIndex = 4;
            this.pictureBox17.TabStop = false;
            // 
            // lvlValorMesas
            // 
            this.lvlValorMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.lvlValorMesas.Controls.Add(this.label19);
            this.lvlValorMesas.Controls.Add(this.lblValorEstoque);
            this.lvlValorMesas.Controls.Add(this.pictureBox19);
            this.lvlValorMesas.Location = new System.Drawing.Point(508, 0);
            this.lvlValorMesas.Margin = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.lvlValorMesas.Name = "lvlValorMesas";
            this.lvlValorMesas.Size = new System.Drawing.Size(230, 119);
            this.lvlValorMesas.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(60, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 28);
            this.label19.TabIndex = 7;
            this.label19.Text = "Valor em Estoque";
            // 
            // lblValorEstoque
            // 
            this.lblValorEstoque.AutoSize = true;
            this.lblValorEstoque.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEstoque.Location = new System.Drawing.Point(14, 67);
            this.lblValorEstoque.Name = "lblValorEstoque";
            this.lblValorEstoque.Size = new System.Drawing.Size(186, 37);
            this.lblValorEstoque.TabIndex = 5;
            this.lblValorEstoque.Text = "lblValorEstoque";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_us_dollar_circled_32;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox19.Location = new System.Drawing.Point(20, 20);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(32, 32);
            this.pictureBox19.TabIndex = 4;
            this.pictureBox19.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.picBuscar);
            this.panel2.Controls.Add(this.txtBuscaInsumo);
            this.panel2.Controls.Add(this.btnNovoInsumo);
            this.panel2.Controls.Add(this.cboFiltroCategoriaInsumo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 32);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(251, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 32);
            this.panel3.TabIndex = 20;
            // 
            // picBuscar
            // 
            this.picBuscar.BackgroundImage = global::Lanchonete001.Properties.Resources.icons8_search_25;
            this.picBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBuscar.Location = new System.Drawing.Point(518, 0);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(22, 27);
            this.picBuscar.TabIndex = 19;
            this.picBuscar.TabStop = false;
            // 
            // txtBuscaInsumo
            // 
            this.txtBuscaInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscaInsumo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaInsumo.Location = new System.Drawing.Point(300, 0);
            this.txtBuscaInsumo.Name = "txtBuscaInsumo";
            this.txtBuscaInsumo.Size = new System.Drawing.Size(212, 30);
            this.txtBuscaInsumo.TabIndex = 18;
            // 
            // btnNovoInsumo
            // 
            this.btnNovoInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.btnNovoInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoInsumo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNovoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoInsumo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNovoInsumo.Location = new System.Drawing.Point(626, 0);
            this.btnNovoInsumo.Name = "btnNovoInsumo";
            this.btnNovoInsumo.Size = new System.Drawing.Size(121, 32);
            this.btnNovoInsumo.TabIndex = 17;
            this.btnNovoInsumo.Text = "Novo Insumo";
            this.btnNovoInsumo.UseVisualStyleBackColor = false;
            this.btnNovoInsumo.Click += new System.EventHandler(this.btnNovoInsumo_Click);
            // 
            // cboFiltroCategoriaInsumo
            // 
            this.cboFiltroCategoriaInsumo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboFiltroCategoriaInsumo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltroCategoriaInsumo.FormattingEnabled = true;
            this.cboFiltroCategoriaInsumo.Location = new System.Drawing.Point(0, 0);
            this.cboFiltroCategoriaInsumo.Name = "cboFiltroCategoriaInsumo";
            this.cboFiltroCategoriaInsumo.Size = new System.Drawing.Size(251, 30);
            this.cboFiltroCategoriaInsumo.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 48;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(179)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 224);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 48;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 353);
            this.dataGridView1.TabIndex = 6;
            // 
            // UcEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "UcEstoque";
            this.Size = new System.Drawing.Size(747, 577);
            this.Load += new System.EventHandler(this.UcEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.lvlValorMesas.ResumeLayout(false);
            this.lvlValorMesas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalInsumos;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblEstoqueBaixo;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Panel lvlValorMesas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblValorEstoque;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboFiltroCategoriaInsumo;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.TextBox txtBuscaInsumo;
        private System.Windows.Forms.Button btnNovoInsumo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
    }
}
