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

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment.Handlers
{
    public class OrderPlaceddosHandler : INotificationHandler<OrderPlaceddos>
    {
        private readonly ShopContext _db;

        public OrderPlaceddosHandler(ShopContext db)
			=> _db = db ?? throw new System.ArgumentNullException(nameof(db));
        
        public async Task Handle(OrderPlaceddos notification, CancellationToken cancellationToken)
		{
            Console.WriteLine("Er i offer laging");
			var orders = await _db.Order//.Include(o => o.OrderLines)
                            .Where(c => c.Id == notification.Id)
							.SingleOrDefaultAsync(cancellationToken);
            Console.WriteLine("Lager offer");
            Console.WriteLine(notification.Id);
            Console.WriteLine("Kom inn for å lage offer");
            orders.Status = Status.Placed;
            var sum = orders.GetSum();
            var rem = new Reimbursement(sum);
            var off = new Offer(notification.Id, rem);
            orders.Status = Status.Placed;
            _db.Add(rem);
            _db.Add(off);

			await _db.SaveChangesAsync(cancellationToken);
		}

    }

}