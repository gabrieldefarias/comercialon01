using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using comercialon.classes;

namespace comercialon.Formularios
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(
                txtDescricao.Text,
                Convert.ToDouble(txtValorUnitario.Text),
                txtUnidadeVenda.Text,
                txtCodbar.Text,
                Convert.ToDouble(txtDesconto.Text),
                txtIdMarca.Text,
                txtIdCategoria.Text,
                chkDescontinuado.Checked = true
            );
            produto.Inserir();
            txtId.Text = produto.Id.ToString();
            MessageBox.Show("Usuario " + produto.Id + " inserir");
            LimparCampos();
        }
        
        private void LimparCampos()
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtValorUnitario.Clear();
            txtUnidadeVenda.Clear();
            txtCodbar.Clear();
            txtDesconto.Clear();
            txtIdMarca.Clear();
            txtIdCategoria.Clear();
        }
        private void DesbloquearControles()
        {
            txtDescricao.Enabled = true;
            txtValorUnitario.Enabled = true;
            txtUnidadeVenda.Enabled = true;
            txtCodbar.Enabled = true;
            txtDesconto.Enabled = true;
            txtIdMarca.Enabled = true;
            txtIdCategoria.Enabled = true;
        }

        private void BloquearControles()
        {
            txtDescricao.Enabled = false;
            txtValorUnitario.Enabled = false;
            txtUnidadeVenda.Enabled = false;
            txtCodbar.Enabled = false;
            txtDesconto.Enabled = false;
            txtIdMarca.Enabled = false;
            txtIdCategoria.Enabled = false;
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = int.Parse(txtId.Text);
            produto.Nome = txtNome.Text;
            produto.Telefone = txtTelefone.Text;
            produto.Email = txtEmail.Text;
            produto.Descontinuado = chkDescontinuado.Checked;
            if (produto.Alterar())
            {
                MessageBox.Show("Produto alterado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha ao alterar o produto!");
            }
        }
    }
}
