using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra_ELMS
{
    internal class SQLQueryManager
    {
        string strConnection = @"Data Source=LAPTOP-91PB1EBQ\SQLEXPRESS;Initial Catalog=LibraDatabase;Integrated Security=True";
        private SqlConnection? sqlConnection;
        private SqlCommand? sqlCommand;

        public void executeQuery(string strRecordSQL)
        {
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            sqlCommand = new SqlCommand(strRecordSQL, sqlConnection);
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable GetData(DataGridView dataGridView, string strRecordSQL)
        {
            try
            {
                sqlConnection = new SqlConnection(strConnection);
                SqlCommand sqlCommand = new SqlCommand(strRecordSQL, sqlConnection);
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sqlCommand;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                dataGridView.DataSource = table;
                sqlConnection.Close();
                return table;
            }
            catch(Exception exp)
            {
                MessageBox.Show("Data loaded unsuccessfully!");
                return null;
            }
        }
    }
}
