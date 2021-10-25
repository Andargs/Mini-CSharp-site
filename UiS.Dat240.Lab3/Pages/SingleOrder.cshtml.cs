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
using UiS.Dat240.Lab3.Core.Domain.Invoicing;

namespace UiS.Dat240.Lab3.Pages
{
	public class SingleOrderModel : PageModel
	{
		private readonly IMediator _mediator;

        private readonly ShopContext context;

		public SingleOrderModel(IMediator mediator) {
        _mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));
        }
        public Order _order { get; set; } = new();
        public Offer _offer {get; set;} = new();
        public Invoice _invoice {get; set;} = new();
        public string Name {get; set; } ="";
        public int id {get; set; }
        

		public async Task OnGetAsync(int id){ //Må være getorder
			_order = await _mediator.Send(new Core.Domain.Ordering.Pipelines.GetOrder.Request(id));
            _offer = await _mediator.Send(new Core.Domain.Fulfillment.Pipelines.GetOffer.Request(id));
            _invoice = await _mediator.Send(new Core.Domain.Invoicing.Pipelines.GetInvoice.Request(id));
        }


        public async Task<IActionResult> OnPostAsync(string Name, int id){
            Console.WriteLine("Kom inn i shipper ting");
            Console.WriteLine(Name);
            Console.WriteLine(id);
            if (Name is null || id < 0){
                return Page();
            }

            //var ferdig = await _mediator.Send(new Core.Domain.Fulfillment.Pipelines.OfferMaker.Request(Name,id));
            var offer = await _mediator.Send(new Core.Domain.Fulfillment.Pipelines.SetShipper.Request(id, Name));
            
            

			return RedirectToPage("Ordersview");
			
		}

	}
}