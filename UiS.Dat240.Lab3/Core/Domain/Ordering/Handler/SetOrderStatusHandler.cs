using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using System;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment.Pipelines;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Events;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering.Handlers
{
    public class SetOrderStatusHandler : INotificationHandler<SetOrderStatus>
    {
        private readonly ShopContext _db;

        public SetOrderStatusHandler(ShopContext db)
			=> _db = db ?? throw new System.ArgumentNullException(nameof(db));
        
        public async Task Handle(SetOrderStatus notification, CancellationToken cancellationToken)
		{
            Console.WriteLine("Endrer shipping status");
			var orders = await _db.Order
                            .Where(c => c.Id == notification.Id)
							.SingleOrDefaultAsync(cancellationToken);
            Console.WriteLine("Er her");
            Console.WriteLine("Kom inn i status endring");
            Console.WriteLine(orders.Id);
            orders.Status = Status.Placed;

            _db.Update(orders);
			await _db.SaveChangesAsync();
            await _db.SaveChangesAsync(cancellationToken);
		}

    }

}