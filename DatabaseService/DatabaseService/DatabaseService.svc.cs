using System;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using System.Configuration;

namespace DatabaseService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DatabaseService : IDatabaseService
    {
        private static readonly object SyncRoot = new object();
        private static SqlConnection _connection;

        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public string Connect()
        {
            try
            {
                lock (SyncRoot)
                {
                    if (_connection == null)
                    {
                        _connection = new SqlConnection(ConnectionString);
                    }

                    if (_connection.State != ConnectionState.Open)
                    {
                        _connection.Open();
                    }
                }

                return "Подключение к БД успешно установлено.";
            }
            catch (Exception ex)
            {
                return $"Ошибка подключения: {ex.Message}";
            }
        }

        public string GetSqlVersion()
        {
            try
            {
                if (_connection == null || _connection.State != ConnectionState.Open)
                {
                    return "Нет активного подключения к БД.";
                }

                using (var command = new SqlCommand("SELECT @@VERSION", _connection))
                {
                    var result = command.ExecuteScalar();
                    return result?.ToString() ?? "Не удалось получить версию SQL Server.";
                }
            }
            catch (Exception ex)
            {
                return $"Ошибка при получении версии SQL Server: {ex.Message}";
            }
        }

        public string Disconnect()
        {
            try
            {
                lock (SyncRoot)
                {
                    if (_connection != null)
                    {
                        if (_connection.State != ConnectionState.Closed)
                        {
                            _connection.Close();
                        }

                        _connection.Dispose();
                        _connection = null;
                    }
                }

                return "Подключение к БД закрыто.";
            }
            catch (Exception ex)
            {
                return $"Ошибка при закрытии подключения: {ex.Message}";
            }
        }
    }
}