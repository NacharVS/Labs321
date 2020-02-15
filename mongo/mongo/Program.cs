using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using System.Threading.Tasks;


namespace mongo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Account");
            var collec = database.GetCollection<Account>("Gamer");
            Account p2 = new Account() { Mail = "assq ", Pass = 212 };
            p2.Wafreme = new Wafreme { Name = "212", Power = 212, Ult = "1212"  };
            p2.Quest = new Quest { Naz = "212" };
            collec.InsertOne(p2);
           
            Console.WriteLine(collec);
            Console.Read();
        }
        
    }
}
