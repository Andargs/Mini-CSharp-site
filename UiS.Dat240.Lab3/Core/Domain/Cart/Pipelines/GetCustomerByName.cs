using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UiS.Dat240.Lab3.Core.Domain.Ordering;

namespace UiS.Dat240.Lab3.Core.Domain.Cart.Pipelines
{
	public class GetCustomerByName
	{
		public record Request(string customerName) : IRequest<Customer?>;


		public class Handler : IRequestHandler<Request, Customer?>
		{
			private readonly ShopContext _db;

			public Handler(ShopContext db) => _db = db ?? throw new ArgumentNullException(nameof(db));

			public async Task<Customer?> Handle(Request request, CancellationToken cancellationToken)
				=> await _db.Customer.Include(c => c.Id)
										 .Where(c => c.Name == request.customerName)
										 .SingleOrDefaultAsync(cancellationToken);

		}
	}
}
