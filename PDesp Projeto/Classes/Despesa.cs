using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesp_Projeto
{
    class Despesa
    {
        int iddespesa, idtipodespesa, idmembro;
        DateTime datadespesa = new DateTime();
        double valordespesa;
        string obsdespesa;

        public int Iddespesa { get => iddespesa; set => iddespesa = value; }
        public int Idtipodespesa { get => idtipodespesa; set => idtipodespesa = value; }
        public int Idmembro { get => idmembro; set => idmembro = value; }
        public DateTime Datadespesa { get => datadespesa; set => datadespesa = value; }
        public double Valordespesa { get => valordespesa; set => valordespesa = value; }
        public string Obsdespesa { get => obsdespesa; set => obsdespesa = value; }

        public DataTable Listar()
        {
            SqlDataAdapter daDespesa;
            DataTable dtDespesa = new DataTable();

            try
            {
                daDespesa = new SqlDataAdapter("SELECT * FROM DESPESA", btnMax.conexao);
                daDespesa.Fill(dtDespesa);
                daDespesa.FillSchema(dtDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtDespesa;
        }
        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO DESPESA VALUES (@TIPODESPESA_ID_TIPODESPESA ,@MEMBRO_ID_MEMBRO," +
                    "@DATA_DESPESA , " + "@VALOR_DESPESA ," + "@OBS_DESPESA)", btnMax.conexao);

                mycommand.Parameters.Add(new SqlParameter("@TIPODESPESA_ID_TIPODESPESA", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@MEMBRO_ID_MEMBRO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@DATA_DESPESA", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@VALOR_DESPESA", SqlDbType.VarChar, 18));
                mycommand.Parameters.Add(new SqlParameter("@OBS_DESPESA", SqlDbType.VarChar));

                mycommand.Parameters["@TIPODESPESA_ID_TIPODESPESA"].Value = idtipodespesa;
                mycommand.Parameters["@MEMBRO_ID_MEMBRO"].Value = idmembro;
                mycommand.Parameters["@DATA_DESPESA"].Value = datadespesa;
                mycommand.Parameters["@VALOR_DESPESA"].Value = valordespesa;
                mycommand.Parameters["@OBS_DESPESA"].Value = valordespesa;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE DESPESA SET TIPODESPESA_ID_TIPODESPESA = @TIPODESPESA_ID_TIPODESPESA," +
                    "MEMBRO_ID_MEMBRO = @MEMBRO_ID_MEMBRO," +
                    "DATA_DESPESA = @DATA_DESPESA, VALOR_DESPESA = @VALOR_DESPESA WHERE ID_DESPESA = @ID_DESPESA",
                    btnMax.conexao);

                mycommand.Parameters.Add(new SqlParameter("@ID_DESPESA",SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@TIPODESPESA_ID_TIPODESPESA", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@MEMBRO_ID_MEMBRO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@DATA_DESPESA", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@VALOR_DESPESA", SqlDbType.VarChar, 10));
                mycommand.Parameters.Add(new SqlParameter("@OBS_DESPESA", SqlDbType.VarChar));

                mycommand.Parameters["@ID_DESPESA"].Value = iddespesa;
                mycommand.Parameters["@TIPODESPESA_ID_TIPODESPESA"].Value = idtipodespesa;
                mycommand.Parameters["@MEMBRO_ID_MEMBRO"].Value = idmembro;
                mycommand.Parameters["@DATA_DESPESA"].Value = datadespesa;
                mycommand.Parameters["@VALOR_DESPESA"].Value = valordespesa;
                mycommand.Parameters["@OBS_DESPESA"].Value = obsdespesa;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM DESPESA WHERE id_despesa=@id_despesa", btnMax.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                mycommand.Parameters["@id_despesa"].Value = iddespesa;

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
    }
}
