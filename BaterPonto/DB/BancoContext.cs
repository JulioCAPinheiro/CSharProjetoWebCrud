using BaterPonto.Models;
using Microsoft.EntityFrameworkCore;

namespace BaterPonto.DB
{
    public class BancoContext : DbContext
    {
        //Aqui representamos o Banco de dados que rememos criar
        public BancoContext(DbContextOptions <BancoContext> options) : base(options)
        {
            
        }

        public DbSet<EmpresModel> Empresa { get; set; }
    }
}
