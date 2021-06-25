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
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }
        //======================================================================================== // gerando os construtores

        public Produto()
        {}

        public Produto(int id, string descricao, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto(string descricao, double preco, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        //======================================================================================== // metodos de classe

        public void Inserir()
        { }

        public List<Produto> ListarTodos()
        {
            List<Produto> lista = new List<Produto>();
            return lista;
        }

        public bool Alterar(int id)
        {
            return true;
        }

        public void BuscarId(int id)
        { }
    }
}
