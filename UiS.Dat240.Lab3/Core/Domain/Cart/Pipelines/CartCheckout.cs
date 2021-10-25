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
using UiS.Dat240.Lab3.SharedKernel;

namespace UiS.Dat240.Lab3.Core.Domain.Cart.Pipelines
{
	public class CartCheckout
	{
		public record Request(
            // int ItemId,
			// string ItemName,
			// decimal ItemPrice,
			//Guid CartId) : IRequest<Unit>;
			//Object location,
			//object customer,
            Location location,
            string Name,
			Guid CartId) : IRequest<Unit>;

		public record Response(bool Success, string[] Errors);

		public class Handler : IRequestHandler<Request>
		{

			private readonly IEnumerable<IValidator<Order>> _validators;
			private readonly ShopContext _db; 
            private readonly IOrderingService _orderingService;
			private readonly IMediator _mediator;

			public Handler(ShopContext db, IOrderingService orderingService, IMediator mediator, IEnumerable<IValidator<Order>> validators) { 
				_db = db ?? throw new ArgumentNullException(nameof(db));
				_orderingService = orderingService ?? throw new ArgumentNullException(nameof(orderingService));
				_mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
				_validators = validators ?? throw new ArgumentNullException(nameof(validators));
			}
			public async Task<Unit> Handle(Request request, CancellationToken cancellationToken)
			{

				var cust = new Customer(request.Name);
                
				var cart = _db.ShoppingCart.Include(c => c.Items).SingleOrDefault(c => c.Id == request.CartId);
				if (cart == null)
				{
					cart = new ShoppingCart(request.CartId);
					_db.ShoppingCart.Add(cart);
				}

                //List<Ordering.Dto.OrderLineDto> orderlist = new List<Ordering.Dto.OrderLineDto>();
                List<Ordering.Dto.OrderLineDto> orderlist2 = new List<Ordering.Dto.OrderLineDto>();
                foreach(var item in cart.Items){
                    var element = new Ordering.Dto.OrderLineDto(item.Sku, item.Name, item.Count, item.Price);
                    orderlist2.Add(element);
					Console.WriteLine(element);
                    //orderlist.Add();
                    //orderlist.Add(new Ordering.Dto.OrderLineDto { item.Id, item.Name, item.Amount, item.Price});
                    
                }
                var orderlist = orderlist2.ToArray();

				//var noe = await orderingService.PlaceOrder(loc, name, orderlist);

                var orderid = await _orderingService.PlaceOrder(request.location, request.Name, orderlist); 
                //var noe = await Ordering.Services.OrderingService.PlaceOrder(loc, cust.Name, orderlist);
				

				Console.WriteLine(orderid);

				

                

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

