using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public class UserData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //[BsonElement("basic-info")]
        public string name { get; set; }

        public string password { get; set; }

        public string rank { get; set; }

        public DateTime creationDate { get; set; }

        public int money { get; set; }

        public int Buy(SongData song)
        {
            try
            {
                if(song.cost > this.money)
                {
                    Console.WriteLine("User does not have enough money");
                    AlertBox alertBox = new AlertBox();
                    alertBox.UpdateLabelTextAndCenterFAILED("User does not have enough money");
                    alertBox.Show();
                }
                else
                {
                    this.money -= song.cost;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                AlertBox alertBox = new AlertBox();
                alertBox.UpdateLabelTextAndCenterFAILED(ex.Message);
                alertBox.Show();
                return -1;
            }
            return 0;
        }
    }
}
