namespace fake_bank_app
{
    public class TransactionDatabaseSettings : ITransactionDatabaseSettings
    {
        public string TransactionCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITransactionDatabaseSettings
    {
        string TransactionCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}