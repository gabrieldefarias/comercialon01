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
        public bool Descontinuado { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        //======================================================================================== // gerando os construtores
        public Produto()
        { }

        public Produto(
            int id, string descricao, double valorUnitario, string unidadeVenda, string codbar, double desconto, bool descontinuado, Marca marca, Categoria categoria)
        {
            Id = id;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            Codbar = codbar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categoria = categoria;
        }

        public Produto(
            string descricao, double valorUnitario, string unidadeVenda, string codbar, double desconto, bool descontinuado, Marca marca, Categoria categoria)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            Codbar = codbar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categoria = categoria;
        }
        //======================================================================================== // metodos de classe
        public void Inserir()
        { }
        //======================================================================================== Inserir FIM
        public static List<Produto> ListarTodos()
        {
            List<Produto> lista = new List<Produto>();

            return lista;
        }
        //======================================================================================== ListarTodos FIM
        public void BuscarPorId(int id)
        { }
        //======================================================================================== BuscarPorId FIM
        public void BuscarPorCodbar(int id)
        { }
        //======================================================================================== BuscarPorCodbar FIM
        public bool Alterar(int id)
        {
            return true;
        }
    }
}
