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
using System;
using Microsoft.AspNetCore.Http;

namespace UiS.Dat240.Lab3.Pages
{
	public class CartModel : PageModel
	{
		private readonly IMediator _mediator;

		public CartModel(IMediator mediator) => _mediator = mediator ?? throw new System.ArgumentNullException(nameof(mediator));

		public ShoppingCart? Cart { get; private set; }

		public string Building {get; set;} ="";
		public int RoomNumber {get; set;}

		public string NotesBuild {get; set;} ="";
		public string Name {get; set;} = "";
		public string Notes {get; set;} = "";

		public async Task OnGetAsync()
		{
			var cartId = HttpContext.Session.GetGuid("CartId");
			if (cartId is null) return;

			Cart = await _mediator.Send(new Get.Request(cartId.Value));
		}


		//[BindProperty(SupportsGet = true)]
		public async Task<IActionResult> OnPostAsync(string Building, int RoomNumber, string NotesBuild,  string Name){
			//Send shit til iordering dritten og service
			// Console.WriteLine(Building);
			// Console.WriteLine(RoomNumber);
			// Console.WriteLine(NotesBuild);
			// Console.WriteLine(Name);
			// Console.WriteLine(Notes);
			if (Building is null || RoomNumber <= 0 || NotesBuild is null || Name is null){
				return Page();
			}
			var loc = new Core.Domain.Ordering.Location(Building, RoomNumber,NotesBuild);
			var cartId = HttpContext.Session.GetGuid("CartId");
			if (cartId is null) return Page();

			var orderid = await _mediator.Send(new CartCheckout.Request(loc, Name, cartId.Value));

			Console.WriteLine(orderid);

			

			//Core.Domain.Ordering.Services.IOrderingService.PlaceOrder(loc, Name, orderinglines);

			

			//OrderLineDto[] temp = new OrderLineDto[0]();
			
			//var result = await _mediator.Send(new Ordering.Request(loc, Name, orderinglines)); //Fjern notes, legg inn order.lines
			//if (result.Success) return Page();
			//var result = Core.Domain.Ordering.Services.OrderingService.PlaceOrder(loc, Name, orderinglines);

			//Errors = result.Errors;

			cartId = Guid.NewGuid();
			HttpContext.Session.SetString("CartId", cartId.ToString());


			return Page();
			
		}
	}
}
 