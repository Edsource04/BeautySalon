using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Repository.Data;
using Domain.Models;
using Domain.Extensions;

namespace SalonProyect
{
    public static class Program
    {
        public static void Main(String[] args)
        {
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

                
                Console.ReadKey();
               
            }
        }
    }
}
