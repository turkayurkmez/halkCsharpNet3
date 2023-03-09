using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class DbHelper
    {
        private SqlConnection sqlConnection = null;
        public DbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Execute(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = createCommand(commandText, parameters);
            var affectedRows = 0;
            using (command.Connection)
            {
                command.Connection.Open();
                affectedRows = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return affectedRows;




        }
        //On job at a time.
        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = commandText;
            addParametersToCommand(command, parameters);
            return command;

        }

        private void addParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }
}
