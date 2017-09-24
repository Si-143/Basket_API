using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Linq;
namespace BasketApi.Controllers
{


	[Route("api/[controller]")]// e.g /api/Basket
	public class BasketController : Controller
	{
        private readonly ItemContext _context;

        public BasketController(ItemContext context)
		{
			_context = context;

            // check if their are any items are in the basket 
            if (_context.BasketItems.Count() == 0)
			{
                // if their are no items then it would create a item that informs the customer that there are no items in the basket 
                _context.BasketItems.Add(new Items { Name = "None", Quantity = 0 });
				_context.SaveChanges();
			}
		}
        // get Items from basket
		[HttpGet]
		public IEnumerable<Items> GetAll()
		{
            // returns all the items that are in the basket. 
            return _context.BasketItems.ToList();
		}

        // Allow the customer to display one item in the basket based on ID 
        [HttpGet("{id}", Name = "GetItem")] 
        public IActionResult GetById(int id)
        {
            // Checks if the item's ID exist in the basket. 
            var item = _context.BasketItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                // return error if it is unable to find ID 
                return NotFound();
            }
            return new ObjectResult(item);
        }


		// Add Item to Basket, uses HTTP POST Method e.g /api/Basket
		[HttpPost] 
		public IActionResult Add([FromBody] Items item)
		{
            // check if item exist when submiting the Post method. 
			if (item == null)
			{
                // display a error if null is found. 
				return BadRequest();
			}
            //  add items into basket
            _context.BasketItems.Add(item);
            // save changes. 
			_context.SaveChanges();

            //  display newly added item
            return CreatedAtRoute("GetItem", new { id = item.Id  }, item);
		}

		// Update Items, Use HTTP PUT Request e.g /api/Basket/1 
		[HttpPut("{id}")]
		public IActionResult Update(int id, [FromBody] Items item)
		{
            //  check if item's ID exist 
			if (item == null || item.Id != id)
			{
				return BadRequest();
			}
            // find item's ID in the basket. 
            var UpdateItems = _context.BasketItems.FirstOrDefault(t => t.Id == id);
			if (UpdateItems == null)
			{
                // returns this if not found 
				return NotFound();
			}
            //  update quantity if ID is found. 
            UpdateItems.Quantity = item.Quantity;

            // update the basket and save changes. 
			_context.BasketItems.Update(UpdateItems);
			_context.SaveChanges();
			return new NoContentResult();
		}
		// Remove Items, Uses HTTP Delete Request e.g /api/Basket/1
		[HttpDelete("{id}")]
        public IActionResult Delete(int id)
		{
			// Checks if the item's ID exist in the basket. 
			var RemoveItem = _context.BasketItems.FirstOrDefault(t => t.Id == id);
			if (RemoveItem == null)
			{
				// returns this if not found 
				return NotFound();
			}
            // remove item from basket and save chanages. 
			_context.BasketItems.Remove(RemoveItem);
			_context.SaveChanges();
			return new NoContentResult();
		}


	}

}
