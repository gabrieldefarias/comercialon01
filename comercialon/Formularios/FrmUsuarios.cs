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
using System.Text.RegularExpressions;

namespace comercialon.Formularios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // remove pontos e traços do cpf
            Usuario usuario = new Usuario(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                txtNivel.Text,
                mskCpf.Text
            );
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show("Usuario " + usuario.Id + " inserir");
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtNivel.Clear();
            mskCpf.Clear();
        }
        private void DesbloquearControles()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            txtNivel.Enabled = true;
            mskCpf.Enabled = true;
        }

        private void BloquearControles()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            txtNivel.Enabled = false;
            mskCpf.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                BloquearControles();
                button1.Text = "Buscar";
            }
            else
            {
                txtId.ReadOnly = true;
                txtNome.Focus();
                DesbloquearControles();
                button1.Text = "...";
                Usuario usuario = new Usuario();
                usuario.BuscarPorId(int.Parse(txtId.Text));
                if (usuario.Id > 0)
                {
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtSenha.Text = usuario.Senha;
                    txtNivel.Text = usuario.Nivel;
                    mskCpf.Text = usuario.Cpf;
                    mskCpf.Enabled = false;
                    chkAtivo.Checked = usuario.Ativo;
                    chkAtivo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = int.Parse(txtId.Text);
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Nivel = txtNivel.Text;
            usuario.Cpf = mskCpf.Text;
            usuario.Ativo = chkAtivo.Checked;
            if (usuario.Alterar())
            {
                MessageBox.Show("Usuario alterado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha ao alterar o usuario!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            var lista = Usuario.ListarTodos();
            foreach (var item in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[2].Value = item.Email;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[3].Value = item.Nivel;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[4].Value = item.Cpf;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[5].Value = item.Ativo;
            }
        }
    }
}
