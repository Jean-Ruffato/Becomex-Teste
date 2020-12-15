using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace R.O.B.O.Core.Utils
{
    public class Conexao
    {
        private static Conexao _instance = null;

        // Construtor padrão
        public Conexao()
        {
        }

        public static Conexao GetInstance()
        {
            if (_instance == null)
                _instance = new Conexao();
            return _instance;
        }

        private readonly SqlConnection conexao = new SqlConnection();
        public SqlCommand Query = new SqlCommand();

        public SqlConnection AbrirConexao()
        {
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed) // Se a conexão estiver fechada tenta abrir uma nova
                {
                    conexao.Open();
                }
            }
            catch (Exception erro)
            {
                Logger Log = new Logger();
                Log.Inserir(erro);
            }

            return conexao;
        }

        public void FecharConexao()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open) // Se a conexão estiver aberta tenta fechar a conexão
                {
                    conexao.Close();
                }
            }
            catch (Exception erro)
            {
                Logger Log = new Logger();
                Log.Inserir(erro);
            }
        }
    }
}
