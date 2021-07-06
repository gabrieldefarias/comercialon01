using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Produto // classe publica // declarando as propriedades
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public String UnidadeVenda { get; set; }
        public string Codbar { get; set; }
        public double Desconto { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public bool Descontinuado { get; set; }
        //======================================================================================== // gerando os construtores
        public Produto()
        { }

        public Produto(
            int id, string descricao, double valorUnitario, string unidadeVenda, string codbar, double desconto, string marca, string categoria, bool descontinuado = true
        )
        {
            Id = id;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            Codbar = codbar;
            Desconto = desconto;
            Marca = marca;
            Categoria = categoria;
            Descontinuado = descontinuado;
        }

        public Produto(
            string descricao, double valorUnitario, string unidadeVenda, string codbar, double desconto, string marca, string categoria, bool descontinuado = true
        )
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            Codbar = codbar;
            Desconto = desconto;
            Marca = marca;
            Categoria = categoria;
            Descontinuado = descontinuado;
        }

        //======================================================================================== // metodos de classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert " +
                    "produtos(descricao, valor_unitario, unidade_venda, codbar, desconto, descontinuado, marcas_id, categorias_id) " +
                    "values ('"+Descricao+"',"+ValorUnitario+",'"+UnidadeVenda+"','"+Codbar+"',"+Desconto+",'default','"+Marca+"','"+Categoria+"');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        //======================================================================================== Inserir FIM
        public static List<Produto> ListarTodos()
        {
            List<Produto> lista = new List<Produto>();
            string query = "select * from produtos";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetBoolean(6)
                ));
            }
            return lista;
        }
        //======================================================================================== ListarTodos FIM
        public void BuscarPorId(int id)
        {
            string query = "select * from produtos where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                ValorUnitario = dr.GetDouble(2);
                UnidadeVenda = dr.GetString(3);
                Codbar = dr.GetString(4);
                Desconto = dr.GetDouble(5);
                Descontinuado = dr.GetBoolean(6);
                Marca = dr.GetString(7);
                Categoria = dr.GetString(8);
            }
        }
        //======================================================================================== BuscarPorId FIM
        public bool Alterar(int id)
        {
            string descontinuado = Descontinuado ? "1" : "0";
            var cmd = Banco.Abrir();
            cmd.CommandText = "update produtos set " +
                "descriaco = '"+Descricao+"', " +
                "valor_unitario = '"+ValorUnitario+"', " +
                "unidade_venda = '"+UnidadeVenda+"', " +
                "codbar = '"+Codbar+"', " +
                "desconto = '"+Desconto+"', " +
                "descontinuado = "+descontinuado+", " +
                "marcas_id = '"+Marca+"', " +
                "categorias_id = '"+Categoria+"' where id = 3;";
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
        //======================================================================================== Alterar FIM
        public void BuscarPorCodbar(int id)
        { }
    }
}
