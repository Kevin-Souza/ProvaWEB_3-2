using Microsoft.EntityFrameworkCore;
using ProvaWeb3_2.Models;

namespace ProvaWeb3_2.Data
{
    public class AppCont : DbContext 
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Produto> produtos { get; set; }
    }

    
}
