using System.Threading.Tasks;
using System;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using UiS.Dat240.Lab3.Infrastructure.Data;
using MediatR;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Events;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment.Events;
using UiS.Dat240.Lab3.Core.Domain.Invoicing.Events;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering.Services
{
    public interface IOrderingService
    {
        Task<int> PlaceOrder(Location location, string customerName, OrderLineDto[] orderLines);//{
         
        
    }

    public class OrderingService : IOrderingService{
        private readonly ShopContext context;
        private readonly IMediator _mediator;

        public OrderingService(ShopContext context, IMediator mediator)
        {
            this._mediator = mediator;
            this.context = context;
        }
        public async Task<int> PlaceOrder(Location location, string customerName, OrderLineDto[] orderLines){//{
            //new Location(location.Building,location.RoomNumber,location.Notes);
            //new Customer(customerName);
            //
            var cust = new Customer(customerName);
            Console.WriteLine(location);
            Console.WriteLine(customerName);
            Console.WriteLine(orderLines);

            var order = new Ordering.Order(location, customerName);
            foreach(var item in orderLines){
                order.AddOrderLine(item.FoodItemName, item.Price);
            }
            order.OrderDate = DateTime.UtcNow;
            
            order.Status = Status.Placed;
            context.Order.Add(order);

            await context.SaveChangesAsync();

            Console.WriteLine(order);
            Console.WriteLine("Her burde verdien inkrementeres: " + order.Id + "  :" + order.Customer.Name);

            //context.Customer.Add(cust);
            await _mediator.Publish(new SetOrderStatus(order.Id));
            await _mediator.Publish(new OrderPlaceddos(order.Id));
            await _mediator.Publish(new CreateInvoice(order.Id));
            Console.WriteLine(order.Customer.Name);

            

            return await Task.FromResult(order.Id);
            //return Task.FromResult(0);
            //return order.Id;

            //var order = new Order(location, customerName, orderLines);
            
            
            //noe piss
            
        }

    }


}