using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public class DataBaseConnect
    {
        int dbType;
        public DataBaseConnect(int db)
        {
            dbType = db;
        }

        public string Connect()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://admin:phW6oW8s7K0TTFHK@spottyfy.teapla0.mongodb.net/?retryWrites=true&w=majority");
            Console.WriteLine("DB type is: " + dbType);
            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }

            //string data[] = string.Join(" ", dbList[0]);
            Console.WriteLine("DB list: " + dbList.ToJson());
            //Console.WriteLine("Data: " + data.ToJson());
            string data = dbList.ToJson();
            
            return data;
        } 
    }
}
