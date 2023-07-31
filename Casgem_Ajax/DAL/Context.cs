using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-VFP0P7JM\\SQLEXPRESS01;initial Catalog=Casgem_AjaxDb;integrated Security=true");
        }
        public DbSet<Customer>Customers  { get; set; }
    }
}
