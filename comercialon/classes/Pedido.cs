using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Data { get; set; }
        public String Situacao { get; set; }
        public double Desconto { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> itensPedido { get; set; }
        //======================================================================================== // gerando os construtores
        public Pedido()
        { }

        public Pedido(int data, string situacao, double desconto, Usuario usuario, Cliente cliente, List<ItemPedido> itensPedido = null)
        {
            Data = data;
            Situacao = situacao;
            Desconto = desconto;
            Usuario = usuario;
            Cliente = cliente;
            this.itensPedido = itensPedido; // nulo
        }

        public Pedido(int id, int data, string situacao, double desconto, Usuario usuario, Cliente cliente, List<ItemPedido> itensPedido = null)
        {
            Id = id;
            Data = data;
            Situacao = situacao;
            Desconto = desconto;
            Usuario = usuario;
            Cliente = cliente;
            this.itensPedido = itensPedido; // nulo
        }
        //======================================================================================== // metodos de classe

    }
}
