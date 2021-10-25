using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UiS.Dat240.Lab3.Core.Domain.Ordering;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment.Pipelines
{
	public class GetOffers
	{
		public record Request : IRequest<List<Offer>> { }

		public class Handler : IRequestHandler<Request, List<Offer>>
		{
			private readonly ShopContext _db;

			public Handler(ShopContext db)
			{
				_db = db ?? throw new ArgumentNullException(nameof(db));
			}

			public async Task<List<Offer>> Handle(Request request, CancellationToken cancellationToken)
				=> await _db.Offer.Include(p => p.Shipper).OrderBy(i => i.Id).ToListAsync(cancellationToken: cancellationToken);
		}
	}
}