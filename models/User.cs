namespace fake_bank_app.models
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public DateTime CreateDateTime { get; set; }
		public ICollection<Transaction> Transactions { get; set; }
    }
}