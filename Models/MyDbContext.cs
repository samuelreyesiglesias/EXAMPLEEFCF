using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EXAMPLEEFCF.Models
{
    public class MyDbContext: DbContext 
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
         public   DbSet<VersionOfMe> VersionOfMe { get; set; }
        public DbSet<CarGranTrofeo> CarGranTrofeo { get; set; }
    }

    public class VersionOfMe
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<CarGranTrofeo> CarGranTrofeos { get; set; }
    }
    public class CarGranTrofeo
    {
        public int id { get; set; }
        public string ModelCar { get; set; }
        //public int VersionOfMeId { get; set; }
        //public VersionOfMe VersionOfMe { get; set; }
    }
}
