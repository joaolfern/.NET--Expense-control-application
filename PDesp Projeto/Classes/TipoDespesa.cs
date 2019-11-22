using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PDesp_Projeto
{
    class TipoDespesa
    {
        private int idtipodespesa;
        private string nometipodespesa;

        public int Idtipodespesa
        {
            get
            {
                return idtipodespesa;
            }
            set
            {
                idtipodespesa = value;
            }
        }

        public string Nometipodespesa
        {
            get
            {
                return nometipodespesa;
            }
            set
            {
                nometipodespesa = value; 
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daTipoDespesa;
            DataTable dtTipoDespesa = new DataTable();

            try
            {
                daTipoDespesa = new SqlDataAdapter("SELECT * FROM TIPODESPESA", btnMax.conexao);
                daTipoDespesa.Fill(dtTipoDespesa);
                daTipoDespesa.FillSchema(dtTipoDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtTipoDespesa;
        }
        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TIPODESPESA VALUES (@nome_tipodespesa)", btnMax.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));
                mycommand.Parameters["@nome_tipodespesa"].Value = nometipodespesa;
     
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
                mycommand = new SqlCommand("UPDATE TIPODESPESA SET nome_tipodespesa" + "= @nome_tipodespesa " + 
                    "WHERE id_tipodespesa = @id_tipodespesa",
                    btnMax.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));

                mycommand.Parameters["@id_tipodespesa"].Value = idtipodespesa;
                mycommand.Parameters["@nome_tipodespesa"].Value = nometipodespesa;

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

                mycommand = new SqlCommand("DELETE FROM TIPODESPESA WHERE " + "id_tipodespesa=@id_tipodespesa", btnMax.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));
                mycommand.Parameters["@id_tipodespesa"].Value = idtipodespesa;
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
