using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class ItemPedido
    {
        private readonly int idPedido;
        public int IdPedido { get { return IdPedido; } }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorProduto { get; set; }
        public double desconto { get; set; }
        //======================================================================================== // gerando os construtores
        public ItemPedido()
        { }

        public ItemPedido(int idPedido, Produto produto, double quantidade, double valorProduto, double desconto)
        {
            this.idPedido = idPedido;
            Produto = produto;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
            this.desconto = desconto;
        }

        public ItemPedido(Produto produto, double quantidade, double valorProduto, double desconto)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
            this.desconto = desconto;
        }
        //======================================================================================== // metodos de classe
        public void Inserir() // metodo Inserir
        { }
        //======================================================================================== Inserir FIM
        public static List<ItemPedido> ObterItemPedido()
        {
            List<ItemPedido> lista = new List<ItemPedido>();

            return lista;
        }
        //======================================================================================== ObterItemPedido FIM
        public void BuscarPorId(int id)
        { }
        //======================================================================================== BuscarPorId FIM
        public bool Alterar(int id)
        {
            return true;
        }
    }
}
