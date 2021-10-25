using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;

namespace UiS.Dat240.Lab3.Core.Domain.Products.Events
{
	public record OrderPlaced : BaseDomainEvent
	{
		public OrderPlaced(int orderId){
			Id = orderId;
		}

		public int Id {get; }
		public Status? Status {get;}




	}

}