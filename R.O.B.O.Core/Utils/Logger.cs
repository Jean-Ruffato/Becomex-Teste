using System;
using System.IO;
using System.Text;

namespace R.O.B.O.Core.Utils
{
    public class Logger
    {
        readonly Conexao conexaoDb = new Conexao();
        public void Inserir(Exception erro)
        {
            StringBuilder StrSQL = new StringBuilder();

            try
            {
                StrSQL.Append(" INSERT INTO Log (Data, Mensagem) VALUES (GetDate(), @Message);");

                conexaoDb.Query.Parameters.AddWithValue("@Message", erro.Message);

                conexaoDb.Query.Connection = conexaoDb.AbrirConexao();
                conexaoDb.Query.CommandText = StrSQL.ToString();

                int drdArtigo = conexaoDb.Query.ExecuteNonQuery();

                conexaoDb.FecharConexao();

            }
            catch (Exception erroInterno)
            {
                
            }
        }
    }
}
