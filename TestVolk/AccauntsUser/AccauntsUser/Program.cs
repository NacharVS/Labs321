using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace AccountsUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            account.AddPers();
            account.AddPers();

            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TestUsers");
            IMongoCollection<Account> collection = database.GetCollection<Account>("UsersGame");
            collection.InsertOne(account);
        }
    }
}
