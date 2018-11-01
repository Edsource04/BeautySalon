using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public sealed class ChargeOfAccount
    {
        public Int32 Id { get; set; }
        public DateTime EntryDate { get; set; }
        public Decimal Value { get; set; }
        public Int32 ClientId { get; set; }
        public bool IsPaid
        {
            get
            {
                return RemainingAmount == 0.0m;
            }
            set
            {
                IsPaid = value;
            }
        }
        public String User { get; set; }
        public Decimal Amount { get; set; }
        public Decimal RemainingAmount { get; set; }

        //Relationship
        public Client Client { get; set; }
        //public Sale Sale { get; set; }
    }
}
