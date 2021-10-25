using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment
{
    public class Offer : BaseEntity
    {
        public Offer(){
            
        }
        public Offer(int order, Reimbursement rem){
            OrderId = order;
            Reimbursement = rem;

            
        }

        public int Id { get; set; }
        public int OrderId {get; set;}
        
        public Shipper? Shipper { get; set; } = null!;

        public Reimbursement Reimbursement { get; set; }
    }
}