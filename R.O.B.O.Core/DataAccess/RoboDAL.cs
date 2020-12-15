using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using R.O.B.O.Core.Utils;
using R.O.B.O.Core.Models;
using System.Data;

namespace R.O.B.O.Core.DataAccess
{
    public class RoboDAL
    {
        readonly Conexao conexaoDb = new Conexao();
        private Logger log = new Logger();

        public static RoboTO LoadDataBaseObject(IDataReader drdRobo)
        {
            RoboTO objRobo = new RoboTO();

            if (!drdRobo.IsDBNull(drdRobo.GetOrdinal("IdAcesso"))) objRobo.IdAcesso = drdRobo.GetInt32(drdRobo.GetOrdinal("IdAcesso")); else objRobo.IdAcesso = 0;
            if (!drdRobo.IsDBNull(drdRobo.GetOrdinal("CotoveloEsquerdo"))) objRobo.CotoveloEsquerdo = drdRobo.GetInt32(drdRobo.GetOrdinal("CotoveloEsquerdo")); else objRobo.CotoveloEsquerdo = 0;
            if (!drdRobo.IsDBNull(drdRobo.GetOrdinal("CotoveloDireito"))) objRobo.CotoveloDireito = drdRobo.GetInt32(drdRobo.GetOrdinal("CotoveloDireito")); else objRobo.CotoveloDireito = 0;
            if (!drdRobo.IsDBNull(drdRobo.GetOrdinal("PulsoEsquerdo"))) objRobo.PulsoEsquerdo = drdRobo.GetInt32(drdRobo.GetOrdinal("PulsoEsquerdo")); else objRobo.PulsoEsquerdo = 0;
            if (!drdRobo.IsDBNull(drdRobo.GetOrdinal("PulsoDireito"))) objRobo.PulsoDireito = drdRobo.GetInt32(drdRobo.GetOrdinal("PulsoDireito")); else objRobo.PulsoDireito = 0;
            if (!drdRobo.IsDBNull(drdRobo.GetOrdinal("RotacaoCabeca"))) objRobo.RotacaoCabeca = drdRobo.GetInt32(drdRobo.GetOrdinal("RotacaoCabeca")); else objRobo.RotacaoCabeca = 0;
            if (!drdRobo.IsDBNull(drdRobo.GetOrdinal("InclinacaoCabeca"))) objRobo.InclinacaoCabeca = drdRobo.GetInt32(drdRobo.GetOrdinal("InclinacaoCabeca")); else objRobo.InclinacaoCabeca =  0;
            
            return objRobo;

        }

        private static List<RoboTO> LoadObjects(IDataReader drdRobo)
        {
            List<RoboTO> lstRobo = new List<RoboTO>();

            while (drdRobo.Read())
            {
                lstRobo.Add(LoadDataBaseObject(drdRobo));
            }

            return lstRobo;
        }

        public bool Inserir(RoboTO objRoboTO)
        {
            bool statusConsulta = false;
            StringBuilder strSQL = new StringBuilder();

            try
            {
                strSQL.Append(" INSERT INTO Robo ");
                strSQL.Append(" (IdAcesso, CotoveloEsquerdo, CotoveloDireito, PulsoEsquerdo, PulsoDireito, RotacaoCabeca, InclinacaoCabeca) ");
                strSQL.Append(" VALUES ");
                strSQL.Append(" (@IdAcesso, @CotoveloEsquerdo, @CotoveloDireito, @PulsoEsquerdo, @PulsoDireito, @RotacaoCabeca, @InclinacaoCabeca); ");

                int idAcesso = this.GetHashCode();

                conexaoDb.Query.Parameters.AddWithValue("@IdAcesso", idAcesso);
                conexaoDb.Query.Parameters.AddWithValue("@CotoveloEsquerdo", objRoboTO.CotoveloEsquerdo);
                conexaoDb.Query.Parameters.AddWithValue("@CotoveloDireito", objRoboTO.CotoveloDireito);
                conexaoDb.Query.Parameters.AddWithValue("@PulsoEsquerdo", objRoboTO.PulsoEsquerdo);
                conexaoDb.Query.Parameters.AddWithValue("@PulsoDireito", objRoboTO.PulsoDireito);
                conexaoDb.Query.Parameters.AddWithValue("@RotacaoCabeca", objRoboTO.RotacaoCabeca);
                conexaoDb.Query.Parameters.AddWithValue("@InclinacaoCabeca", objRoboTO.InclinacaoCabeca);

                conexaoDb.Query.Connection = conexaoDb.AbrirConexao();

                conexaoDb.Query.CommandText = strSQL.ToString();

                int drdRobo = conexaoDb.Query.ExecuteNonQuery();

                conexaoDb.FecharConexao();

                statusConsulta = true;
            }
            catch (Exception erro)
            {
                log.Inserir(erro);
            }

            return statusConsulta;
        }

        
        public bool Atualizar(RoboTO objRoboTO)
        {
            StringBuilder strSQL = new StringBuilder();
            bool statusConsulta = false;

            try
            {
                strSQL.Append(" UPDATE Robo ");
                strSQL.Append(" SET CotoveloEsquerdo = @CotoveloEsquerdo, CotoveloDireito = @CotoveloDireito, PulsoEsquerdo = @PulsoEsquerdo, PulsoDireito = @PulsoDireito, RotacaoCabeca = @RotacaoCabeca, InclinacaoCabeca = @InclinacaoCabeca");          

                conexaoDb.Query.Parameters.AddWithValue("@CotoveloEsquerdo", objRoboTO.CotoveloEsquerdo);
                conexaoDb.Query.Parameters.AddWithValue("@CotoveloDireito", objRoboTO.CotoveloDireito);
                conexaoDb.Query.Parameters.AddWithValue("@PulsoEsquerdo", objRoboTO.PulsoEsquerdo);
                conexaoDb.Query.Parameters.AddWithValue("@PulsoDireito", objRoboTO.PulsoDireito);
                conexaoDb.Query.Parameters.AddWithValue("@RotacaoCabeca", objRoboTO.RotacaoCabeca);
                conexaoDb.Query.Parameters.AddWithValue("@InclinacaoCabeca", objRoboTO.InclinacaoCabeca);

                conexaoDb.Query.Connection = conexaoDb.AbrirConexao();

                conexaoDb.Query.CommandText = strSQL.ToString();

                int drdRobo = conexaoDb.Query.ExecuteNonQuery();

                conexaoDb.FecharConexao();

                statusConsulta = true;
            }
            catch (Exception erro)
            {
                log.Inserir(erro);
            }

            return statusConsulta;
        }

        public bool Deletar()
        {
            StringBuilder strSQL = new StringBuilder();
            bool statusConsulta = false;

            try
            {
                strSQL.Append(" DELETE FROM Robo;");

                conexaoDb.Query.CommandText = strSQL.ToString();

                conexaoDb.Query.Connection = conexaoDb.AbrirConexao();

                int drdRobo = conexaoDb.Query.ExecuteNonQuery();

                conexaoDb.FecharConexao();

                statusConsulta = true;

            }
            catch (Exception erro)
            {
                log.Inserir(erro);
            }

            return statusConsulta;
        }

        public List<RoboTO> Buscar()
        {
            StringBuilder strSQL = new StringBuilder();
            RoboTO objRoboTO = new RoboTO();
            List<RoboTO> lstRoboTO = new List<RoboTO>();
            try
            {
                int testObj = this.GetHashCode();
                strSQL.Append(" SELECT * FROM Robo");

                conexaoDb.Query.CommandText = strSQL.ToString();

                conexaoDb.Query.Connection = conexaoDb.AbrirConexao();

                int drdRobo = conexaoDb.Query.ExecuteNonQuery();

                using (IDataReader drdRoboTO = conexaoDb.Query.ExecuteReader())
                {
                    while (drdRoboTO.Read())
                    {

                        RoboTO objDrdRoboTO = new RoboTO();

                       
                        if (!drdRoboTO.IsDBNull(drdRoboTO.GetOrdinal("CotoveloEsquerdo")))
                            objDrdRoboTO.CotoveloEsquerdo = drdRoboTO.GetInt32(drdRoboTO.GetOrdinal("CotoveloEsquerdo"));
                        else
                            objDrdRoboTO.CotoveloEsquerdo = 0;

                        if (!drdRoboTO.IsDBNull(drdRoboTO.GetOrdinal("CotoveloDireito")))
                            objDrdRoboTO.CotoveloDireito = drdRoboTO.GetInt32(drdRoboTO.GetOrdinal("CotoveloDireito"));
                        else
                            objDrdRoboTO.CotoveloDireito = 0;
                        
                        if (!drdRoboTO.IsDBNull(drdRoboTO.GetOrdinal("PulsoEsquerdo")))
                            objDrdRoboTO.PulsoEsquerdo = drdRoboTO.GetInt32(drdRoboTO.GetOrdinal("PulsoEsquerdo"));
                        else
                            objDrdRoboTO.PulsoEsquerdo = 0;

                        if (!drdRoboTO.IsDBNull(drdRoboTO.GetOrdinal("PulsoDireito")))
                            objDrdRoboTO.PulsoDireito = drdRoboTO.GetInt32(drdRoboTO.GetOrdinal("PulsoDireito"));
                        else
                            objDrdRoboTO.PulsoDireito = 0;

                        if (!drdRoboTO.IsDBNull(drdRoboTO.GetOrdinal("RotacaoCabeca")))
                            objDrdRoboTO.RotacaoCabeca = drdRoboTO.GetInt32(drdRoboTO.GetOrdinal("RotacaoCabeca"));
                        else
                            objDrdRoboTO.RotacaoCabeca = 0;

                        if (!drdRoboTO.IsDBNull(drdRoboTO.GetOrdinal("InclinacaoCabeca")))
                            objDrdRoboTO.InclinacaoCabeca = drdRoboTO.GetInt32(drdRoboTO.GetOrdinal("InclinacaoCabeca"));
                        else
                            objDrdRoboTO.InclinacaoCabeca = 0;

                        lstRoboTO.Add(objDrdRoboTO);
                    }

                    drdRoboTO.Close();
                    conexaoDb.FecharConexao();
                }
            }
            catch (Exception erro)
            {
                log.Inserir(erro);
            }

            return lstRoboTO;
        }
        
    }
}
