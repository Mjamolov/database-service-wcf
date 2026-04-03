using System.ServiceModel;

namespace DatabaseService
{
    [ServiceContract]
    public interface IDatabaseService
    {
        [OperationContract]
        string Connect();

        [OperationContract]
        string GetSqlVersion();

        [OperationContract]
        string Disconnect();
    }
}