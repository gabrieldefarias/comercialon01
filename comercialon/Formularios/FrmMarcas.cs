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
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void txtIdMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca(
                txtNomeMarca.Text,
                txtSigla.Text
            );
            marca.Inserir();
            MessageBox.Show("Marca " + marca.Id + " inserir");
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Id = int.Parse(txtIdMarca.Text);
            marca.Nome = txtNomeMarca.Text;
            marca.Sigla = txtSigla.Text;
            if (marca.Alterar())
            {
                MessageBox.Show("Marca alterado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha ao alterar a marca!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="...")
            {
                txtIdMarca.ReadOnly = false;
                txtIdMarca.Focus();
                BloquearControles();
                button1.Text = "Buscar";
            }
            else
            {
                txtIdMarca.ReadOnly = true;
                txtIdMarca.Focus();
                DesbloquearControles();
                button1.Text = "...";
                Marca marca = new Marca();
                marca.BuscarPorId(int.Parse(txtIdMarca.Text));
                if (marca.Id>0)
                {
                    txtNomeMarca.Text = marca.Nome;
                    txtSigla.Text = marca.Sigla;
                }
                else
                {
                    MessageBox.Show("Marca não encontrado!");
                }
            }
        }

        private void DesbloquearControles()
        {
            txtNomeMarca.Enabled = true;
            txtSigla.Enabled = true;
        }

        private void BloquearControles()
        {
            txtNomeMarca.Enabled = false;
            txtSigla.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNomeMarca.Clear();
            txtSigla.Clear();
        }
    }
}
