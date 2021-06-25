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
    }
}
