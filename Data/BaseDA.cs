using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace PhumlaKamnandiProject.Data
{
    public abstract class BaseDA
    {
        #region Data Members
        protected string connectionString;
        protected SqlConnection connection;
        #endregion

        #region Constructor
        public BaseDA()
        {
            connectionString = @"Server=tcp:group27db-server.database.windows.net,1433;Initial Catalog=Group27_SemesterProjectDB;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection = new SqlConnection(connectionString);
        }

        public BaseDA(string connString)
        {
            connectionString = connString;
            connection = new SqlConnection(connectionString);
        }
        #endregion

        #region Helper Methods

        // Creates a SQL parameter with value
        protected SqlParameter CreateParameter(string parameterName, object value)
        {
            return new SqlParameter(parameterName, value ?? DBNull.Value);
        }

        // Executes a query with parameters and returns result from action
        protected T ExecuteQuery<T>(string query, Func<SqlCommand, T> action, params SqlParameter[] parameters)
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return action(command);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // Executes a non-query command (INSERT, UPDATE, DELETE)
        protected int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            return ExecuteQuery(query, cmd => cmd.ExecuteNonQuery(), parameters);
        }

        // Executes a scalar query (returns single value)
        protected object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            return ExecuteQuery(query, cmd => cmd.ExecuteScalar(), parameters);
        }
        #endregion
    }
}
