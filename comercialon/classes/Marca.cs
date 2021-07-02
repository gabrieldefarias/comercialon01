using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Marca
    { // declaração de propriedades
        public int Id { get; set; }
        public String Nome { get; set; }
        public string Sigla { get; set; }

        //======================================================================================== // gerando os construtores
        public Marca()
        { }
        
        public Marca(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Marca(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        //======================================================================================== // métodos da classe
        public void Inserir() // INSERIR - INICIO
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert " +
                    "marcas(nome, sigla) " +
                    "values('"+Nome+"', '"+Sigla+"');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        //========================================================================================FIM
        public static List<Marca> ListarTodos() // LISTAR TODOS - INICIO
        {
            List<Marca> lista = new List<Marca>();
            string query = "select * from marcas";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Marca(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                ));
            }
            return lista;
        }
        //========================================================================================FIM
        public void BuscarPorId(int id) // BUSCAR POR ID
        {
            string query = "select * from marcas where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Sigla = dr.GetString(2);
            }
        }
        //========================================================================================FIM
        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update marcas set nome = '"+Nome+"', sigla = '"+Sigla+"' where id = " + Id;
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
    }
}
