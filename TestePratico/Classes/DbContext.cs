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

        public bool Insert(double distanciatotal, double distanciapilares, double basereforcada, int resultadopilares, int resultadopilaresreforcados)
        {
            try
            { //calculosrealizados
                string sql = "INSERT INTO calculosrealizados (data, distanciatotal, distanciapilares, basereforcada, resultadopilares, resultadopilaresreforcados) " +
                                "VALUES  (@data, @distanciatotal, @distanciapilares, @basereforcada, @resultadopilares, @resultadopilaresreforcados)";

                var cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@distanciatotal", distanciatotal.ToString());
                cmd.Parameters.AddWithValue("@distanciapilares", distanciapilares.ToString());
                cmd.Parameters.AddWithValue("@basereforcada", basereforcada.ToString());
                cmd.Parameters.AddWithValue("@resultadopilares", resultadopilares.ToString());
                cmd.Parameters.AddWithValue("@resultadopilaresreforcados", resultadopilaresreforcados.ToString());

                Connection.Open();
                int result = cmd.ExecuteNonQuery();
                if(result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
    }
}
