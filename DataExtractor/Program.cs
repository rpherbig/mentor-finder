using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];
            var server = ConfigurationManager.AppSettings["server"];
            var database = ConfigurationManager.AppSettings["database"];
            var connectionString = String.Format("mongodb://{0}:{1}@{2}/{3}",
                username, password, server, database);

            var client = new MongoClient(connectionString);
            var collection = client.GetDatabase(database).GetCollection<PersonDocument>("people");
            var results = collection.FindSync(b => true);
            var doc = results.First();
            Console.Out.WriteLine(doc.email);

            Console.ReadLine();
        }
    }
}
