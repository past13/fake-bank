namespace fake_bank_app
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    public class Transaction 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        public int Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
    }
}