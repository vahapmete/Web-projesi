using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace MvcWebUI.Models
{
    public class RegisterViewModel: DbContext
    {
        public RegisterViewModel(DbContextOptions<RegisterViewModel> options) : base(options)
        {
        }

        public DbSet<Register> Users { get; set; }
    }
}
