namespace Lanchonete001.Estoque
{
    partial class FrmNovoInsumo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoInsumo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeInsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblqn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategoriaInsumo = new System.Windows.Forms.ComboBox();
            this.cboUnidadeInsumo = new System.Windows.Forms.ComboBox();
            this.numQuantidadeAtual = new System.Windows.Forms.NumericUpDown();
            this.numQuantidadeMinima = new System.Windows.Forms.NumericUpDown();
            this.numPrecoUnitario = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvarInsumo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Insumo";
            // 
            // txtNomeInsumo
            // 
            this.txtNomeInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeInsumo.Location = new System.Drawing.Point(35, 116);
            this.txtNomeInsumo.Name = "txtNomeInsumo";
            this.txtNomeInsumo.Size = new System.Drawing.Size(308, 27);
            this.txtNomeInsumo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Insumo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unidade Medida:";
            // 
            // lblqn
            // 
            this.lblqn.AutoSize = true;
            this.lblqn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqn.Location = new System.Drawing.Point(30, 347);
            this.lblqn.Name = "lblqn";
            this.lblqn.Size = new System.Drawing.Size(88, 23);
            this.lblqn.TabIndex = 5;
            this.lblqn.Text = "Qntd. Atual.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Qntd. Min.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preço Unitário:";
            // 
            // cboCategoriaInsumo
            // 
            this.cboCategoriaInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaInsumo.FormattingEnabled = true;
            this.cboCategoriaInsumo.Location = new System.Drawing.Point(34, 180);
            this.cboCategoriaInsumo.Name = "cboCategoriaInsumo";
            this.cboCategoriaInsumo.Size = new System.Drawing.Size(309, 31);
            this.cboCategoriaInsumo.TabIndex = 8;
            // 
            // cboUnidadeInsumo
            // 
            this.cboUnidadeInsumo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadeInsumo.FormattingEnabled = true;
            this.cboUnidadeInsumo.Location = new System.Drawing.Point(34, 268);
            this.cboUnidadeInsumo.Name = "cboUnidadeInsumo";
            this.cboUnidadeInsumo.Size = new System.Drawing.Size(116, 31);
            this.cboUnidadeInsumo.TabIndex = 9;
            // 
            // numQuantidadeAtual
            // 
            this.numQuantidadeAtual.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeAtual.Location = new System.Drawing.Point(34, 373);
            this.numQuantidadeAtual.Name = "numQuantidadeAtual";
            this.numQuantidadeAtual.Size = new System.Drawing.Size(72, 27);
            this.numQuantidadeAtual.TabIndex = 11;
            // 
            // numQuantidadeMinima
            // 
            this.numQuantidadeMinima.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeMinima.Location = new System.Drawing.Point(271, 373);
            this.numQuantidadeMinima.Name = "numQuantidadeMinima";
            this.numQuantidadeMinima.Size = new System.Drawing.Size(72, 27);
            this.numQuantidadeMinima.TabIndex = 12;
            // 
            // numPrecoUnitario
            // 
            this.numPrecoUnitario.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecoUnitario.Location = new System.Drawing.Point(269, 272);
            this.numPrecoUnitario.Name = "numPrecoUnitario";
            this.numPrecoUnitario.Size = new System.Drawing.Size(72, 27);
            this.numPrecoUnitario.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvarInsumo,
            this.toolStripSeparator3,
            this.btnCancelar,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.btnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(404, 30);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvarInsumo
            // 
            this.btnSalvarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarInsumo.Image")));
            this.btnSalvarInsumo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarInsumo.Name = "btnSalvarInsumo";
            this.btnSalvarInsumo.Size = new System.Drawing.Size(71, 27);
            this.btnSalvarInsumo.Text = "Salvar";
            this.btnSalvarInsumo.Click += new System.EventHandler(this.btnSalvarInsumo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 27);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(75, 27);
            this.toolStripButton2.Text = "Limpar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 27);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // FrmNovoInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(404, 441);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.numPrecoUnitario);
            this.Controls.Add(this.numQuantidadeMinima);
            this.Controls.Add(this.numQuantidadeAtual);
            this.Controls.Add(this.cboUnidadeInsumo);
            this.Controls.Add(this.cboCategoriaInsumo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblqn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeInsumo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novo Insumo";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeInsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblqn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategoriaInsumo;
        private System.Windows.Forms.ComboBox cboUnidadeInsumo;
        private System.Windows.Forms.NumericUpDown numQuantidadeAtual;
        private System.Windows.Forms.NumericUpDown numQuantidadeMinima;
        private System.Windows.Forms.NumericUpDown numPrecoUnitario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvarInsumo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFechar;
    }
}