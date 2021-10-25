using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using System;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment.Events;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment.Pipelines
{
    public class SetShipper
    {
		public record Request(
			int Id,
			string name) : IRequest<Unit>;

		
		public record Response(bool Success, string[] Errors);

		public class Handler : IRequestHandler<Request>
		{
            private readonly IMediator _mediator;

			private readonly ShopContext _db;
			public Handler(ShopContext db, IMediator mediator){
				_db = db ?? throw new ArgumentNullException(nameof(db));
                _mediator = mediator ?? throw new ArgumentNullException(nameof(db));
			}
			public async Task<Unit> Handle(Request request, CancellationToken cancellationToken){
				Console.WriteLine("Starta å endre");
			var offers = await _db.Offer
                            .Where(c => c.OrderId == request.Id)
							.SingleOrDefaultAsync(cancellationToken);
            Console.WriteLine("Setter shipper");
			Console.WriteLine(request.Id + "   " + request.Id);
			Console.WriteLine("Det her er offer.OrderId:  " + offers.OrderId);
			var orders = await _db.Order.Where(c => c.Id == request.Id).SingleOrDefaultAsync(cancellationToken);
			var ship = new Shipper(request.name);
            offers.Shipper = ship;
			orders.Status = Status.Shipped;

			var inv = await _db.Invoice.Where(c => c.OrderId == request.Id).SingleOrDefaultAsync(cancellationToken);
			inv.Status = Invoicing.Status.Paid;

			_db.Update(orders);
			_db.Update(inv);
            //Console.WriteLine(offers.Id);
            //var noe = await _mediator.Send(new OrderPlaceddos(request.Id));
            
			await _db.SaveChangesAsync(cancellationToken);


            

			return Unit.Value;
			}
		}
		
	}}