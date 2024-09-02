using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        public Categoria? CategoriaId { get; set; }
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
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }

        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoriaId, double estoqueMinimo, double classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }

        public Produto(string? codBarras, string? descricao, double valorUnit, string? unidadeVenda, Categoria? categoriaId, double estoqueMinimo, double classeDesconto, byte[]? imagem)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            CategoriaId = categoriaId;
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
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }



    }
}
