// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks;
// using UiS.Dat240.Lab3.Core.Domain.Products.Events;
// using UiS.Dat240.Lab3.Infrastructure.Data;
// using MediatR;
// using Microsoft.EntityFrameworkCore;
// using UiS.Dat240.Lab3.Core.Domain.Ordering;
// using System;
// using UiS.Dat240.Lab3.Core.Domain.Fullfillment.Handlers;

// namespace UiS.Dat240.Lab3.Core.Domain.Cart.Handlers
// {
//     public class SetShipperHandler : INotificationHandler<SetShipper>
//     {
//         private readonly ShopContext _db;

//         public SetShipperHandler(ShopContext db)
// 			=> _db = db ?? throw new System.ArgumentNullException(nameof(db));
        
//         public async Task Handle(SetShipper notification, CancellationToken cancellationToken)
// 		{
//             Console.WriteLine("Starta å endre");
// 			var orders = await _db.Order
//                             .Where(c => c.Id == notification.Id)
// 							.ToListAsync(cancellationToken);
//             Console.WriteLine("Er her");
//             foreach (var order in orders)
// 			{
// 				if (order.Id == notification.Id){
//                     Console.WriteLine("Kom inn i status endring");
//                     order.Status = Status.Shipped;
//                 }
// 			}
// 			await _db.SaveChangesAsync(cancellationToken);
// 		}

//     }

// }