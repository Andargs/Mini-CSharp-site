using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UiS.Dat240.Lab3.Core.Domain.Ordering;

namespace UiS.Dat240.Lab3.Core.Domain.Invoicing
{
    public class Invoice : BaseEntity // ikke migrated
    {
        public Invoice(){

        }
        public Invoice(int orderid, string building, int roomNumber,string notes){ //Hadde originalt customername og notes, tror egentlig ikke jeg skal trenge location eller orderinglinesdto dritten
            OrderId = orderid;
            Address = new Address(building, roomNumber, notes);
            
        }
        public int Id { get; set; }

        public Customer? Customer { get; set; } = null!;

        public Address? Address { get; set; } = null!;
        public Decimal Amount { get; set; } 
        public int OrderId { get; set; }
        public Status? Status { get; set; }
        

    }
}