using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Endereco // classe pública // declarando as propriedades
    {
        private readonly int idCliente;
        public int IdCliente { get { return idCliente; } }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string SiglaEstado { get; set; }
        public string Tipo { get; set; }
        //======================================================================================== // gerando os construtores

        public Endereco()
        { }
        
        public Endereco(
            string logradouro,
            string numero,
            string complemento,
            string cep,
            string bairro,
            string cidade,
            string tipo,
            string estado = null,
            string siglaEstado = null
        )
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Tipo = tipo;
            Estado = estado; // não obrigatório por causa do "null" de "string estado = null"
            SiglaEstado = siglaEstado; // não obrigatório por causa do "null" de "string siglaEstado = null"
        }
        
        public Endereco(
            int idCliente,
            string logradouro,
            string numero,
            string complemento,
            string cep,
            string bairro,
            string cidade,
            string estado,
            string siglaEstado,
            string tipo)
        {
            this.idCliente = idCliente;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            SiglaEstado = siglaEstado;
            Tipo = tipo;
        }


        //======================================================================================== // métodos da classe
        public void Inserir(int idCliente)
        {
            string query = 
                "insert enderecos " +
                "values(" +
                    idCliente+", " +
                    "'"+Cep+"', " +
                    "'"+Logradouro+"', " +
                    "'"+Numero+"', " +
                    "'"+Complemento+"', " +
                    "'"+Bairro+"', " +
                    "'"+Cidade+"', " +
                    "'"+Estado+"', " +
                    "'"+SiglaEstado+"', " +
                    "'"+Tipo+"'" +
                ")";
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">ID do cliente na tabela endereço, use se quiser listar todos com limite de resultado</param>
        /// <param name="inicial">Valor inicial da base de consulta, zero é o valor padrão</param>
        /// <param name="limit">Número de registros por consulta</param>
        /// <returns></returns>
        public static List<Endereco> ListaEnderecos(int id = 0, int inicial=0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>(); // código buscar os endereços
            string query = "";

            if (id > 0)
            {
                query = "select * from enderecos where clientes_id = " + id;
            }
            else if (limit >= 0 && inicial >= 0)
            {
                query = "select * from enderecos limit " + limit + "," + limit;
            }

            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(1),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                ));
            }
            return lista;
        }
    }
}
