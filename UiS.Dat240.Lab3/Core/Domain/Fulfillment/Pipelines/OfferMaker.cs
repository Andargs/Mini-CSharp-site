using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Services;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment.Pipelines
{
	public class OfferMaker
	{
		public record Request(
            // int ItemId,
			// string ItemName,
			// decimal ItemPrice,
			//Guid CartId) : IRequest<Unit>;
			//Object location,
			//object customer,
            string Name,
			int Id) : IRequest<Unit>;

		public record Response(bool Success, string[] Errors);

		public class Handler : IRequestHandler<Request>
		{
			private readonly ShopContext _db; 
            private readonly IOrderingService _orderingService;
			private readonly IMediator _mediator;

			public Handler(ShopContext db, IOrderingService orderingService, IMediator mediator) { 
				_db = db ?? throw new ArgumentNullException(nameof(db));
				_orderingService = orderingService ?? throw new ArgumentNullException(nameof(orderingService));
				_mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
			}
			public async Task<Unit> Handle(Request request, CancellationToken cancellationToken)
			{
                
				Console.WriteLine("Er i offer laging");
				Console.WriteLine("Dette er orderid" + request.Id);
			    var orders = await _db.Order.Include(o => o.OrderLines)
                            .Where(c => c.Id == request.Id)
							.SingleOrDefaultAsync(cancellationToken);
                
				Console.WriteLine(request.Id);
				Console.WriteLine(request.Name);
                var sum = orders.GetSum();
                var rem = new Reimbursement(sum);
                var offer = new Offer(request.Id,rem);
				//orders.Status = Status.Shipped;

                await _db.SaveChangesAsync(cancellationToken);

				return Unit.Value;
				//foreach(var item in cart){

                }

               // var items= ShoppingCart.IEnumerable();

                //foreach(var item in cart){

               // }


				
			}

		}
	}
