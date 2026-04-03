using System;
using System.Windows.Forms;

namespace DatabaseClient
{
    public partial class Form1 : Form
    {
        private ServiceReference.DatabaseServiceClient _client;

        public Form1()
        {
            InitializeComponent();
            InitializeClient();
        }

        private void InitializeClient()
        {
            try
            {
                _client = new ServiceReference.DatabaseServiceClient();
                Log("Клиент сервиса инициализирован.");
            }
            catch (Exception ex)
            {
                Log($"Ошибка инициализации: {ex.Message}");
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Execute(() => _client.Connect(), "Подключение");
        }

        private void BtnGetVersion_Click(object sender, EventArgs e)
        {
            Execute(() => _client.GetSqlVersion(), "Получение версии SQL");
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            Execute(() => _client.Disconnect(), "Отключение");
        }

        private void Execute(Func<string> action, string operationName)
        {
            if (_client == null)
            {
                Log("Клиент не инициализирован.");
                return;
            }

            try
            {
                Log($"--- {operationName} ---");
                var result = action();
                Log(result);
            }
            catch (Exception ex)
            {
                Log($"Ошибка: {ex.Message}");
            }
        }

        private void Log(string message)
        {
            txtOutput.AppendText(message + Environment.NewLine);
        }
    }
}