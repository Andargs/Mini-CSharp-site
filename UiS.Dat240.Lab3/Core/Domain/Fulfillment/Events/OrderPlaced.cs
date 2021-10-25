using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment.Events
{
	public record OrderPlaceddos : BaseDomainEvent
	{
		public OrderPlaceddos(int orderId){
			Id = orderId;

		}

	
		public int Id {get; }
		
}

}