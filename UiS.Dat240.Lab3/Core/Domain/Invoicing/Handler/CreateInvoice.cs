using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using System;
using UiS.Dat240.Lab3.Core.Domain.Invoicing.Events;

namespace UiS.Dat240.Lab3.Core.Domain.Invoicing.Handlers
{
    public class CreateInvoiceHandler : INotificationHandler<CreateInvoice>
    {
        private readonly ShopContext _db;

        public CreateInvoiceHandler(ShopContext db)
			=> _db = db ?? throw new System.ArgumentNullException(nameof(db));
        
        public async Task Handle(CreateInvoice notification, CancellationToken cancellationToken)
		{

			var orders = await _db.Order//.Include(o => o.OrderLines)
                            .Where(c => c.Id == notification.Id)
							.SingleOrDefaultAsync(cancellationToken);
            var sum = orders.GetSum();
            var inv = new Invoice(orders.Id, orders.Location.Building, orders.Location.RoomNumber, orders.Location.Notes);
            inv.Amount = sum;
            inv.Status = Status.Paid;
            var offer = await _db.Offer.Include(r => r.Reimbursement).Where(o => o.OrderId == notification.Id).SingleOrDefaultAsync(cancellationToken);
            offer.Reimbursement.InvoiceId = inv.Id;

            _db.Add(inv);
            await _db.SaveChangesAsync();

            // var rem = new Reimbursement(sum);
            // var off = new Offer(notification.Id, rem);
            // _db.Add(rem);
            // _db.Add(off);

			await _db.SaveChangesAsync(cancellationToken);
		}

    }

}