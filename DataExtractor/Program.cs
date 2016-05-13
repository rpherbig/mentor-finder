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
            var client = new MongoClient("mongodb://username:password@myserver/databaseName");
            var collection = client.GetDatabase("databaseName").GetCollection<PersonDocument>("people");
            var results = collection.FindSync(b => true);
            var doc = results.First();
            Console.Out.WriteLine(doc.email);

            Console.ReadLine();
        }
    }
}
