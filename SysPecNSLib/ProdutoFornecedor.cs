using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    class ProdutoFornecedor
    {

        public Produto? Produto {  get; set; }
        public Fornecedor? Fornecedor { get; set; }

        public ProdutoFornecedor() { }
        public ProdutoFornecedor(Produto produto, Fornecedor fornecedor)
        {
            Produto = produto;
            Fornecedor = fornecedor;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produtofornecedor_insert";

            cmd.Parameters.AddWithValue("spid_produto", Produto);
            cmd.Parameters.AddWithValue("spid_fornecedor", Fornecedor);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection.Close();

        }

        public void Excluir()
        {
            // em geral nada se exclui de uma tabela...
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from usuarios where id =";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }
    }
}
