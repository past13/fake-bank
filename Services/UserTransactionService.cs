namespace fake_bank_app
{
    using fake_bank_app.models;
    using MongoDB.Driver;
    public class UserTransactionService
    {
        private readonly IMongoCollection<Transaction> _transactions;
        private readonly IMongoCollection<User> _users;

        public UserTransactionService(ITransactionDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
           
            _users = database.GetCollection<User>(settings.UserCollectionName);
            _transactions = database.GetCollection<Transaction>(settings.TransactionCollectionName);
        }

        public Transaction GetTransaction()
        {
            return _transactions.Find(item => item._Id == "5dc7470845d862447f0cfa9c").FirstOrDefault();
        }

        public User GetUser()
        {
            return _users.Find(item => item.Id == "5dc8088945d862447f0cfa9d").FirstOrDefault();
        }
    }
}