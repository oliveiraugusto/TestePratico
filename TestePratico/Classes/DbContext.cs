using System;
using System.Data;
using System.Data.SqlClient;

namespace TestePratico.Classes
{
    public class DbContext
    {
        protected SqlConnection Connection { get; }

        public DbContext()
        {
            Connection = new SqlConnection(TestePratico.Keys.ConnectionString);
        }

        /// <summary>
        /// Busca o ultimo registro no banco para ser usado como sugestão aos usuarios
        /// </summary>
        /// <returns>Um DataSet com o registro encontrado</returns>
        public DataTable InitialContext()
        {
            try
            {                
                string sql = "SELECT TOP 1 * FROM calculosrealizados ORDER BY id DESC;";
                var dt = new DataTable();

                Connection.Open();
                var da = new SqlDataAdapter(sql, Connection);
                da.Fill(dt);
                return dt;               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Busca os 10 ultimos registro do banco
        /// </summary>
        /// <returns>Um DataSet com os 10 ultimos campos da tabela</returns>
        public DataSet Select10Ultimos()
        {
            try
            {
                string sql = "SELECT TOP 10 * FROM calculosrealizados ORDER BY id DESC;";
                var ds = new DataSet();

                Connection.Open();
                var da = new SqlDataAdapter(sql, Connection);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Busca os ultimos registro do banco
        /// </summary>
        /// <returns>Um DataSet com todos os campos da tabela</returns>
        public DataSet SelectAll()
        {
            try
            {
                string sql = "SELECT * FROM calculosrealizados ORDER BY id DESC;";
                var ds = new DataSet();

                Connection.Open();
                var da = new SqlDataAdapter(sql, Connection);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Insere os calculos usados para realizar o calculo
        /// </summary>
        /// <param name="distanciatotal"></param>
        /// <param name="distanciapilares"></param>
        /// <param name="basereforcada"></param>
        /// <returns>true caso os dados forem gravados no banco, false c.c.</returns>
        public bool Update(double distanciatotal, double distanciapilares, double basereforcada)
        {
            try
            {
                string sql = "";

                var cmd = new SqlCommand(sql, Connection);

                cmd.Parameters.Add("@distanciatotal", SqlDbType.Float);
                cmd.Parameters["@distanciatotal"].Value = distanciatotal;

                cmd.Parameters.Add("@distanciapilares", SqlDbType.Float);
                cmd.Parameters["@distanciapilares"].Value = distanciapilares;

                cmd.Parameters.Add("@basereforcada", SqlDbType.Float);
                cmd.Parameters["@basereforcada"].Value = basereforcada;

                Connection.Open();
                var result = cmd.ExecuteNonQuery();

                if (result == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
