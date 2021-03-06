using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using comercialon.classes;

namespace comercialon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // remove pontos e traços do cpf
            Cliente cliente = new Cliente(
                txtNome.Text,
                mskCpf.Text,
                txtEmail.Text,
                txtTelefone.Text
            );
            cliente.Inserir();

            Endereco endereco = new Endereco(
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtCep.Text,
                txtBairro.Text,
                txtCidade.Text,
                cmbTipo.Text,
                txtUF.Text
            );
            endereco.Inserir(cliente.Id);
            txtID.Text = cliente.Id.ToString();
            MessageBox.Show("Cliente " + cliente.Id + " inserir");
            LimparCampos();
            btnListar_Click(sender, e);
        }
        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            mskCpf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text=="...")
            {
                txtID.ReadOnly = false;
                txtID.Focus();
                BloquearControles();
                button1.Text = "Buscar";
            }
            else
            {
                txtID.ReadOnly = true;
                txtNome.Focus();
                DesbloquearControles();
                button1.Text = "...";
                Cliente cliente = new Cliente();
                cliente.BuscarPorId(int.Parse(txtID.Text));
                if (cliente.Id>0)
                {
                    txtNome.Text = cliente.Nome;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;
                    mskCpf.Text = cliente.Cpf;
                    mskCpf.Enabled = false;
                    chkAtivo.Checked = cliente.Ativo;
                    chkAtivo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
        }

        private void DesbloquearControles()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            mskCpf.Enabled = true;
        }

        private void BloquearControles()
        { 
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            mskCpf.Enabled = false;
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(txtID.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Ativo = chkAtivo.Checked;
            if (cliente.Alterar())
            {
                MessageBox.Show("Cliente alterado com sucesso!");
                LimparCampos();
                btnListar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o cliente!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e) // botão listar clientes
        {
            dgvClientes.Rows.Clear();
            var lista = Cliente.ListarTodos();
            foreach (var item in lista)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[2].Value = item.Cpf;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[3].Value = item.Email;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[4].Value = item.Telefone;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[5].Value = item.Ativo;
            }
        }

        private void dgvEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEnderecos.Rows.Clear(); // Limpar os campos do dataGread
            int idCli = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            var listaEnd = Endereco.ListaEnderecos(idCli);
            if (listaEnd.Count>0) // Clientes_id for maior que 0 mostrar o foreach
            {
                foreach (var item in listaEnd)
                {
                    dgvEnderecos.Rows.Add();
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[0].Value = item.Tipo; // mostrar tipo de endereço
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[1].Value = item.Cep; // mostrar cep do endereço
                    StringBuilder endereco = new StringBuilder();
                    endereco.Append(item.Logradouro); // mostrar logradouro e
                    endereco.Append(" _ Nº: " + item.Numero); // numero com ", " antes e
                    endereco.Append(" _ bairro: " + item.Bairro); // bairro com " - " antes
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells [2].Value = endereco;
                }
            }
            else
            {
                dgvEnderecos.Rows.Add();
                string mensagem = "Não há endereço cadastrado neste cliente!"; // mensagem mostrada quando não houver endereço
                dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[2].Value = mensagem; // Mostrar mensagem acima
            }
        }

        private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            int linha = 0;
            if (e.KeyCode==Keys.Down && dgvClientes.CurrentRow.Index + 1 < dgvClientes.Rows.Count - 1)
            {
                linha = dgvClientes.CurrentRow.Index + 1;
            }
            if (e.KeyCode == Keys.Up && dgvClientes.CurrentRow.Index > 0)
            {
                linha = dgvClientes.CurrentRow.Index - 1;
            }

            dgvEnderecos.Rows.Clear(); // Limpar os campos do dataGread
            int idCli = Convert.ToInt32(dgvClientes.Rows[linha].Cells[0].Value);
            var listaEnd = Endereco.ListaEnderecos(idCli);
            
            if (listaEnd.Count > 0) // Clientes_id for maior que 0 mostrar o foreach
            {
                foreach (var item in listaEnd)
                {
                    dgvEnderecos.Rows.Add();
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[0].Value = item.Tipo; // mostrar tipo de endereço
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[1].Value = item.Cep; // mostrar cep do endereço
                    StringBuilder endereco = new StringBuilder();
                    endereco.Append(item.Logradouro); // mostrar logradouro e
                    endereco.Append(" _ Nº: " + item.Numero); // numero com ", " antes e
                    endereco.Append(" _ bairro: " + item.Bairro); // bairro com " - " antes
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[2].Value = endereco;
                }
            }
            else
            {
                dgvEnderecos.Rows.Add();
                string mensagem = "Não há endereço cadastrado neste cliente!"; // mensagem mostrada quando não houver endereço
                dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[2].Value = mensagem; // Mostrar mensagem acima
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
