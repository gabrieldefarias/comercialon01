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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSiglaCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(
                txtNomeCategoria.Text,
                txtSiglaCategoria.Text
            );
            categoria.Inserir();
            MessageBox.Show("Categoria " + categoria.Id + " inserir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="...")
            {
                txtIdCategoria.ReadOnly = false;
                txtIdCategoria.Focus();
                BloquearControles();
                button1.Text = "Buscar";
            }
            else
            {
                txtIdCategoria.ReadOnly = true;
                txtIdCategoria.Focus();
                DesbloquearControles();
                button1.Text = "...";
                Categoria categoria = new Categoria();
                categoria.BuscarPorId(int.Parse(txtIdCategoria.Text));
                if (categoria.Id>0)
                {
                    txtNomeCategoria.Text = categoria.Nome;
                    txtSiglaCategoria.Text = categoria.Sigla;
                }
                else
                {
                    MessageBox.Show("Categoria não encontrado!");
                }
            }
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Id = int.Parse(txtIdCategoria.Text);
            categoria.Nome = txtNomeCategoria.Text;
            categoria.Sigla = txtSiglaCategoria.Text;
            if (categoria.Alterar())
            {
                MessageBox.Show("Categoria alterado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha ao alterar a categoria!");
            }
        }

        private void DesbloquearControles()
        {
            txtNomeCategoria.Enabled = true;
            txtSiglaCategoria.Enabled = true;
        }

        private void BloquearControles()
        {
            txtNomeCategoria.Enabled = false;
            txtSiglaCategoria.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNomeCategoria.Clear();
            txtSiglaCategoria.Clear();
        }
    }
}
