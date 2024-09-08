using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Pedido
    {

        //Propriedade em encapsulamento
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido> Itens { get; set; }




        public Pedido() 
        {
        
        }
        
        //sem o ID
        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }



        //sem ID, data e status
        public Pedido(Usuario usuario, Cliente cliente, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;
        }


        //Todas as propriedades
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Itens = itens;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);

            //id do pedido
            Id = Convert.ToInt32(cmd.ExecuteScalar());


        }

        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();   
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pedido = new(
                    //dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                    //ItemPedido.ObterListaPorId(6)

                    );
            }
            
            return pedido;
        }


        public static List<Pedido> ObterLista(int idCliente = 0, int idUsuario = 0)
        {
            //Exemplo: ObterLista(0,8); todos os pedidos vendidos pelo usuário 8
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            if (idCliente > 0 && idUsuario > 0)
            {
                cmd.CommandText = $"select * from pedidos where cliente id = {idCliente} and usuario_id = {idUsuario}";

            }else if (idCliente > 0) 
            {
                cmd.CommandText = $"select * from pedidos where cliente_id = {idCliente}";

            }else if (idUsuario > 0) 
            { 
                cmd.CommandText = $"select * from pedidos where usuario_id = {idUsuario}";

            }else
            {   
                cmd.CommandText = "select * from pedidos order by ";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                pedidos.Add(new(
                    //dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                    //ItemPedido.ObterListaPorId(6)

                    ));
            }
            return pedidos;
        }
    }
}
