using EasyCashIdentitiyProject.EntitiyLayer;
using EasyCashIdentitiyProject.EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentitiyProject.DataAccessLayer.Concrete
{
    public  class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=OGUZHANCIRKIN02;initial catalog=EasyCashDb;integrated Security=true");
        }


        //Dbset c# ismi CustomerAccounts sql deki ismi olarak tanımlanır
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountsProcess { get; set; }

    }
}
