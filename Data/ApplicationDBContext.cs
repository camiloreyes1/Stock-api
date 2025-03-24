using MongoDB.Driver;

namespace api.Data
{
    public class ApplicationDBContext
    {
        private readonly IMongoDatabase _database;

        // Constructor to initialize the MongoDB connection
        public ApplicationDBContext(string connectionString, string databaseName)
        {
            // Create a MongoClient instance
            var client = new MongoClient(connectionString);

            // Get the specified database
            _database = client.GetDatabase(databaseName);
        }

        // Method to retrieve a collection of a specific type
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
