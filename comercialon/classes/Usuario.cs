using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Usuario // classe publica // declarando as propriedades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public string Cpf { get; set; }
        public bool Ativo { get; set; }
        //======================================================================================== // gerando os construtores

        public Usuario()
        { }

        public Usuario(string nome, string email, string senha, string nivel, string cpf, bool ativo = true)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Cpf = cpf;
            Ativo = ativo;
        }

        public Usuario(int id, string nome, string email, string senha, string nivel, string cpf, bool ativo = true)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Cpf = cpf;
            Ativo = ativo;
        }

        //======================================================================================== // metodos de classe
        public void Inserir()
        { 
            var cmd = Banco.Abrir();
            if (cmd.Connection.State==System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert " +
                    "usuarios(nome, email, senha, nivel, ativo, cpf) " +
                    "values ('"+Nome+"','"+Email+"','"+Senha+"','"+Nivel+"',default,'"+Cpf+"');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        //========================================================================== INSERIR - FIM
        public static List<Usuario> ListarTodos() // LISTAR USUARIO - INICIO
        {
            List<Usuario> lista = new List<Usuario>();
            string query = "select * from usuarios";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(6),
                    dr.GetBoolean(5)
                ));
            }
            return lista;
        }
        //========================================================================== LISTAR USUARIO - FIM
        public bool Alterar()
        {
            string ativo = Ativo ? "1" : "0";
            var cmd = Banco.Abrir();
            cmd.CommandText = "update usuarios set " +
                "nome = '"+Nome+"', " +
                "email = '"+Email+"', " +
                "senha = '"+Senha+"', " +
                "nivel = '"+Nivel+"', " +
                "ativo = "+ativo+", " +
                "cpf = '"+Cpf+"' " +
                "where id = " + Id;
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //========================================================================== ALTERAR - FIM
        public void BuscarPorId(int id)
        {
            string query = "select * from usuarios where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Senha = dr.GetString(3);
                Nivel = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
                Cpf = dr.GetString(6);
            }
        }
        //========================================================================== BUSCAR ID - FIM
    }
}
