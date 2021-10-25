using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment
{
    public class Reimbursement : BaseEntity
    {
        public Reimbursement(decimal amount){ //Hadde originalt customername og notes, tror egentlig ikke jeg skal trenge location eller orderinglinesdto dritten
            Amount = amount;

        }
        public int Id { get; set; }

        public Shipper Shipper{ get; set; } =null!;

        public decimal Amount { get; protected set; }
        public int InvoiceId { get; set; }

    }
}