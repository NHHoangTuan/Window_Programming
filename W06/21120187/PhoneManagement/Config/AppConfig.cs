using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.Config
{
    internal class AppConfig
    {
        public static string Server = "Server";
        public static string Database = "Database";
        public static string NumberProductPerPage = "NumberProductPerPage";

        public static string? GetValue(string key)
        {
            ConfigurationManager.RefreshSection("appSettings");

            string? value = ConfigurationManager
                .AppSettings[key];
            return value;
        }

        public static void SetValue(string key, string value)
        {
            var configFile = ConfigurationManager
            .OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            settings[key].Value = value;

            configFile.Save(ConfigurationSaveMode.Minimal);
        }

        public static string? ConnectionString()
        {
            string? result = "";

            var builder = new SqlConnectionStringBuilder();
            string? server = AppConfig.GetValue(AppConfig.Server);
            string? database = AppConfig.GetValue(AppConfig.Database);
            string? numProductPerPage = AppConfig.GetValue(AppConfig.NumberProductPerPage);


            builder.DataSource = $"{server}";
            builder.InitialCatalog = database;
            builder.TrustServerCertificate = true;
            //builder.UserID = Username;
            // builder.Password = Password;   
            builder.IntegratedSecurity = true;
            builder.ConnectTimeout = 3; // s

            result = builder.ToString();
            return result;
        }
    }
}
