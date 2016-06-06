using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimplyBankUWP.Models
{
    public class AccountModel : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Credit> Credits { get; set; }

        public DbSet<Current> Currents { get; set; }

        public DbSet<Flow> Flows { get; set; }

        public DbSet<Forecast> Forecasts { get; set; }

        public DbSet<TypeOperation> TypeOperations { get; set; }

        public DbSet<Wording> Wordings { get; set; }

        public AccountModel()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=AccountDb.db");
        }
    }
}
