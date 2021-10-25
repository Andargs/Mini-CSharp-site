using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment
{
    public class Shipper : BaseEntity
    {
        public Shipper(string name){ 
            Name = name;
        }
        public int Id { get; set; }
        private string name;
        public string Name { get; set;}
        

    }
}