using System;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Core.Exceptions;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UiS.Dat240.Lab3.Core.Domain.Invoicing;

namespace UiS.Dat240.Lab3.Core.Domain.Invoicing.Pipelines
{
	public class GetInvoice
	{
		public record Request(int Id) : IRequest<Invoice?>;

		public class Handler : IRequestHandler<Request, Invoice?>
		{
			private readonly ShopContext _db;

			public Handler(ShopContext db) => _db = db ?? throw new ArgumentNullException(nameof(db));

			public async Task<Invoice?> Handle(Request request, CancellationToken cancellationToken)
			{
				var item = await _db.Invoice.Include(s => s.Address).SingleOrDefaultAsync(fi => fi.OrderId == request.Id, cancellationToken);
				if (item is null) throw new EntityNotFoundException($"Offer with Id {request.Id} was not found in the database");
				return item;
			}
		}
	}
}