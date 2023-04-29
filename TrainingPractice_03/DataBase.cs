using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrainingPractice_03
{
    class DataBase
    {
        SqlConnection _connection=new SqlConnection(@"Data Source=PC-EBLAN;Initial Catalog=BD_GasStation;
Integrated Security=True");

        public void openConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void closeConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
