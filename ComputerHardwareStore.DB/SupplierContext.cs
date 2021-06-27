using ComputerHardwareStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardwareStore.DB
{
    public class SupplierContext : DbContext
    {
        public SupplierContext(DbContextOptions<SupplierContext> options) : base(options)
        {
            
        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}