using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapPhim.Classes
{   
    internal class DataProcess
    {
        private string strConnect = "Data Source=DESKTOP-R0144NR\\SQLEXPRESS;Initial Catalog=QLRapPhim;Integrated Security=True";
        private SqlConnection sqlConnection = null;

        private void OpenConnect()
        {
            sqlConnection = new SqlConnection(strConnect);
            if(sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        private void CloseConnect()
        {
            if(sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        public void ChangeDatabase(string querry)
        {
            OpenConnect();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            CloseConnect();
            cmd.Dispose();
        }

        public DataTable ReadDatabase(string querry)
        {
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(querry,sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CloseConnect();
            adapter.Dispose();
            return table;
        }
    }
}
