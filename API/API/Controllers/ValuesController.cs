using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;
namespace API.Controllers
{

	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		// GET api/values
		[HttpGet]
        public IEnumerable<Items> Get()
		{
            return new List <Items> {
                new Items{Id = 1, Name = "Apples",  Quantity = 1 },
			    new Items { Id = 2, Name = "Orange",  Quantity = 4 },
				new Items{Id = 3, Name = "Pears",  Quantity = 10 }
            };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}




		// POST api/values
		[HttpPost]
        public void Post([FromBody]Items value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
        public void Put(int id, [FromBody]Items value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}