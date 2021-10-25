using System;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Core.Exceptions;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment.Pipelines
{
	public class GetOffer
	{
		public record Request(int Id) : IRequest<Offer?>;

		public class Handler : IRequestHandler<Request, Offer?>
		{
			private readonly ShopContext _db;

			public Handler(ShopContext db) => _db = db ?? throw new ArgumentNullException(nameof(db));

			public async Task<Offer?> Handle(Request request, CancellationToken cancellationToken)
			{
				var item = await _db.Offer.Include(s => s.Shipper).Include(r => r.Reimbursement).SingleOrDefaultAsync(fi => fi.OrderId == request.Id, cancellationToken);
				if (item is null) throw new EntityNotFoundException($"Offer with Id {request.Id} was not found in the database");
				return item;
			}
		}
	}
}
