using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Endereco // classe pública // declarando as propriedades
    {
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

        public Endereco
        (
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

        public static List<Endereco> ListaEnderecos(int id = 0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>(); // código buscar os endereços
            return lista;
        }
    }
}
