using System.Threading.Tasks;
using UiS.Dat240.Lab3.Core.Domain.Cart;
using UiS.Dat240.Lab3.Core.Domain.Cart.Pipelines;
using UiS.Dat240.Lab3.Helpers;
using UiS.Dat240.Lab3.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using System;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment.Pipelines;
using UiS.Dat240.Lab3.Core.Exceptions;
using UiS.Dat240.Lab3.Core.Domain.Fulfillment;
using UiS.Dat240.Lab3.Infrastructure.Data;
using UiS.Dat240.Lab3.Core.Domain.Products.Events;

namespace UiS.Dat240.Lab3.Pages
{
	public class OrdersviewModel : PageModel
	{
		private readonly IMediator _mediator;

        private readonly ShopContext context;

		public OrdersviewModel(IMediator mediator) => _mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));
        public List<Order> _orders { get; set; } = new();
        public List<Offer> _offers {get; set;} = new();
        public string Name {get; set; } ="";
        public int id {get; set; }
        

		public async Task OnGetAsync(){
			_orders = await _mediator.Send(new Core.Domain.Products.Pipelines.GetOrders.Request());
            _offers = await _mediator.Send(new Core.Domain.Fulfillment.Pipelines.GetOffers.Request());
        }
        //     try
		// 	{
		// 		var Item = await _mediator.Send(new GetOffer.Request(id));
		// 	}
		// 	catch (EntityNotFoundException)
		// 	{
		// 		Console.WriteLine("Fant ikke offer");
		// 	}

        // }

		//[BindProperty(SupportsGet = true)]


        public async Task<IActionResult> OnPostAsync(int id){
            
            var order = await _mediator.Send(new Core.Domain.Ordering.Pipelines.GetOrder.Request(id));           

            //var ferdig = await _mediator.Send(new Core.Domain.Fulfillment.Pipelines.OfferMaker.Request(Name,id));
            //var offer = await _mediator.Send(new Core.Domain.Fulfillment.Pipelines.SetShipper.Request(id, Name));
            if(order == null){
                return Page();

            }

            return RedirectToPage($"./SingleOrder/{id}");
            
			
		}

	}
}
 