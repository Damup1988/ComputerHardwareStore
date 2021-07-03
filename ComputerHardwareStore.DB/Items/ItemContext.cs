using ComputerHardwareStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardwareStore.DB.Items
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
    }
}