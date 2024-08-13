using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MagazynEdu.DataAccess
{
    public class WarehouseStorageContextFactory : IDesignTimeDbContextFactory<WarehouseStorageContext>
    {
        public WarehouseStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ECA7K89\\MJMIKAEL2014;Initial Catalog=WarehouseStorageV1;Integrated Security=True");
            return new WarehouseStorageContext(optionsBuilder.Options);
        }
    }
}
