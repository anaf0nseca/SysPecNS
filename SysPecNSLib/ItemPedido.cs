using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class ItemPedido
    {

        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit {  get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        public ItemPedido() { }
        public ItemPedido(int id, Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

    }
}
