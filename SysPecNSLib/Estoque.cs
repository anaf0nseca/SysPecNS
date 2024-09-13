using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {

        public Produto Produto { get; set; }
        public double? Quantidade { get; set; }
        public DateTime? Data_Ultimo_Movimento { get; set; }


        public Estoque(Produto produto, double? quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public Estoque(Produto produto, double? quantidade, DateTime? data_Ultimo_Movimento)
        {
            Produto = produto;
            Quantidade = quantidade;
            Data_Ultimo_Movimento = data_Ultimo_Movimento;
        }

        //public void Inserir();

        public void Atualizar(int idProduto, double Quantidade)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update estoques set quantidade = {Quantidade} where id = {idProduto}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


    }
}
