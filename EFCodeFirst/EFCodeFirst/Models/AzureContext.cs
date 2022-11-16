using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst.Models
{
    public class AzureContext:DbContext
    {
        public AzureContext(DbContextOptions<AzureContext> options) : base(options)
        {
        }

        public DbSet<LeeOrderDetails> LeeOrderDetails { get; set; }
        public DbSet<LeeOrder> LeeOrders { get; set; }
   
/*      
    protected override void OnConfiguring(DbContextOptionsBuilder ob)
    {
        ob.UseSqlServer(@"connection string");
    }
*/
    }//end of class
}
