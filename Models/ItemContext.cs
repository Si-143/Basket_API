using Microsoft.EntityFrameworkCore;

namespace API.Models
{
	public class ItemContext : DbContext
	{
		public ItemContext(DbContextOptions<ItemContext> options)
			: base(options)
		{
		}
        // create the basket to store items. 
		public DbSet<Items> BasketItems { get; set; }

	}
}