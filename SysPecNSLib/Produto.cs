using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Produto
    {

        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit {  get; set; }
        //unidade, pacote, caixa, litro, kg
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[]? Imagem { get; set; }
        public DateTime DataCad {  get; set; }

        public Produto() 
        { 
        
        }

        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoriaId, double estoqueMinimo, double classeDesconto, byte[]? imagem, DateTime dataCad)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }

        //insert
        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoriaId, double estoqueMinimo, double classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }

        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoriaId, double estoqueMinimo, double classeDesconto, byte[]? imagem)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
        }

        public Produto(int id, string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoriaId, double estoqueMinimo, double classeDesconto, byte[]? imagem, DateTime dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto",ClasseDesconto);
            //select last_insert_id();
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);

            cmd.ExecuteNonQuery();

        }

        public static Produto ObterPorId(int id)
        {
            //método construtor vazio, 
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetDouble(3),
                dr.GetString(4),
                Categoria.ObterPorId(dr.GetInt32(5)),
                dr.GetDouble(6),
                dr.GetDouble(7),
                //objeto que veio do banco e convertido em uma matriz de bytes
                (byte[])dr.GetValue(8),
                dr.GetDateTime(9)
                
                );
            }


            return produto;


        }

        public static List<Produto> ObterLista()
        {
            //método construtor vazio, 
            List<Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetDouble(3),
                dr.GetString(4),
                Categoria.ObterPorId(dr.GetInt32(5)),
                dr.GetDouble(6),
                dr.GetDouble(7),
                //objeto que veio do banco e convertido em uma matriz de bytes
                null,
                //(byte[])dr.GetValue(8),
                dr.GetDateTime(9)

                ));
            }

                return produtos;
        }

        

        //produtos não são excluidos
    }
}
