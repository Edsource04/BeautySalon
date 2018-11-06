using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Extensions
{
    public static class ClientExtension
    {
        public static String GetClientCode(this Client client)
        {
            String SecondLetter = String.Empty;
            String FirstLetter = String.Empty;
            String FirstLast = String.Empty;
            String LastLast = String.Empty;
            String clientCode = String.Empty;

            Int32 indexN = client.FirstName.IndexOf(' ');
            Int32 indexL = client.LastName.IndexOf(' ');

            clientCode = client.FirstName[0].ToString();

            if(indexN > 0)
            {
                SecondLetter = client.FirstName.Substring(indexN, 2);
                clientCode = clientCode + SecondLetter.Trim();
            }

            clientCode = clientCode + client.LastName[0].ToString();

            if(indexL > 0)
            {
                LastLast = client.LastName.Substring(indexL, 2);
                clientCode = clientCode + LastLast.Trim();
            }

            if(client.Birthday == null)
            {
                DateTime today = DateTime.Now;
                clientCode = clientCode + today.Year.ToString() + today.Month.ToString() + today.Day.ToString();
            }

            clientCode = clientCode + client.Birthday.Value.Year.ToString() + client.Birthday.Value.Month.ToString() + client.Birthday.Value.Day.ToString();

            return clientCode;

            

            
        }
    }
}
