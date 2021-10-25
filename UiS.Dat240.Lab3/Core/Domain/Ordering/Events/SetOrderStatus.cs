using UiS.Dat240.Lab3.SharedKernel;
using System;
using System.Collections.Generic;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering.Events
{
	public record SetOrderStatus : BaseDomainEvent
	{
		public SetOrderStatus(int orderId){
			Id = orderId;
		}

		public int Id {get; }
		//public Status? Status {get; set;}
	}

}