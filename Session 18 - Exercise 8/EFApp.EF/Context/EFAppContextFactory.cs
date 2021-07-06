using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp.EF.Context {
    public class EFAppContextFactory : IDesignTimeDbContextFactory<EFAppContext> {
        public EFAppContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<EFAppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new EFAppContext(optionsBuilder.Options);
        }
    }
}
