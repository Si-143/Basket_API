using System;
namespace API.Models
{
    // create the Item object, which contains ID,Name and Quantity 
    public class Items
    {
        public int Id { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
    }
}
