using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Spottyfy
{
    public class MongoIDStandardizer
    {
        public string StandardizeString(string id)
        {
            string songIDString = id.ToString();
            string zeroes = "";
            for (int i = 0; i < (24 - songIDString.Length); i++)
            {
                zeroes += "0";
            }
            zeroes += songIDString;
            return zeroes;
        }

        public string RevertChanges(string changedString)
        {
            string revertedString = "";
            for(int i = 0; i < changedString.Length; i++) 
            {
                if (changedString[i] != '0')
                {
                    revertedString += changedString[i];
                }
            }

            return revertedString;
        }

    }
}
