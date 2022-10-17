using BaterPonto.Models;
using Microsoft.EntityFrameworkCore;

namespace BaterPonto.DB
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions <BancoContext> options) : base(options)
        {
            
        }

        public DbSet<EmpresModel> Empresa { get; set; }
    }
}
