using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

namespace Spottyfy
{
    public class DataBaseConnect
    {
        public IDB connection;

        public DataBaseConnect(int dbType)
        {
            IDB connection = null;
            switch (dbType)
            {
                case 1:
                    connection = new MongoDB();
                    break;
                case 2:
                    connection = new MySqlDB();
                    break;
                default:
                    break;
            }
            this.connection = connection;
        }
    } 
}
