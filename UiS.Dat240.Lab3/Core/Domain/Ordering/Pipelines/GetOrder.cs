using System;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Core.Exceptions;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering.Pipelines
{
	public class GetOrder
	{
		public record Request(int Id) : IRequest<Order?>;

		public class Handler : IRequestHandler<Request, Order?>
		{
			private readonly ShopContext _db;

			public Handler(ShopContext db) => _db = db ?? throw new ArgumentNullException(nameof(db));

			public async Task<Order?> Handle(Request request, CancellationToken cancellationToken)
			{
				var item = await _db.Order.Include(c => c.Customer).Include(b => b.Location).Include(i => i.OrderLines).SingleOrDefaultAsync(fi => fi.Id == request.Id, cancellationToken);
				if (item is null) throw new EntityNotFoundException($"Offer with Id {request.Id} was not found in the database");
				return item;
			}
		}
	}
}