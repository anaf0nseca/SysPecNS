using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;

namespace SysPecNSLib
{
    public class Categoria
    {


        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria()
        {
 
        }
        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

   

        public Categoria(int id, string? nome, string? sigla=null)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM categorias where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new(
                dr.GetInt32(0),
                dr.GetString(1),
                null
                );
            }
            cmd.Connection.Close();

            return categoria;
        }

        public static List<Categoria> ObterLista()
        {
            List<Categoria> lista = new List<Categoria>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                dr.GetInt32(0),
                dr.GetString(1),
                null
                ));
            }
            cmd.Connection.Close();

            return lista;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from categorias where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }
    }
}
