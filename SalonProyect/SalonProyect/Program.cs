using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Repository.Data;
using Domain.Models;
using Domain.Extensions;
using Domain.Tools;

namespace SalonProyect
{
    public static class Program
    {
        public static void Main(String[] args)
        {
            User user = new User
            {
                Username = "erivera",
                Password = "GalaxySt",
                Role = Domain.Enums.Role.Administrator,
                Status = true
            };

            using (var salonWorker = new SalonUnitWorker(new SalonContext()))
            {
                Client client1 = new Client
                {
                    FirstName = "Edgar Yovanny",
                    LastName = "Rivera Nolasco",
                    Address = "Respaldo la Milagrosa # 22 los Guandules",
                    Telephone = "809-621-0897",
                    Gender = "Male",
                    Birthday = new DateTime(1983, 11, 4),
                    DocumentType = "Cedula",
                    DocumentNumber = "001-1763172-1",
                    Email = "ing_edgar_rivera@hotmail.com",
                    Status = true,
                    ClientCode = "EDRN19831104",
                    InsertedBy = "Edgar Rivera",
                    ModifiedBy = String.Empty,
                    HostName = "ERIVERA"
                };

              
                Console.WriteLine(Encryption.Encrypt(user.Password));
                Console.WriteLine(Encryption.Decrypt("4+W1y4Rym8u/e4MCtKXKd7knXNG84jP4tO5PI7Pf76M="));
                Console.ReadKey();
               
            }
        }
    }
}
