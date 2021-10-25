using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering
{
    //[NotMapped]
    public class OrderLine
    {
        public OrderLine(string item ,decimal price)
        {
            Item = item;
            Count = 0;
            Price = price;

        }

		public int Id { get; protected set; }

		public string Item { get; private set; } ="";
		public decimal Price { get; set; }
		public decimal Amount => Price * Count;

		public int Count { get; private set; }

        public void AddOne() => Count++;

    }
}