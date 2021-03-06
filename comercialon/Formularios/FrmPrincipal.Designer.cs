namespace comercialon.Formularios
{
    partial class FrmPrincipal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosProdutosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosProdutosLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroUsuarioNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroUsuarioLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosMarcasNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosMarcasLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosCategoriasNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosCategoriasLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperacoesPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperacoesPedidoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1249, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastros,
            this.tsmOperacoes,
            this.tsmMovimento,
            this.tsmRelatorios,
            this.tsmConfiguracoes,
            this.tsmAjuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1249, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // tsmCadastros
            // 
            this.tsmCadastros.BackColor = System.Drawing.SystemColors.Control;
            this.tsmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrosCliente,
            this.tsmCadastrosProdutos,
            this.tsmCadastrosUsuarios,
            this.tsmCadastrosMarcas,
            this.tsmCadastrosCategorias});
            this.tsmCadastros.Image = global::comercialon.Properties.Resources.Home;
            this.tsmCadastros.Name = "tsmCadastros";
            this.tsmCadastros.Size = new System.Drawing.Size(87, 20);
            this.tsmCadastros.Text = "&Cadastros";
            // 
            // tsmCadastrosCliente
            // 
            this.tsmCadastrosCliente.Image = global::comercialon.Properties.Resources.Edit;
            this.tsmCadastrosCliente.Name = "tsmCadastrosCliente";
            this.tsmCadastrosCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosCliente.Text = "&Clientes";
            this.tsmCadastrosCliente.Click += new System.EventHandler(this.tsmCadastrosCliente_Click);
            // 
            // tsmCadastrosProdutos
            // 
            this.tsmCadastrosProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrosProdutosNovo,
            this.tsmCadastrosProdutosLista});
            this.tsmCadastrosProdutos.Image = global::comercialon.Properties.Resources.Edit;
            this.tsmCadastrosProdutos.Name = "tsmCadastrosProdutos";
            this.tsmCadastrosProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosProdutos.Text = "&Produtos";
            this.tsmCadastrosProdutos.Click += new System.EventHandler(this.tsmCadastrosProdutos_Click);
            // 
            // tsmCadastrosProdutosNovo
            // 
            this.tsmCadastrosProdutosNovo.Image = global::comercialon.Properties.Resources.Add;
            this.tsmCadastrosProdutosNovo.Name = "tsmCadastrosProdutosNovo";
            this.tsmCadastrosProdutosNovo.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosProdutosNovo.Text = "&Novo";
            this.tsmCadastrosProdutosNovo.Click += new System.EventHandler(this.tsmCadastrosProdutosNovo_Click_1);
            // 
            // tsmCadastrosProdutosLista
            // 
            this.tsmCadastrosProdutosLista.Image = global::comercialon.Properties.Resources.Search;
            this.tsmCadastrosProdutosLista.Name = "tsmCadastrosProdutosLista";
            this.tsmCadastrosProdutosLista.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosProdutosLista.Text = "&Lista";
            // 
            // tsmCadastrosUsuarios
            // 
            this.tsmCadastrosUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroUsuarioNovo,
            this.tsmCadastroUsuarioLista});
            this.tsmCadastrosUsuarios.Image = global::comercialon.Properties.Resources.Edit;
            this.tsmCadastrosUsuarios.Name = "tsmCadastrosUsuarios";
            this.tsmCadastrosUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosUsuarios.Text = "&Usuários";
            // 
            // tsmCadastroUsuarioNovo
            // 
            this.tsmCadastroUsuarioNovo.Image = global::comercialon.Properties.Resources.Add;
            this.tsmCadastroUsuarioNovo.Name = "tsmCadastroUsuarioNovo";
            this.tsmCadastroUsuarioNovo.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastroUsuarioNovo.Text = "&Novo";
            this.tsmCadastroUsuarioNovo.Click += new System.EventHandler(this.tsmCadastroUsuarioNovo_Click);
            // 
            // tsmCadastroUsuarioLista
            // 
            this.tsmCadastroUsuarioLista.Image = global::comercialon.Properties.Resources.Search;
            this.tsmCadastroUsuarioLista.Name = "tsmCadastroUsuarioLista";
            this.tsmCadastroUsuarioLista.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastroUsuarioLista.Text = "&Lista";
            // 
            // tsmCadastrosMarcas
            // 
            this.tsmCadastrosMarcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrosMarcasNovo,
            this.tsmCadastrosMarcasLista});
            this.tsmCadastrosMarcas.Image = global::comercialon.Properties.Resources.Edit;
            this.tsmCadastrosMarcas.Name = "tsmCadastrosMarcas";
            this.tsmCadastrosMarcas.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosMarcas.Text = "&Marcas";
            this.tsmCadastrosMarcas.Click += new System.EventHandler(this.tsmCadastrosMarcas_Click);
            // 
            // tsmCadastrosMarcasNovo
            // 
            this.tsmCadastrosMarcasNovo.Image = global::comercialon.Properties.Resources.Add;
            this.tsmCadastrosMarcasNovo.Name = "tsmCadastrosMarcasNovo";
            this.tsmCadastrosMarcasNovo.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosMarcasNovo.Text = "&Novo";
            this.tsmCadastrosMarcasNovo.Click += new System.EventHandler(this.tsmCadastrosMarcasNovo_Click);
            // 
            // tsmCadastrosMarcasLista
            // 
            this.tsmCadastrosMarcasLista.Image = global::comercialon.Properties.Resources.Search;
            this.tsmCadastrosMarcasLista.Name = "tsmCadastrosMarcasLista";
            this.tsmCadastrosMarcasLista.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosMarcasLista.Text = "&Lista";
            // 
            // tsmCadastrosCategorias
            // 
            this.tsmCadastrosCategorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrosCategoriasNovo,
            this.tsmCadastrosCategoriasLista});
            this.tsmCadastrosCategorias.Image = global::comercialon.Properties.Resources.Edit;
            this.tsmCadastrosCategorias.Name = "tsmCadastrosCategorias";
            this.tsmCadastrosCategorias.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosCategorias.Text = "&Categoria";
            this.tsmCadastrosCategorias.Click += new System.EventHandler(this.tsmCadastrosCategorias_Click);
            // 
            // tsmCadastrosCategoriasNovo
            // 
            this.tsmCadastrosCategoriasNovo.Image = global::comercialon.Properties.Resources.Add;
            this.tsmCadastrosCategoriasNovo.Name = "tsmCadastrosCategoriasNovo";
            this.tsmCadastrosCategoriasNovo.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosCategoriasNovo.Text = "&Novo";
            this.tsmCadastrosCategoriasNovo.Click += new System.EventHandler(this.tsmCadastrosCategoriasNovo_Click);
            // 
            // tsmCadastrosCategoriasLista
            // 
            this.tsmCadastrosCategoriasLista.Image = global::comercialon.Properties.Resources.Search;
            this.tsmCadastrosCategoriasLista.Name = "tsmCadastrosCategoriasLista";
            this.tsmCadastrosCategoriasLista.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastrosCategoriasLista.Text = "&Lista";
            // 
            // tsmOperacoes
            // 
            this.tsmOperacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOperacoesPedido});
            this.tsmOperacoes.Image = global::comercialon.Properties.Resources.Search;
            this.tsmOperacoes.Name = "tsmOperacoes";
            this.tsmOperacoes.Size = new System.Drawing.Size(91, 20);
            this.tsmOperacoes.Text = "&Operações";
            // 
            // tsmMovimento
            // 
            this.tsmMovimento.Name = "tsmMovimento";
            this.tsmMovimento.Size = new System.Drawing.Size(81, 20);
            this.tsmMovimento.Text = "&Movimento";
            // 
            // tsmRelatorios
            // 
            this.tsmRelatorios.Name = "tsmRelatorios";
            this.tsmRelatorios.Size = new System.Drawing.Size(71, 20);
            this.tsmRelatorios.Text = "&Relatórios";
            // 
            // tsmConfiguracoes
            // 
            this.tsmConfiguracoes.Name = "tsmConfiguracoes";
            this.tsmConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.tsmConfiguracoes.Text = "Con&figurações";
            // 
            // tsmAjuda
            // 
            this.tsmAjuda.Name = "tsmAjuda";
            this.tsmAjuda.Size = new System.Drawing.Size(50, 20);
            this.tsmAjuda.Text = "&Ajuda";
            // 
            // tsmOperacoesPedido
            // 
            this.tsmOperacoesPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOperacoesPedidoNovo});
            this.tsmOperacoesPedido.Image = global::comercialon.Properties.Resources.Edit;
            this.tsmOperacoesPedido.Name = "tsmOperacoesPedido";
            this.tsmOperacoesPedido.Size = new System.Drawing.Size(180, 22);
            this.tsmOperacoesPedido.Text = "&Pedido";
            // 
            // tsmOperacoesPedidoNovo
            // 
            this.tsmOperacoesPedidoNovo.Image = global::comercialon.Properties.Resources.Add;
            this.tsmOperacoesPedidoNovo.Name = "tsmOperacoesPedidoNovo";
            this.tsmOperacoesPedidoNovo.Size = new System.Drawing.Size(180, 22);
            this.tsmOperacoesPedidoNovo.Text = "&Novo";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Click += new System.EventHandler(this.FrmPrincipal_Click);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmOperacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmMovimento;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem tsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosProdutosNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosProdutosLista;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosMarcasNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosMarcasLista;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosCategoriasNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosCategoriasLista;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroUsuarioNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroUsuarioLista;
        private System.Windows.Forms.ToolStripMenuItem tsmOperacoesPedido;
        private System.Windows.Forms.ToolStripMenuItem tsmOperacoesPedidoNovo;
    }
}