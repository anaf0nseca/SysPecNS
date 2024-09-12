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

        public Pedido(Usuario usuario, Cliente cliente)
        {
            Usuario = usuario;
            Cliente = cliente;
        }

        //sem ID, data e status
        public Pedido(Usuario usuario, Cliente cliente, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;
        }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
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
            cmd.Connection.Close();
        }

        public void AlterarStatus()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set status = {Status} where id = {Id}";
        
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void AtualizarDesconto()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set desconto = {Desconto} where id = {Id}";
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
            //Retorna um valor ou nenhum registro
            if (dr.Read())
            {
                //pedido.Id = dr.GetInt32(0);
                //pedido.Usuario = Usuario.ObterPorId(dr.GetInt32(1));

                pedido = new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                    //ItemPedido.ObterListaPorPedido(dr.GetInt32(6));

                    );
            }
            cmd.Connection.Close();
            return pedido;
        }


        /// <summary>
        /// Método para obter lista de todos os pedidos existentes no sistema
        /// </summary>
        /// <returns> Lista de todos os pedidos, se existir. </returns>
        public static List<Pedido> ObterLista()
        {
            //Exemplo: ObterLista(0,8); todos os pedidos vendidos pelo usuário 8
            //pedidos é um objeto do tipo LISTA de PEDIDOS
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            //if (idCliente > 0 && idUsuario > 0)
            //{
            //    cmd.CommandText = $"select * from pedidos where cliente_id = {idCliente} and usuario_id = {idUsuario}";

            //}else if (idCliente > 0) 
            //{
            //    cmd.CommandText = $"select * from pedidos where cliente_id = {idCliente}";

            //}else if (idUsuario > 0) 
            //{ 
            //    cmd.CommandText = $"select * from pedidos where usuario_id = {idUsuario}";

            //}else
            //{   
            cmd.CommandText = "select * from pedidos order by data";
            

            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    ItemPedido.ObterListaPorPedido(dr.GetInt32(6))

                    ));
            }

            cmd.Connection.Close();
            return pedidos;
        }



        /// <summary>
        /// Método para obter lista de pedidos de acordo com o cliente especificado
        /// </summary>
        /// <param name="idCliente"> ID do cliente </param>
        /// <returns>Lista de pedidos do cliente informado, caso haja pedidos registrados.</returns>
        public static List<Pedido> ObterListaPorCliente(int idCliente) 
        {
            List<Pedido> pedidosCliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where cliente_id = {idCliente}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidosCliente.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    ItemPedido.ObterListaPorPedido(dr.GetInt32(6))

                    ));
            }
            cmd.Connection.Close();
            return pedidosCliente;
        }


        /// <summary>
        /// Método para obter lista de pedidos de acordo com o usuário especificado (no caso, um vendedor)
        /// </summary>
        /// <param name="idUsuario"> ID do Usuário logado </param>
        /// <returns> Lista de pedidos do usuário informado, caso haja pedidos registrados no sistema. </returns>
        public static List<Pedido> ObterListaPorUsuario(int idUsuario) 
        {
            List<Pedido> pedidosUsuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedidos where usuario_id = {idUsuario}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidosUsuario.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    ItemPedido.ObterListaPorPedido(dr.GetInt32(6))

                    ));
            }
            cmd.Connection.Close();
            return pedidosUsuario;
        }

    }
}
