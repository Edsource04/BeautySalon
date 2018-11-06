using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Client
    {
        public Client()
        {
            this.ChargeOfAccounts = new HashSet<ChargeOfAccount>();
            this.PurchaseInvoices = new HashSet<PurchaseInvoice>();
            this.SaleInvoices = new HashSet<SaleInvoice>();
        }

        [Key]
        public Int32 IdClient { get; set; }

        public String FirstName { get; set; }
 
        public String LastName { get; set; }

	    public String Gender { get; set; }
        
        public DateTime? Birthday { get; set; }
	    
        public String DocumentType { get; set; }
	
        public String DocumentNumber { get; set; }
  
        public String Address { get; set; }

        public String Telephone { get; set; }
	    
        public String Email { get; set; }

        public bool Status { get; set; } = true;

        public String ClientCode { get; set; }

        public DateTime InsertedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }
	    
        public String InsertedBy { get; set; }
	    
        public String ModifiedBy { get; set; }
	
	    public String HostName { get; set; }

        //Relationship
        public virtual ICollection<ChargeOfAccount> ChargeOfAccounts { get; private set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; private set; }
        public virtual ICollection<SaleInvoice> SaleInvoices { get; private set; }
    }
}
