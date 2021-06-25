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
        public List<Endereco> Enderecos { get; set; } // lista de endereços
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
            Enderecos = endereco;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, string telefone, bool ativo = true, List<Endereco> endereco = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Enderecos = endereco;
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
                    "clientes (nome, cpf, email, telefone, ativo) " +
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
            List<Cliente> lista = new List<Cliente>();
            string query = "select * from clientes";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetBoolean(5),
                    Endereco.ListaEnderecos(dr.GetInt32(0))
                ));
            }
            return lista;
        }
        //========================================================================== LISTAR CLIENTE - FIM
        public void BuscarPorId(int id) // BUSCAR ID - INICIO
        {
            string query = "select * from clientes where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                Telefone = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
                Enderecos = Endereco.ListaEnderecos(id);
            }
        }
        //========================================================================== BUSCAR ID - FIM
    }
}
