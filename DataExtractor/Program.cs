using MongoDB.Driver;
using System;
using System.Collections.Generic;
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

            Console.ReadLine();
        }
    }
}
