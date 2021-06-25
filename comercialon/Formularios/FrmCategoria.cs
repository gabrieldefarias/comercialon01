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
    }
}
