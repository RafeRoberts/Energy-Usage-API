
using Energy_Usage_API.Models;
using MongoDB.Driver;
using System.Data;

namespace Energy_Usage_API.Reposities
{
    public class MongoDBEnergyRepository : IAccountsRepository
    {
        private const string databaseName = "energyMeter";
        private const string collectionName = "accounts";

        private readonly IMongoCollection<Account> accountsCollection;
        public MongoDBEnergyRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            accountsCollection = database.GetCollection< Account>(collectionName);
        }

        public void CreateAccount(Account account)
        {
            accountsCollection.InsertOne(account);
        }
    }

   
}