namespace fake_bank_app
{
    using MongoDB.Driver;
    public class TransactionService
    {
        private readonly IMongoCollection<Transaction> _transactions;
        public TransactionService(ITransactionDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _transactions = database.GetCollection<Transaction>(settings.TransactionCollectionName);
        }

        public Transaction GetTransaction()
        {
            return _transactions.Find(item => item._Id == "5dc7470845d862447f0cfa9c").FirstOrDefault();
        }
    }
}