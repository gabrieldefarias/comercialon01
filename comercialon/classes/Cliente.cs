using System;
using System.Collections.Generic;

namespace comercialon.classes
{
    public class Cliente // classe publica // projeto de aula - ti89 // declaração de propriedades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email{ get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Endereco { get; set; } // lista de endereços
        public bool Ativo { get; set; }
        //======================================================================================== // gerando os construtores

        public Cliente()
        {
            Id = 0;
        }

        public Cliente(int id, string nome, string cpf, string email, string telefone, bool ativo = true, List<Endereco> endereco = null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, string telefone, bool ativo = true, List<Endereco> endereco = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }
        //======================================================================================== // métodos da classe

        public void Inserir() // INSERIR - INICIO
        {
            var cmd = Banco.Abrir(); // inserir usando concatenações
            if (cmd.Connection.State==System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert " +
                    "clientes (nome, cpf, email, telefone, ativo)" +
                    "values ('"+Nome+"', '"+Cpf+"', '"+Email+"', '"+Telefone+"', default);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        //========================================================================== INSERIR - FIM
        public bool Alterar(int id) //  ALTERAR - INICIO
        {
            return true;
        }
        //========================================================================== ALTERAR - FIM
        public List<Cliente> ListarTodos() // LISTAR CLIENTE - INICIO
        {
            List<Cliente> lista = new List<Cliente>(); // codigo de listar cliente
            return lista; // retornar a lista de cliente
        }
        //========================================================================== LISTAR CLIENTE - FIM
        public void BuscarId(int id) // BUSCAR ID - INICIO
        {
            
        }
        //========================================================================== BUSCAR ID - FIM
    }
}
