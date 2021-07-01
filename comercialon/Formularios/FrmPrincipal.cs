using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comercialon.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsmCadastrosCliente_Click(object sender, EventArgs e)
        {
            Form1 frmCliente = new Form1();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void tsmCadastrosProdutos_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void tsmCadastrosProdutosNovo_Click_1(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void tsmCadastrosMarcas_Click(object sender, EventArgs e)
        {

        }

        private void tsmCadastrosCategorias_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmCadastrosCategoriasNovo_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void tsmCadastrosMarcasNovo_Click(object sender, EventArgs e)
        {
            FrmMarcas frmMarcas = new FrmMarcas();
            frmMarcas.MdiParent = this;
            frmMarcas.Show();
        }

        private void tsmCadastroUsuarioNovo_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuario = new FrmUsuarios();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }
    }
}
