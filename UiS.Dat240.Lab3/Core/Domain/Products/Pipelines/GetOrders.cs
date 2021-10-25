using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UiS.Dat240.Lab3.Core.Domain.Ordering;

namespace UiS.Dat240.Lab3.Core.Domain.Products.Pipelines
{
	public class GetOrders
	{
		public record Request : IRequest<List<Order>> { }

		public class Handler : IRequestHandler<Request, List<Order>>
		{
			private readonly ShopContext _db;

			public Handler(ShopContext db)
			{
				_db = db ?? throw new ArgumentNullException(nameof(db));
			}

			public async Task<List<Order>> Handle(Request request, CancellationToken cancellationToken)
				=> await _db.Order.Include(p => p.Customer).OrderBy(i => i.Id).ToListAsync(cancellationToken: cancellationToken);
		}
	}
}