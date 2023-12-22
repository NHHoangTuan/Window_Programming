using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.Helpers
{
    public class SQLData
    {

        private static SQLData? _instance = null;
        private SqlConnection _connection = null;


        public SQLData() => ResetConnection();

        public void ResetConnection()
        {
            try
            {
                string? connectionString = AppConfig.ConnectionString();
                _connection = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }


        }

        public SqlConnection? Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConnectionString); ;
                    _connection.Open();
                }

                return _connection;
            }
        }
        public string ConnectionString { get; set; } = "";

        public static SQLData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SQLData();
                }

                return _instance;
            }
        }


        /*public async void Connect(string connectionString)
        {
            await Task.Run(() => {
                var _connection = new SqlConnection(connectionString);

                try
                {
                    _connection.Open();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    _connection = null;
                }
                return _connection;
            });
        }*/

        public void Connect()
        {
            ResetConnection();
            _connection.Open();
        }

    }
}
