using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Events;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment.Handlers;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment.Events;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering
{
    public class Order : BaseEntity
    {
        public Order(){

        }
        public Order(Location location,string customerName){ //Hadde originalt customername og notes, tror egentlig ikke jeg skal trenge location eller orderinglinesdto dritten
            Customer = new Customer(customerName);
            Location = location;
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; protected set;}

        public DateTime OrderDate { get; set; }

        private readonly List<OrderLine> _orderLines = new();
		public IEnumerable<OrderLine> OrderLines => _orderLines.AsReadOnly();

        public Location? Location { get; protected set; } = null!;
        public string Notes { get; protected set; } ="";
        public Customer Customer { get; protected set; } = null!;

        public Status Status {get;set;}
        // private Status _status;
        // public Status Status { get => _status;
        //  set{
        //      _status = Status.Placed;
        //      //Events.Add(new SetOrderStatus(Id));  //Funker kanskje, hvis ikke så er erroren her.
        //      //_status = Status.Placed;
             
        //      //Console.WriteLine("Id i Order: " + Id);
        //      //var sum = GetSum();
        //      //var rem = new Reimbursement(sum);
        //      //new Offer(Id, rem);
        //      //Events.Add(new OrderPlaceddos(Id));
        //      //Events.Add(new SetOrderStatus(Id));
        //      //_status = Status.Shipped;
        //  }
        //  }

        public void AddOrderLine(string itemname, decimal itemprice){
            
				OrderLine orderline = new(itemname, itemprice);
				_orderLines.Add(orderline);
			
			orderline.AddOne();
        }

        public decimal GetSum(){
            decimal sum = 0;
            foreach (var order in _orderLines){
                sum += order.Price * order.Count;
            }
            return sum;
        }



        public class OrderLocationValidator : IValidator<Order>
	{
		public (bool, string) IsValid(Order item)
		{
			_ = item ?? throw new ArgumentNullException(nameof(item), "Cannot validate a null object");
			if (item.Location is null) return (false, $"{nameof(item.Location)} must be set");
			return (true, "");
		}
	}

        public class OrderCustomeralidator : IValidator<Order>
	{
		public (bool, string) IsValid(Order item)
		{
			_ = item ?? throw new ArgumentNullException(nameof(item), "Cannot validate a null object");
			if (item.Customer is null) return (false, $"{nameof(item.Customer)} must be set");
			return (true, "");
		}
	}
    
        

    }
}